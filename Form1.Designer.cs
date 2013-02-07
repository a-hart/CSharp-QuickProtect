namespace PasswordHashTest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.string2Encrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EntropyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // string2Encrypt
            // 
            this.string2Encrypt.Location = new System.Drawing.Point(48, 72);
            this.string2Encrypt.Name = "string2Encrypt";
            this.string2Encrypt.Size = new System.Drawing.Size(184, 20);
            this.string2Encrypt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String to Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text:";
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(48, 118);
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(184, 20);
            this.EncryptTextBox.TabIndex = 5;
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(48, 158);
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.Size = new System.Drawing.Size(184, 20);
            this.DecryptTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrypted Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add Entropy: (Type in random letters and/or numbers)";
            // 
            // EntropyText
            // 
            this.EntropyText.Location = new System.Drawing.Point(48, 30);
            this.EntropyText.Name = "EntropyText";
            this.EntropyText.Size = new System.Drawing.Size(184, 20);
            this.EntropyText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 230);
            this.Controls.Add(this.EntropyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecryptTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncryptTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.string2Encrypt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox string2Encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EntropyText;
    }
}

