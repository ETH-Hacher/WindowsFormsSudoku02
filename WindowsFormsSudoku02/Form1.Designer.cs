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
            this.NewGameButton.ForeColor = System.Drawing.Color.Red;
            this.NewGameButton.Location = new System.Drawing.Point(655, 187);
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
            this.beginnerLevel.Location = new System.Drawing.Point(685, 287);
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
            this.IntermediateLevel.Location = new System.Drawing.Point(685, 310);
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
            this.AdvancedLevel.Location = new System.Drawing.Point(685, 333);
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
            this.difficulty.Location = new System.Drawing.Point(679, 253);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(129, 31);
            this.difficulty.TabIndex = 8;
            this.difficulty.Text = "Difficulty";
            // 
            // LoadZeitSudoku
            // 
            this.LoadZeitSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LoadZeitSudoku.ForeColor = System.Drawing.Color.Black;
            this.LoadZeitSudoku.Location = new System.Drawing.Point(655, 363);
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
            this.difficultyZeitDe.Location = new System.Drawing.Point(679, 424);
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
            this.hardZeitLvl.Location = new System.Drawing.Point(685, 504);
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
            this.normalZeitLvl.Location = new System.Drawing.Point(685, 481);
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
            this.easyZeitLvl.Location = new System.Drawing.Point(685, 458);
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
            this.extremeHardZeitLvl.Location = new System.Drawing.Point(685, 551);
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
            this.veryHardZeitLvl.Location = new System.Drawing.Point(685, 528);
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
            this.solveItButton.Location = new System.Drawing.Point(655, 581);
            this.solveItButton.Name = "solveItButton";
            this.solveItButton.Size = new System.Drawing.Size(207, 40);
            this.solveItButton.TabIndex = 16;
            this.solveItButton.Text = "Solve it!";
            this.solveItButton.UseVisualStyleBackColor = true;
            // 
            // SudokuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 633);
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
            this.MaximumSize = new System.Drawing.Size(895, 672);
            this.MinimumSize = new System.Drawing.Size(895, 672);
            this.Name = "SudokuGame";
            this.Text = "Sudoku";
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
    }
}

