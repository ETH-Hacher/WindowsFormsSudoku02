namespace WindowsFormsSudoku02
{
    partial class SudokuGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkButton = new System.Windows.Forms.Button();
            this.ClrButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.IntermediateLevel = new System.Windows.Forms.RadioButton();
            this.AdvancedLevel = new System.Windows.Forms.RadioButton();
            this.difficulty = new System.Windows.Forms.Label();
            this.LoadZeitSudoku = new System.Windows.Forms.Button();
            this.difficultyZeitDe = new System.Windows.Forms.Label();
            this.hardZeitLvl = new System.Windows.Forms.RadioButton();
            this.normalZeitLvl = new System.Windows.Forms.RadioButton();
            this.easyZeitLvl = new System.Windows.Forms.RadioButton();
            this.extremeHardZeitLvl = new System.Windows.Forms.RadioButton();
            this.veryHardZeitLvl = new System.Windows.Forms.RadioButton();
            this.solveItButton = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.HintsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 0;
            // 
            // ChkButton
            // 
            this.ChkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ChkButton.ForeColor = System.Drawing.Color.Black;
            this.ChkButton.Location = new System.Drawing.Point(655, 19);
            this.ChkButton.Name = "ChkButton";
            this.ChkButton.Size = new System.Drawing.Size(207, 67);
            this.ChkButton.TabIndex = 1;
            this.ChkButton.Text = "Check Input";
            this.ChkButton.UseVisualStyleBackColor = true;
            this.ChkButton.Click += new System.EventHandler(this.ChkButton_Click);
            // 
            // ClrButton
            // 
            this.ClrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ClrButton.ForeColor = System.Drawing.Color.Black;
            this.ClrButton.Location = new System.Drawing.Point(655, 101);
            this.ClrButton.Name = "ClrButton";
            this.ClrButton.Size = new System.Drawing.Size(207, 58);
            this.ClrButton.TabIndex = 2;
            this.ClrButton.Text = "Clear Input";
            this.ClrButton.UseVisualStyleBackColor = true;
            this.ClrButton.Click += new System.EventHandler(this.ClrButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NewGameButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.NewGameButton.Location = new System.Drawing.Point(655, 204);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(207, 63);
            this.NewGameButton.TabIndex = 3;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.beginnerLevel.ForeColor = System.Drawing.Color.Green;
            this.beginnerLevel.Location = new System.Drawing.Point(685, 304);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(97, 24);
            this.beginnerLevel.TabIndex = 4;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "Biginner";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // IntermediateLevel
            // 
            this.IntermediateLevel.AutoSize = true;
            this.IntermediateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IntermediateLevel.ForeColor = System.Drawing.Color.Blue;
            this.IntermediateLevel.Location = new System.Drawing.Point(685, 327);
            this.IntermediateLevel.Name = "IntermediateLevel";
            this.IntermediateLevel.Size = new System.Drawing.Size(131, 24);
            this.IntermediateLevel.TabIndex = 5;
            this.IntermediateLevel.TabStop = true;
            this.IntermediateLevel.Text = "Intermediate";
            this.IntermediateLevel.UseVisualStyleBackColor = true;
            // 
            // AdvancedLevel
            // 
            this.AdvancedLevel.AutoSize = true;
            this.AdvancedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AdvancedLevel.ForeColor = System.Drawing.Color.Red;
            this.AdvancedLevel.Location = new System.Drawing.Point(685, 350);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(108, 24);
            this.AdvancedLevel.TabIndex = 6;
            this.AdvancedLevel.TabStop = true;
            this.AdvancedLevel.Text = "Advanced";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.difficulty.Location = new System.Drawing.Point(679, 270);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(129, 31);
            this.difficulty.TabIndex = 8;
            this.difficulty.Text = "Difficulty";
            // 
            // LoadZeitSudoku
            // 
            this.LoadZeitSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LoadZeitSudoku.ForeColor = System.Drawing.Color.Black;
            this.LoadZeitSudoku.Location = new System.Drawing.Point(655, 393);
            this.LoadZeitSudoku.Name = "LoadZeitSudoku";
            this.LoadZeitSudoku.Size = new System.Drawing.Size(207, 58);
            this.LoadZeitSudoku.TabIndex = 9;
            this.LoadZeitSudoku.Text = "Zeit Sudoku";
            this.LoadZeitSudoku.UseVisualStyleBackColor = true;
            this.LoadZeitSudoku.Click += new System.EventHandler(this.LoadZeitSudoku_Click);
            // 
            // difficultyZeitDe
            // 
            this.difficultyZeitDe.AutoSize = true;
            this.difficultyZeitDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.difficultyZeitDe.Location = new System.Drawing.Point(679, 454);
            this.difficultyZeitDe.Name = "difficultyZeitDe";
            this.difficultyZeitDe.Size = new System.Drawing.Size(129, 31);
            this.difficultyZeitDe.TabIndex = 13;
            this.difficultyZeitDe.Text = "Difficulty";
            // 
            // hardZeitLvl
            // 
            this.hardZeitLvl.AutoSize = true;
            this.hardZeitLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.hardZeitLvl.ForeColor = System.Drawing.Color.IndianRed;
            this.hardZeitLvl.Location = new System.Drawing.Point(685, 534);
            this.hardZeitLvl.Name = "hardZeitLvl";
            this.hardZeitLvl.Size = new System.Drawing.Size(68, 24);
            this.hardZeitLvl.TabIndex = 12;
            this.hardZeitLvl.TabStop = true;
            this.hardZeitLvl.Text = "Hard";
            this.hardZeitLvl.UseVisualStyleBackColor = true;
            // 
            // normalZeitLvl
            // 
            this.normalZeitLvl.AutoSize = true;
            this.normalZeitLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.normalZeitLvl.ForeColor = System.Drawing.Color.Blue;
            this.normalZeitLvl.Location = new System.Drawing.Point(685, 511);
            this.normalZeitLvl.Name = "normalZeitLvl";
            this.normalZeitLvl.Size = new System.Drawing.Size(87, 24);
            this.normalZeitLvl.TabIndex = 11;
            this.normalZeitLvl.TabStop = true;
            this.normalZeitLvl.Text = "Normal";
            this.normalZeitLvl.UseVisualStyleBackColor = true;
            // 
            // easyZeitLvl
            // 
            this.easyZeitLvl.AutoSize = true;
            this.easyZeitLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.easyZeitLvl.ForeColor = System.Drawing.Color.Green;
            this.easyZeitLvl.Location = new System.Drawing.Point(685, 488);
            this.easyZeitLvl.Name = "easyZeitLvl";
            this.easyZeitLvl.Size = new System.Drawing.Size(68, 24);
            this.easyZeitLvl.TabIndex = 10;
            this.easyZeitLvl.TabStop = true;
            this.easyZeitLvl.Text = "Easy";
            this.easyZeitLvl.UseVisualStyleBackColor = true;
            // 
            // extremeHardZeitLvl
            // 
            this.extremeHardZeitLvl.AutoSize = true;
            this.extremeHardZeitLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.extremeHardZeitLvl.ForeColor = System.Drawing.Color.Red;
            this.extremeHardZeitLvl.Location = new System.Drawing.Point(685, 581);
            this.extremeHardZeitLvl.Name = "extremeHardZeitLvl";
            this.extremeHardZeitLvl.Size = new System.Drawing.Size(143, 24);
            this.extremeHardZeitLvl.TabIndex = 15;
            this.extremeHardZeitLvl.TabStop = true;
            this.extremeHardZeitLvl.Text = "Extreme Hard";
            this.extremeHardZeitLvl.UseVisualStyleBackColor = true;
            // 
            // veryHardZeitLvl
            // 
            this.veryHardZeitLvl.AutoSize = true;
            this.veryHardZeitLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.veryHardZeitLvl.ForeColor = System.Drawing.Color.DarkRed;
            this.veryHardZeitLvl.Location = new System.Drawing.Point(685, 558);
            this.veryHardZeitLvl.Name = "veryHardZeitLvl";
            this.veryHardZeitLvl.Size = new System.Drawing.Size(112, 24);
            this.veryHardZeitLvl.TabIndex = 14;
            this.veryHardZeitLvl.TabStop = true;
            this.veryHardZeitLvl.Text = "Very Hard";
            this.veryHardZeitLvl.UseVisualStyleBackColor = true;
            // 
            // solveItButton
            // 
            this.solveItButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.solveItButton.ForeColor = System.Drawing.Color.Black;
            this.solveItButton.Location = new System.Drawing.Point(660, 663);
            this.solveItButton.Name = "solveItButton";
            this.solveItButton.Size = new System.Drawing.Size(207, 40);
            this.solveItButton.TabIndex = 16;
            this.solveItButton.Text = "Solve it!";
            this.solveItButton.UseVisualStyleBackColor = true;
            this.solveItButton.Click += new System.EventHandler(this.solveItButton_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn1.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn1.Location = new System.Drawing.Point(61, 653);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn2.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn2.Location = new System.Drawing.Point(117, 653);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn3.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn3.Location = new System.Drawing.Point(173, 653);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn4.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn4.Location = new System.Drawing.Point(229, 653);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn5.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn5.Location = new System.Drawing.Point(285, 653);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 21;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn6.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn6.Location = new System.Drawing.Point(341, 653);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 20;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn7.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn7.Location = new System.Drawing.Point(397, 653);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 50);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn8.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn8.Location = new System.Drawing.Point(459, 653);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 50);
            this.btn8.TabIndex = 24;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn9.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn9.Location = new System.Drawing.Point(521, 653);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 50);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumsBtn_MouseClick);
            // 
            // HintsBtn
            // 
            this.HintsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.HintsBtn.ForeColor = System.Drawing.Color.Black;
            this.HintsBtn.Location = new System.Drawing.Point(660, 611);
            this.HintsBtn.Name = "HintsBtn";
            this.HintsBtn.Size = new System.Drawing.Size(207, 40);
            this.HintsBtn.TabIndex = 26;
            this.HintsBtn.Text = "Hints!";
            this.HintsBtn.UseVisualStyleBackColor = true;
            this.HintsBtn.Click += new System.EventHandler(this.HintsBtn_Click);
            // 
            // SudokuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 715);
            this.Controls.Add(this.HintsBtn);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.solveItButton);
            this.Controls.Add(this.extremeHardZeitLvl);
            this.Controls.Add(this.veryHardZeitLvl);
            this.Controls.Add(this.difficultyZeitDe);
            this.Controls.Add(this.hardZeitLvl);
            this.Controls.Add(this.normalZeitLvl);
            this.Controls.Add(this.easyZeitLvl);
            this.Controls.Add(this.LoadZeitSudoku);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.AdvancedLevel);
            this.Controls.Add(this.IntermediateLevel);
            this.Controls.Add(this.beginnerLevel);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.ClrButton);
            this.Controls.Add(this.ChkButton);
            this.Controls.Add(this.panel1);
            this.Name = "SudokuGame";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChkButton;
        private System.Windows.Forms.Button ClrButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.RadioButton beginnerLevel;
        private System.Windows.Forms.RadioButton IntermediateLevel;
        private System.Windows.Forms.RadioButton AdvancedLevel;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.Button LoadZeitSudoku;
        private System.Windows.Forms.Label difficultyZeitDe;
        private System.Windows.Forms.RadioButton hardZeitLvl;
        private System.Windows.Forms.RadioButton normalZeitLvl;
        private System.Windows.Forms.RadioButton easyZeitLvl;
        private System.Windows.Forms.RadioButton extremeHardZeitLvl;
        private System.Windows.Forms.RadioButton veryHardZeitLvl;
        private System.Windows.Forms.Button solveItButton;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button HintsBtn;
    }
}

