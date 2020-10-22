namespace BruteForcePasswordFinder
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.TerminalTextbox = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brute Force Password Finder";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(116, 74);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(543, 23);
            this.PasswordTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(258, 344);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(231, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Begin Decoding";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TerminalTextbox
            // 
            this.TerminalTextbox.Location = new System.Drawing.Point(116, 147);
            this.TerminalTextbox.Multiline = true;
            this.TerminalTextbox.Name = "TerminalTextbox";
            this.TerminalTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TerminalTextbox.Size = new System.Drawing.Size(543, 134);
            this.TerminalTextbox.TabIndex = 4;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(116, 288);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(543, 23);
            this.ResultTextbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.TerminalTextbox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox TerminalTextbox;
        private System.Windows.Forms.TextBox ResultTextbox;
    }
}

