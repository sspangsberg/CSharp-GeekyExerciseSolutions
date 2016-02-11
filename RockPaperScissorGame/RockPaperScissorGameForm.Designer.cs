namespace RockPaperScissorGame
{
    partial class RockPaperScissorGameForm
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.rbScissor = new System.Windows.Forms.RadioButton();
            this.rbPaper = new System.Windows.Forms.RadioButton();
            this.gbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.gbComputerChoice = new System.Windows.Forms.GroupBox();
            this.rbCompRock = new System.Windows.Forms.RadioButton();
            this.rbCompPaper = new System.Windows.Forms.RadioButton();
            this.rbCompScissor = new System.Windows.Forms.RadioButton();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.lblRockWins = new System.Windows.Forms.Label();
            this.lblPaperWins = new System.Windows.Forms.Label();
            this.lblScissorWins = new System.Windows.Forms.Label();
            this.lblCPUWins = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.gbPlayerChoice.SuspendLayout();
            this.gbComputerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(5, 283);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(175, 67);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Spil";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbRock
            // 
            this.rbRock.AutoSize = true;
            this.rbRock.Location = new System.Drawing.Point(24, 26);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(47, 17);
            this.rbRock.TabIndex = 4;
            this.rbRock.TabStop = true;
            this.rbRock.Text = "Sten";
            this.rbRock.UseVisualStyleBackColor = true;
            // 
            // rbScissor
            // 
            this.rbScissor.AutoSize = true;
            this.rbScissor.Location = new System.Drawing.Point(24, 49);
            this.rbScissor.Name = "rbScissor";
            this.rbScissor.Size = new System.Drawing.Size(49, 17);
            this.rbScissor.TabIndex = 5;
            this.rbScissor.TabStop = true;
            this.rbScissor.Text = "Saks";
            this.rbScissor.UseVisualStyleBackColor = true;
            // 
            // rbPaper
            // 
            this.rbPaper.AutoSize = true;
            this.rbPaper.Location = new System.Drawing.Point(24, 72);
            this.rbPaper.Name = "rbPaper";
            this.rbPaper.Size = new System.Drawing.Size(49, 17);
            this.rbPaper.TabIndex = 6;
            this.rbPaper.TabStop = true;
            this.rbPaper.Text = "Papir";
            this.rbPaper.UseVisualStyleBackColor = true;
            // 
            // gbPlayerChoice
            // 
            this.gbPlayerChoice.Controls.Add(this.rbRock);
            this.gbPlayerChoice.Controls.Add(this.rbPaper);
            this.gbPlayerChoice.Controls.Add(this.rbScissor);
            this.gbPlayerChoice.Location = new System.Drawing.Point(5, 2);
            this.gbPlayerChoice.Name = "gbPlayerChoice";
            this.gbPlayerChoice.Size = new System.Drawing.Size(85, 106);
            this.gbPlayerChoice.TabIndex = 7;
            this.gbPlayerChoice.TabStop = false;
            this.gbPlayerChoice.Text = "Dig";
            // 
            // gbComputerChoice
            // 
            this.gbComputerChoice.Controls.Add(this.rbCompRock);
            this.gbComputerChoice.Controls.Add(this.rbCompPaper);
            this.gbComputerChoice.Controls.Add(this.rbCompScissor);
            this.gbComputerChoice.Location = new System.Drawing.Point(94, 2);
            this.gbComputerChoice.Name = "gbComputerChoice";
            this.gbComputerChoice.Size = new System.Drawing.Size(86, 106);
            this.gbComputerChoice.TabIndex = 8;
            this.gbComputerChoice.TabStop = false;
            this.gbComputerChoice.Text = "Computer";
            // 
            // rbCompRock
            // 
            this.rbCompRock.AutoSize = true;
            this.rbCompRock.Enabled = false;
            this.rbCompRock.Location = new System.Drawing.Point(21, 26);
            this.rbCompRock.Name = "rbCompRock";
            this.rbCompRock.Size = new System.Drawing.Size(47, 17);
            this.rbCompRock.TabIndex = 4;
            this.rbCompRock.TabStop = true;
            this.rbCompRock.Text = "Sten";
            this.rbCompRock.UseVisualStyleBackColor = true;
            // 
            // rbCompPaper
            // 
            this.rbCompPaper.AutoSize = true;
            this.rbCompPaper.Enabled = false;
            this.rbCompPaper.Location = new System.Drawing.Point(21, 72);
            this.rbCompPaper.Name = "rbCompPaper";
            this.rbCompPaper.Size = new System.Drawing.Size(49, 17);
            this.rbCompPaper.TabIndex = 6;
            this.rbCompPaper.TabStop = true;
            this.rbCompPaper.Text = "Papir";
            this.rbCompPaper.UseVisualStyleBackColor = true;
            // 
            // rbCompScissor
            // 
            this.rbCompScissor.AutoSize = true;
            this.rbCompScissor.Enabled = false;
            this.rbCompScissor.Location = new System.Drawing.Point(21, 49);
            this.rbCompScissor.Name = "rbCompScissor";
            this.rbCompScissor.Size = new System.Drawing.Size(49, 17);
            this.rbCompScissor.TabIndex = 5;
            this.rbCompScissor.TabStop = true;
            this.rbCompScissor.Text = "Saks";
            this.rbCompScissor.UseVisualStyleBackColor = true;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(5, 114);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(175, 163);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 9;
            this.pbResult.TabStop = false;
            // 
            // lblRockWins
            // 
            this.lblRockWins.AutoSize = true;
            this.lblRockWins.Location = new System.Drawing.Point(212, 28);
            this.lblRockWins.Name = "lblRockWins";
            this.lblRockWins.Size = new System.Drawing.Size(32, 13);
            this.lblRockWins.TabIndex = 10;
            this.lblRockWins.Text = "Sten:";
            // 
            // lblPaperWins
            // 
            this.lblPaperWins.AutoSize = true;
            this.lblPaperWins.Location = new System.Drawing.Point(212, 51);
            this.lblPaperWins.Name = "lblPaperWins";
            this.lblPaperWins.Size = new System.Drawing.Size(34, 13);
            this.lblPaperWins.TabIndex = 11;
            this.lblPaperWins.Text = "Papir:";
            // 
            // lblScissorWins
            // 
            this.lblScissorWins.AutoSize = true;
            this.lblScissorWins.Location = new System.Drawing.Point(212, 76);
            this.lblScissorWins.Name = "lblScissorWins";
            this.lblScissorWins.Size = new System.Drawing.Size(34, 13);
            this.lblScissorWins.TabIndex = 12;
            this.lblScissorWins.Text = "Saks:";
            // 
            // lblCPUWins
            // 
            this.lblCPUWins.AutoSize = true;
            this.lblCPUWins.Location = new System.Drawing.Point(211, 114);
            this.lblCPUWins.Name = "lblCPUWins";
            this.lblCPUWins.Size = new System.Drawing.Size(80, 13);
            this.lblCPUWins.TabIndex = 13;
            this.lblCPUWins.Text = "Computer sejre:";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Location = new System.Drawing.Point(211, 138);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(57, 13);
            this.lblPlayerWins.TabIndex = 14;
            this.lblPlayerWins.Text = "Dine sejre:";
            // 
            // RockPaperScissorGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 374);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblCPUWins);
            this.Controls.Add(this.lblScissorWins);
            this.Controls.Add(this.lblPaperWins);
            this.Controls.Add(this.lblRockWins);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.gbComputerChoice);
            this.Controls.Add(this.gbPlayerChoice);
            this.Controls.Add(this.btnPlay);
            this.Name = "RockPaperScissorGameForm";
            this.Text = "Form1";
            this.gbPlayerChoice.ResumeLayout(false);
            this.gbPlayerChoice.PerformLayout();
            this.gbComputerChoice.ResumeLayout(false);
            this.gbComputerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbRock;
        private System.Windows.Forms.RadioButton rbScissor;
        private System.Windows.Forms.RadioButton rbPaper;
        private System.Windows.Forms.GroupBox gbPlayerChoice;
        private System.Windows.Forms.GroupBox gbComputerChoice;
        private System.Windows.Forms.RadioButton rbCompRock;
        private System.Windows.Forms.RadioButton rbCompPaper;
        private System.Windows.Forms.RadioButton rbCompScissor;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label lblRockWins;
        private System.Windows.Forms.Label lblPaperWins;
        private System.Windows.Forms.Label lblScissorWins;
        private System.Windows.Forms.Label lblCPUWins;
        private System.Windows.Forms.Label lblPlayerWins;
    }
}

