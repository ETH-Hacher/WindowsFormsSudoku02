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
        private bool isZeitSudoku = false;

        public SudokuGame()
        {
            InitializeComponent();
            CreateCells();
            StartNewGame();
        }

        private void StartNewGame()
        {
            isZeitSudoku = false;

            LoadValues();

            int hintsCount;
            if (beginnerLevel.Checked)
            {
                hintsCount = 45;
                hintsButtonCount = 3;
            }
            else if (IntermediateLevel.Checked)
            {
                hintsCount = 30;
                hintsButtonCount = 4;
            }
            else if (AdvancedLevel.Checked)
            {
                hintsCount = 15;
                hintsButtonCount = 5;
            }
            else
            {
                beginnerLevel.Checked = true;
                hintsCount = 45;
                hintsButtonCount = 3;
            }
            ShowRandomValuesHints(hintsCount);
        }

        Random random = new Random();

        private void ShowRandomValuesHints(int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

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

                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].KeyPress += Cell_keyPressed;
                    cells[i, j].MouseClick += Cell_ClickedOn;
                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }



        private void NumsBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (selectedCell == null || selectedCell.IsLocked)
                return;

            if (int.TryParse(btn.Text, out int value))
            {
                selectedCell.Text = btn.Text;
                selectedCell.ForeColor = Color.Green;
            }
        }

        private SudokuCell selectedCell;

        private void Cell_ClickedOn(object sender, MouseEventArgs e)
        {
            selectedCell = sender as SudokuCell;

            if (selectedCell.IsLocked)
            {
                selectedCell = null;
                return;
            }
        }

        private void Cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            if (selectedCell is null)
            {
                return;
            }

            if (e.KeyChar == '0')
            {
                selectedCell.Clear();
                return;
            }
            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out int value))
            {
                selectedCell.Text = value.ToString();
                selectedCell.ForeColor = Color.Green;
            }
        }


        private void LoadValues()
        {
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
                if (++i > 8)                // If the row ends move to the next row
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
                cells[i, j].Value = value;
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

        private int chkButtonCount = 3;
        private int hintsButtonCount = 3;

        private void ChkButton_Click(object sender, EventArgs e)
        {
            chkButtonCount--;
            if (chkButtonCount == 0)
                ChkButton.Enabled = false;

            var wrongCells = new List<SudokuCell>();
            // Check if there are remaining attempts for using the Check button
            if (chkButtonCount > 0)
            {
                foreach (var cell in cells)
                {
                    if (!cell.IsLocked)
                    {
                        if (!string.Equals(cell.Value.ToString(), cell.Text))
                        {
                            cell.ForeColor = Color.Red;
                        }
                        else
                        {
                            cell.Font = new Font(cell.Font, FontStyle.Bold);
                            cell.ForeColor = Color.Beige;
                        }
                    }
                }

                if (isFullyFilled && cellTextNotEmptyOrNull)
                {
                    MessageBox.Show("Congratulations! You won");
                }
            }
        }

        private void ClrButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                if (!cell.IsLocked)
                    cell.Clear();
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        int ZeitSudokuLevel;
        private void LoadZeitSudoku_Click(object sender, EventArgs e)
        {
            isZeitSudoku = true;
            var currentDate = DateTime.Now;

            if (easyZeitLvl.Checked)
            {
                ZeitSudokuLevel = 2;
                hintsButtonCount = 3;
            }
            else if (normalZeitLvl.Checked)
            {
                ZeitSudokuLevel = 3;
                hintsButtonCount = 4;
            }
            else if (hardZeitLvl.Checked)
            {
                ZeitSudokuLevel = 4;
                hintsButtonCount = 5;
            }
            else if (veryHardZeitLvl.Checked)
            {
                ZeitSudokuLevel = 5;
                hintsButtonCount = 6;
            }
            else if (extremeHardZeitLvl.Checked)
            {
                ZeitSudokuLevel = 6;
                hintsButtonCount = 7;
            }
            else
            {
                ZeitSudokuLevel = 2;
                easyZeitLvl.Checked = true;
                hintsButtonCount = 3;
            }


            HttpClient client = new HttpClient();

            // Construct the URL based on the selected level and the current date
            var sudokuUrl = client.GetFromJsonAsync<ZeitDeSudoku>($"https://sudoku.zeit.de/sudoku/level/{ZeitSudokuLevel}/{currentDate.Year}-{currentDate.Month}-{currentDate.Day}").Result;

            for (int i = 0; i < 81; i++)
            {
                var X = i % 9;
                var Y = i / 9;
                SudokuCell cell = cells[X, Y];
                cell.Clear();
                cell.BackColor = ((X / 3) + (Y / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
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

        private void HintsBtn_Click(object sender, EventArgs e)
        {
            // Check if there are remaining attempts for using the Hints button
            if (hintsButtonCount > 0)
            {
                var emptyCells = cells.Cast<SudokuCell>().Where(cell => !cell.IsLocked && string.IsNullOrEmpty(cell.Text)).ToList();

                if (emptyCells.Any())
                {
                    var randomEmptyCell = emptyCells[random.Next(emptyCells.Count)];
                    randomEmptyCell.Text = randomEmptyCell.Value.ToString();
                    randomEmptyCell.Font = new Font(randomEmptyCell.Font, FontStyle.Bold);
                    randomEmptyCell.ForeColor = Color.Brown;

                    // Decrement the Hints button count
                    hintsButtonCount--;

                    // Disable the Hints button after 3 attempts
                    if (hintsButtonCount == 0)
                        HintsBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No empty cells to provide hints!");
                }
            }
            else
            {
                MessageBox.Show("You've used all your Hints attempts!");
            }
        }

        public bool SolveSudoku()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // search an empty cell
                    if (cells[row, col].Value == 0)
                    {
                        // try possible numbers
                        for (int number = 1; number <= 9; number++)
                        {
                            if (IsValid(row, col, number))
                            {
                                cells[row, col].Value = number;

                                if (SolveSudoku())
                                { // start backtracking recursively
                                    return true;
                                }
                                else
                                { // if not a solution, empty the cell and continue
                                    cells[row, col].Value = 0;
                                }
                            }
                        }
                        cells[row, col].Font = new Font(DefaultFont.FontFamily, 20, FontStyle.Bold);
                        cells[row, col].ForeColor = Color.Goldenrod;

                        return false;
                    }
                }
            }
            return true; // sudoku solved
        }

        public bool IsValid(int row, int col, int num)
        {
            // Check the line
            for (int d = 0; d < 9; d++)
            {
                if (cells[row, d].Value == num)
                {
                    return false;
                }
            }

            // Check the column
            for (int r = 0; r < 9; r++)
            {
                if (cells[r, col].Value == num)
                {
                    return false;
                }
            }

            // Check the box
            int sqrt = (int)Math.Sqrt(9);
            int boxRowStart = row - row % sqrt;
            int boxColStart = col - col % sqrt;

            for (int r = boxRowStart; r < boxRowStart + sqrt; r++)
            {
                for (int d = boxColStart; d < boxColStart + sqrt; d++)
                {
                    if (cells[r, d].Value == num)
                    {
                        return false;
                    }
                }
            }
            // If there is no clash, it's safe
            return true;
        }

        private void SolveItButton_Click(object sender, EventArgs e)
        {
            if (!isZeitSudoku)
            {
                if (SolveSudoku())
                {
                    // Update the UI with the solved Sudoku
                    for (int row = 0; row < 9; row++)
                    {
                        for (int col = 0; col < 9; col++)
                        {
                            cells[row, col].Text = cells[row, col].Value.ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No solution found for the given Sudoku.");
                }
            }
            else
            {
                var currentDate = DateTime.Now;
                HttpClient client = new HttpClient();
                var sudokuUrl = client.GetFromJsonAsync<ZeitDeSudoku>($"https://sudoku.zeit.de/sudoku/level/{ZeitSudokuLevel}/{currentDate.Year}-{currentDate.Month}-{currentDate.Day}").Result;


                for (int i = 0; i < 81; i++)
                {
                    var X = i % 9;
                    var Y = i / 9;
                    SudokuCell cell = cells[X, Y];
                    cell.Clear();
                    cell.BackColor = ((X / 3) + (Y / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cell.FlatStyle = FlatStyle.Popup;
                    cell.ForeColor = Color.Blue;

                    if (int.TryParse(sudokuUrl.game[i].ToString().Trim('.'), out int val))
                    {
                        cell.Value = val;
                        cell.Text = val.ToString();
                        cell.IsLocked = false;
                    }
                }
            }
        }
    }
}
