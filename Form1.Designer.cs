namespace rockpaperscissors
{
    partial class RockPaperScissors
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rock = new System.Windows.Forms.RadioButton();
            this.Paper = new System.Windows.Forms.RadioButton();
            this.Scissors = new System.Windows.Forms.RadioButton();
            this.play = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.AutoSize = true;
            this.Rock.Location = new System.Drawing.Point(271, 174);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(51, 19);
            this.Rock.TabIndex = 0;
            this.Rock.TabStop = true;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            // 
            // Paper
            // 
            this.Paper.AutoSize = true;
            this.Paper.Location = new System.Drawing.Point(328, 174);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(55, 19);
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = true;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            // 
            // Scissors
            // 
            this.Scissors.AutoSize = true;
            this.Scissors.Location = new System.Drawing.Point(389, 174);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(66, 19);
            this.Scissors.TabIndex = 2;
            this.Scissors.TabStop = true;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(328, 199);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 3;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(303, 228);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ResultBox.Size = new System.Drawing.Size(100, 23);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.Text = "Result";
            this.ResultBox.Visible = false;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.play);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "RockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Rock;
        private RadioButton Paper;
        private RadioButton Scissors;
        private Button play;
        private TextBox ResultBox;
    }
}