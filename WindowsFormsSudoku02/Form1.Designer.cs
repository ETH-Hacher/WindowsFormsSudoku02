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
            this.label1 = new System.Windows.Forms.Label();
            this.LoadZeitSudoku = new System.Windows.Forms.Button();
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
            this.ChkButton.Size = new System.Drawing.Size(207, 95);
            this.ChkButton.TabIndex = 1;
            this.ChkButton.Text = "Check Input";
            this.ChkButton.UseVisualStyleBackColor = true;
            this.ChkButton.Click += new System.EventHandler(this.ChkButton_Click);
            // 
            // ClrButton
            // 
            this.ClrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ClrButton.ForeColor = System.Drawing.Color.Black;
            this.ClrButton.Location = new System.Drawing.Point(655, 147);
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
            this.NewGameButton.ForeColor = System.Drawing.Color.Black;
            this.NewGameButton.Location = new System.Drawing.Point(655, 533);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(207, 86);
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
            this.beginnerLevel.Location = new System.Drawing.Point(655, 423);
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
            this.IntermediateLevel.Location = new System.Drawing.Point(655, 446);
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
            this.AdvancedLevel.Location = new System.Drawing.Point(655, 469);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(108, 24);
            this.AdvancedLevel.TabIndex = 6;
            this.AdvancedLevel.TabStop = true;
            this.AdvancedLevel.Text = "Advanced";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(649, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Difficulty";
            // 
            // LoadZeitSudoku
            // 
            this.LoadZeitSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LoadZeitSudoku.ForeColor = System.Drawing.Color.Black;
            this.LoadZeitSudoku.Location = new System.Drawing.Point(655, 303);
            this.LoadZeitSudoku.Name = "LoadZeitSudoku";
            this.LoadZeitSudoku.Size = new System.Drawing.Size(207, 58);
            this.LoadZeitSudoku.TabIndex = 9;
            this.LoadZeitSudoku.Text = "Zeit Sudoku";
            this.LoadZeitSudoku.UseVisualStyleBackColor = true;
            this.LoadZeitSudoku.Click += new System.EventHandler(this.LoadZeitSudoku_Click);
            // 
            // SudokuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 633);
            this.Controls.Add(this.LoadZeitSudoku);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadZeitSudoku;
    }
}

