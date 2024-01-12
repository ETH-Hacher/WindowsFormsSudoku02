using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsSudoku02
{
    public partial class SudokuGame : Form
    {
        public SudokuGame()
        {
            InitializeComponent();
            CreateCells();
            StartNewGame();
        }

        private void StartNewGame()
        {
            LoadValues();

            int hintsCount = 0;
            // Assign the hints count based on the Difficulty player chosen
            if (beginnerLevel.Checked)
                hintsCount = 45;
            else if (IntermediateLevel.Checked)
                hintsCount = 30;
            else if (AdvancedLevel.Checked)
                hintsCount = 15;
            else
            {
                beginnerLevel.Checked = true;
                hintsCount = 45;
            }
            ShowRandomValuesHints(hintsCount);
        }

        Random random = new Random();
        private void ShowRandomValuesHints(int hintsCount)
        {
            // Show value in random cells
            // The hints count is based on the level player choose
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                // Style the hint cells differently and
                // lock the cell so that player can't edit the value
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].FlatAppearance.BorderColor = Color.DarkRed;
                cells[rX, rY].ForeColor = Color.Blue;
                cells[rX, rY].IsLocked = true;
            }
        }

        // 9x9 sudoku board
        SudokuCell[,] cells = new SudokuCell[9, 9];
        private void CreateCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCell
                    {
                        Font = new Font(DefaultFont.FontFamily, 20),
                        Size = new Size(60, 60),
                        ForeColor = SystemColors.ControlDark,
                        Location = new Point(i * 60, j * 60),
                        BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray,
                        FlatStyle = FlatStyle.Popup,
                        X = i,
                        Y = j
                    };

                    // Add border color
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;

                    // Assign key press event for each cells
                    cells[i, j].KeyPress += Cell_keyPressed;

                    // Add the cells to the panel
                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void Cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out int value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void LoadValues()
        {
            // Clear the Values in each cell
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }
            FindValueForNextCell(0, -1);
        }

        private bool FindValueForNextCell(int i, int j)
        {
            // Increment the i and j values to move to the next cell
            // and if the columsn ends move to the next row
            if (++j > 8)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 8)
                    return true;
            }
            int value;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number with do while loop
            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }
                // Take a random number from the numbers left in the list
                value = numsLeft[random.Next(0, numsLeft.Count)];

                // Set the value in the cell
                cells[i, j].Value = value;

                // Remove the allocated value from the list
                numsLeft.Remove(value);

            }
            while
            (!IsValidNumber(value, i, j) || !FindValueForNextCell(i, j));

            return true;
        }


        private bool IsValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void ChkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();

            // Find all the wrong inputs
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                    wrongCells.Add(cell);
            }

            // Check if the inputs are wrong or the player wins the game
            if (wrongCells.Any())
            {
                // Highlight the wrong inputs 
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong inputs");
            }
            else
                MessageBox.Show("Congratulations! You won the game");
        }

        private void ClrButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                // Clear the cell only if it is not locked
                if (!cell.IsLocked)
                    cell.Clear();
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void LoadZeitSudoku_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;
            var ZeitSudokuLevel = 0;


            if (easyZeitLvl.Checked)
                ZeitSudokuLevel = 2;
            else if (normalZeitLvl.Checked)
                ZeitSudokuLevel = 3;
            else if (hardZeitLvl.Checked)
                ZeitSudokuLevel = 4;
            else if (veryHardZeitLvl.Checked)
                ZeitSudokuLevel = 5;
            else if (extremeHardZeitLvl.Checked)
                ZeitSudokuLevel = 6;
            else
            {
                ZeitSudokuLevel = 2;
                easyZeitLvl.Checked = true;
            }


            HttpClient client = new HttpClient();
            // Construct the URL based on the selected level and the current date
            var sudokuUrl = client.GetFromJsonAsync<ZeitDeSudoku>($"https://sudoku.zeit.de/sudoku/level/{ZeitSudokuLevel}/{currentDate.Year}-{currentDate.Month}-{currentDate.Day}").Result;

            for (int i = 0; i < 81; i++)
            {
                SudokuCell cell = cells[i % 9, i / 9];
                cell.Clear();
                cell.BackColor = ((i % 9 / 3) + (i / 9 / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                cell.FlatStyle = FlatStyle.Popup;
                cell.ForeColor = Color.Blue;

                if (int.TryParse(sudokuUrl.game[i].ToString().Trim('.'), out int val))
                {
                    cell.Value = val;
                    cell.Text = val.ToString();
                    cell.IsLocked = true;
                }
            }
        }
    }
}