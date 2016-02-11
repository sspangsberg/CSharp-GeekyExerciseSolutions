namespace DiceThrowGUI.GUI
{
    partial class DiceThrowForm
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
            this.btnThrowDice = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThrowDice
            // 
            this.btnThrowDice.Location = new System.Drawing.Point(26, 29);
            this.btnThrowDice.Name = "btnThrowDice";
            this.btnThrowDice.Size = new System.Drawing.Size(208, 120);
            this.btnThrowDice.TabIndex = 0;
            this.btnThrowDice.Text = "Throw Dice";
            this.btnThrowDice.UseVisualStyleBackColor = true;
            this.btnThrowDice.Click += new System.EventHandler(this.btnThrowDice_Click);
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(292, 29);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(137, 120);
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // DiceThrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 182);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.btnThrowDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DiceThrowForm";
            this.Text = "DiceThrowForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThrowDice;
        private System.Windows.Forms.PictureBox pbResult;
    }
}

