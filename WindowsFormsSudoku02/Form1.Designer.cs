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
            this.ChkCellBtn = new System.Windows.Forms.Button();
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
            this.SolveItButton = new System.Windows.Forms.Button();
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
            this.TimerPauseBtn = new System.Windows.Forms.Button();
            this.TimerResumeBtn = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerTxt = new System.Windows.Forms.Label();
            this.ChkAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 19);
            this.panel1.MaximumSize = new System.Drawing.Size(550, 550);
            this.panel1.MinimumSize = new System.Drawing.Size(550, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 550);
            this.panel1.TabIndex = 0;
            // 
            // ChkCellBtn
            // 
            this.ChkCellBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ChkCellBtn.ForeColor = System.Drawing.Color.Black;
            this.ChkCellBtn.Location = new System.Drawing.Point(609, 19);
            this.ChkCellBtn.Name = "ChkCellBtn";
            this.ChkCellBtn.Size = new System.Drawing.Size(90, 50);
            this.ChkCellBtn.TabIndex = 1;
            this.ChkCellBtn.Text = "Check Cell";
            this.ChkCellBtn.UseVisualStyleBackColor = true;
            this.ChkCellBtn.Click += new System.EventHandler(this.ChkCellBtn_Click);
            // 
            // ClrButton
            // 
            this.ClrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ClrButton.ForeColor = System.Drawing.Color.Black;
            this.ClrButton.Location = new System.Drawing.Point(609, 91);
            this.ClrButton.Name = "ClrButton";
            this.ClrButton.Size = new System.Drawing.Size(207, 46);
            this.ClrButton.TabIndex = 2;
            this.ClrButton.Text = "Clear Input";
            this.ClrButton.UseVisualStyleBackColor = true;
            this.ClrButton.Click += new System.EventHandler(this.ClrButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NewGameButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.NewGameButton.Location = new System.Drawing.Point(609, 293);
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
            this.beginnerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.beginnerLevel.Location = new System.Drawing.Point(639, 393);
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
            this.IntermediateLevel.Location = new System.Drawing.Point(639, 416);
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
            this.AdvancedLevel.Location = new System.Drawing.Point(639, 439);
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
            this.difficulty.Location = new System.Drawing.Point(633, 359);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(129, 31);
            this.difficulty.TabIndex = 8;
            this.difficulty.Text = "Difficulty";
            // 
            // LoadZeitSudoku
            // 
            this.LoadZeitSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LoadZeitSudoku.ForeColor = System.Drawing.Color.Black;
            this.LoadZeitSudoku.Location = new System.Drawing.Point(609, 478);
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
            this.difficultyZeitDe.Location = new System.Drawing.Point(633, 539);
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
            this.hardZeitLvl.Location = new System.Drawing.Point(639, 619);
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
            this.normalZeitLvl.Location = new System.Drawing.Point(639, 596);
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
            this.easyZeitLvl.Location = new System.Drawing.Point(639, 573);
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
            this.extremeHardZeitLvl.Location = new System.Drawing.Point(639, 666);
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
            this.veryHardZeitLvl.Location = new System.Drawing.Point(639, 643);
            this.veryHardZeitLvl.Name = "veryHardZeitLvl";
            this.veryHardZeitLvl.Size = new System.Drawing.Size(112, 24);
            this.veryHardZeitLvl.TabIndex = 14;
            this.veryHardZeitLvl.TabStop = true;
            this.veryHardZeitLvl.Text = "Very Hard";
            this.veryHardZeitLvl.UseVisualStyleBackColor = true;
            // 
            // SolveItButton
            // 
            this.SolveItButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SolveItButton.ForeColor = System.Drawing.Color.Black;
            this.SolveItButton.Location = new System.Drawing.Point(440, 578);
            this.SolveItButton.Name = "SolveItButton";
            this.SolveItButton.Size = new System.Drawing.Size(134, 40);
            this.SolveItButton.TabIndex = 16;
            this.SolveItButton.Text = "Solve it!";
            this.SolveItButton.UseVisualStyleBackColor = true;
            this.SolveItButton.Click += new System.EventHandler(this.SolveItButton_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn1.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn1.Location = new System.Drawing.Point(44, 636);
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
            this.btn2.Location = new System.Drawing.Point(100, 636);
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
            this.btn3.Location = new System.Drawing.Point(156, 636);
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
            this.btn4.Location = new System.Drawing.Point(212, 636);
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
            this.btn5.Location = new System.Drawing.Point(268, 636);
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
            this.btn6.Location = new System.Drawing.Point(324, 636);
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
            this.btn7.Location = new System.Drawing.Point(380, 636);
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
            this.btn8.Location = new System.Drawing.Point(442, 636);
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
            this.btn9.Location = new System.Drawing.Point(504, 636);
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
            this.HintsBtn.Location = new System.Drawing.Point(24, 578);
            this.HintsBtn.Name = "HintsBtn";
            this.HintsBtn.Size = new System.Drawing.Size(141, 40);
            this.HintsBtn.TabIndex = 26;
            this.HintsBtn.Text = "Hints!";
            this.HintsBtn.UseVisualStyleBackColor = true;
            this.HintsBtn.Click += new System.EventHandler(this.HintsBtn_Click);
            // 
            // TimerPauseBtn
            // 
            this.TimerPauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TimerPauseBtn.Location = new System.Drawing.Point(613, 227);
            this.TimerPauseBtn.Name = "TimerPauseBtn";
            this.TimerPauseBtn.Size = new System.Drawing.Size(86, 31);
            this.TimerPauseBtn.TabIndex = 28;
            this.TimerPauseBtn.TabStop = false;
            this.TimerPauseBtn.Text = "Pause";
            this.TimerPauseBtn.UseVisualStyleBackColor = true;
            // 
            // TimerResumeBtn
            // 
            this.TimerResumeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TimerResumeBtn.Location = new System.Drawing.Point(730, 227);
            this.TimerResumeBtn.Name = "TimerResumeBtn";
            this.TimerResumeBtn.Size = new System.Drawing.Size(86, 31);
            this.TimerResumeBtn.TabIndex = 29;
            this.TimerResumeBtn.Text = "Resume";
            this.TimerResumeBtn.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(621, 169);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(182, 46);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            // 
            // lblTimerTxt
            // 
            this.lblTimerTxt.AutoSize = true;
            this.lblTimerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTimerTxt.Location = new System.Drawing.Point(671, 140);
            this.lblTimerTxt.Name = "lblTimerTxt";
            this.lblTimerTxt.Size = new System.Drawing.Size(71, 25);
            this.lblTimerTxt.TabIndex = 30;
            this.lblTimerTxt.Text = "Timer";
            // 
            // ChkAllBtn
            // 
            this.ChkAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ChkAllBtn.ForeColor = System.Drawing.Color.Black;
            this.ChkAllBtn.Location = new System.Drawing.Point(726, 19);
            this.ChkAllBtn.Name = "ChkAllBtn";
            this.ChkAllBtn.Size = new System.Drawing.Size(90, 50);
            this.ChkAllBtn.TabIndex = 31;
            this.ChkAllBtn.Text = "Check ALL";
            this.ChkAllBtn.UseVisualStyleBackColor = true;
            this.ChkAllBtn.Click += new System.EventHandler(this.ChkAllBtn_Click);
            // 
            // SudokuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 698);
            this.Controls.Add(this.ChkAllBtn);
            this.Controls.Add(this.lblTimerTxt);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.TimerResumeBtn);
            this.Controls.Add(this.TimerPauseBtn);
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
            this.Controls.Add(this.SolveItButton);
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
            this.Controls.Add(this.ChkCellBtn);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(855, 737);
            this.MinimumSize = new System.Drawing.Size(855, 737);
            this.Name = "SudokuGame";
            this.Text = "SuDoKu GaMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChkCellBtn;
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
        private System.Windows.Forms.Button SolveItButton;
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
        private System.Windows.Forms.Button TimerPauseBtn;
        private System.Windows.Forms.Button TimerResumeBtn;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimerTxt;
        private System.Windows.Forms.Button ChkAllBtn;
    }
}

