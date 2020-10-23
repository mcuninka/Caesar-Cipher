namespace Caesar_Cipher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.programToEncryptAndDecryptYourTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNormalText1 = new System.Windows.Forms.Label();
            this.labelCipherText1 = new System.Windows.Forms.Label();
            this.labelCipherText2 = new System.Windows.Forms.Label();
            this.labelNormalText2 = new System.Windows.Forms.Label();
            this.labelShift1 = new System.Windows.Forms.Label();
            this.labelShift2 = new System.Windows.Forms.Label();
            this.textBoxNormalText1 = new System.Windows.Forms.TextBox();
            this.textBoxshift1 = new System.Windows.Forms.TextBox();
            this.textBoxCipherText1 = new System.Windows.Forms.TextBox();
            this.textBoxNormalText2 = new System.Windows.Forms.TextBox();
            this.textBoxshift2 = new System.Windows.Forms.TextBox();
            this.textBoxCipherText2 = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAbout
            // 
            this.menuAbout.BackColor = System.Drawing.Color.Black;
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToEncryptAndDecryptYourTextToolStripMenuItem});
            this.menuAbout.ForeColor = System.Drawing.Color.Lime;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(52, 20);
            this.menuAbout.Text = "About";
            // 
            // programToEncryptAndDecryptYourTextToolStripMenuItem
            // 
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.Name = "programToEncryptAndDecryptYourTextToolStripMenuItem";
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.programToEncryptAndDecryptYourTextToolStripMenuItem.Text = "Program to encrypt and decrypt your text.";
            // 
            // labelNormalText1
            // 
            this.labelNormalText1.AutoSize = true;
            this.labelNormalText1.ForeColor = System.Drawing.Color.Lime;
            this.labelNormalText1.Location = new System.Drawing.Point(12, 43);
            this.labelNormalText1.Name = "labelNormalText1";
            this.labelNormalText1.Size = new System.Drawing.Size(64, 13);
            this.labelNormalText1.TabIndex = 1;
            this.labelNormalText1.Text = "Normal Text";
            // 
            // labelCipherText1
            // 
            this.labelCipherText1.AutoSize = true;
            this.labelCipherText1.ForeColor = System.Drawing.Color.Lime;
            this.labelCipherText1.Location = new System.Drawing.Point(273, 43);
            this.labelCipherText1.Name = "labelCipherText1";
            this.labelCipherText1.Size = new System.Drawing.Size(61, 13);
            this.labelCipherText1.TabIndex = 2;
            this.labelCipherText1.Text = "Cipher Text";
            // 
            // labelCipherText2
            // 
            this.labelCipherText2.AutoSize = true;
            this.labelCipherText2.ForeColor = System.Drawing.Color.Lime;
            this.labelCipherText2.Location = new System.Drawing.Point(12, 157);
            this.labelCipherText2.Name = "labelCipherText2";
            this.labelCipherText2.Size = new System.Drawing.Size(61, 13);
            this.labelCipherText2.TabIndex = 3;
            this.labelCipherText2.Text = "Cipher Text";
            // 
            // labelNormalText2
            // 
            this.labelNormalText2.AutoSize = true;
            this.labelNormalText2.ForeColor = System.Drawing.Color.Lime;
            this.labelNormalText2.Location = new System.Drawing.Point(273, 157);
            this.labelNormalText2.Name = "labelNormalText2";
            this.labelNormalText2.Size = new System.Drawing.Size(64, 13);
            this.labelNormalText2.TabIndex = 4;
            this.labelNormalText2.Text = "Normal Text";
            // 
            // labelShift1
            // 
            this.labelShift1.AutoSize = true;
            this.labelShift1.ForeColor = System.Drawing.Color.Lime;
            this.labelShift1.Location = new System.Drawing.Point(220, 43);
            this.labelShift1.Name = "labelShift1";
            this.labelShift1.Size = new System.Drawing.Size(28, 13);
            this.labelShift1.TabIndex = 5;
            this.labelShift1.Text = "Shift";
            // 
            // labelShift2
            // 
            this.labelShift2.AutoSize = true;
            this.labelShift2.ForeColor = System.Drawing.Color.Lime;
            this.labelShift2.Location = new System.Drawing.Point(220, 157);
            this.labelShift2.Name = "labelShift2";
            this.labelShift2.Size = new System.Drawing.Size(28, 13);
            this.labelShift2.TabIndex = 6;
            this.labelShift2.Text = "Shift";
            // 
            // textBoxNormalText1
            // 
            this.textBoxNormalText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxNormalText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNormalText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNormalText1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxNormalText1.Location = new System.Drawing.Point(15, 59);
            this.textBoxNormalText1.Multiline = true;
            this.textBoxNormalText1.Name = "textBoxNormalText1";
            this.textBoxNormalText1.Size = new System.Drawing.Size(182, 87);
            this.textBoxNormalText1.TabIndex = 7;
            // 
            // textBoxshift1
            // 
            this.textBoxshift1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxshift1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxshift1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxshift1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxshift1.Location = new System.Drawing.Point(203, 59);
            this.textBoxshift1.Multiline = true;
            this.textBoxshift1.Name = "textBoxshift1";
            this.textBoxshift1.Size = new System.Drawing.Size(67, 25);
            this.textBoxshift1.TabIndex = 8;
            // 
            // textBoxCipherText1
            // 
            this.textBoxCipherText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxCipherText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCipherText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCipherText1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxCipherText1.Location = new System.Drawing.Point(276, 59);
            this.textBoxCipherText1.Multiline = true;
            this.textBoxCipherText1.Name = "textBoxCipherText1";
            this.textBoxCipherText1.Size = new System.Drawing.Size(182, 87);
            this.textBoxCipherText1.TabIndex = 9;
            // 
            // textBoxNormalText2
            // 
            this.textBoxNormalText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxNormalText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNormalText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNormalText2.ForeColor = System.Drawing.Color.Lime;
            this.textBoxNormalText2.Location = new System.Drawing.Point(276, 173);
            this.textBoxNormalText2.Multiline = true;
            this.textBoxNormalText2.Name = "textBoxNormalText2";
            this.textBoxNormalText2.Size = new System.Drawing.Size(182, 87);
            this.textBoxNormalText2.TabIndex = 14;
            this.textBoxNormalText2.WordWrap = false;
            // 
            // textBoxshift2
            // 
            this.textBoxshift2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxshift2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxshift2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxshift2.ForeColor = System.Drawing.Color.Lime;
            this.textBoxshift2.Location = new System.Drawing.Point(203, 173);
            this.textBoxshift2.Multiline = true;
            this.textBoxshift2.Name = "textBoxshift2";
            this.textBoxshift2.Size = new System.Drawing.Size(67, 25);
            this.textBoxshift2.TabIndex = 13;
            // 
            // textBoxCipherText2
            // 
            this.textBoxCipherText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxCipherText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCipherText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCipherText2.ForeColor = System.Drawing.Color.Lime;
            this.textBoxCipherText2.Location = new System.Drawing.Point(12, 173);
            this.textBoxCipherText2.Multiline = true;
            this.textBoxCipherText2.Name = "textBoxCipherText2";
            this.textBoxCipherText2.Size = new System.Drawing.Size(182, 87);
            this.textBoxCipherText2.TabIndex = 12;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.ForeColor = System.Drawing.Color.Lime;
            this.buttonEncrypt.Location = new System.Drawing.Point(203, 90);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(67, 25);
            this.buttonEncrypt.TabIndex = 10;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.ForeColor = System.Drawing.Color.Lime;
            this.buttonDecrypt.Location = new System.Drawing.Point(203, 204);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(67, 25);
            this.buttonDecrypt.TabIndex = 15;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonClear1
            // 
            this.buttonClear1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonClear1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear1.ForeColor = System.Drawing.Color.Lime;
            this.buttonClear1.Location = new System.Drawing.Point(203, 121);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(67, 25);
            this.buttonClear1.TabIndex = 11;
            this.buttonClear1.Text = "Clear";
            this.buttonClear1.UseVisualStyleBackColor = false;
            this.buttonClear1.Click += new System.EventHandler(this.buttonClear1_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonClear2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear2.ForeColor = System.Drawing.Color.Lime;
            this.buttonClear2.Location = new System.Drawing.Point(203, 235);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(67, 25);
            this.buttonClear2.TabIndex = 16;
            this.buttonClear2.Text = "Clear";
            this.buttonClear2.UseVisualStyleBackColor = false;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(468, 283);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.buttonClear1);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxCipherText2);
            this.Controls.Add(this.textBoxNormalText2);
            this.Controls.Add(this.textBoxshift2);
            this.Controls.Add(this.textBoxshift1);
            this.Controls.Add(this.textBoxCipherText1);
            this.Controls.Add(this.textBoxNormalText1);
            this.Controls.Add(this.labelShift2);
            this.Controls.Add(this.labelShift1);
            this.Controls.Add(this.labelNormalText2);
            this.Controls.Add(this.labelCipherText2);
            this.Controls.Add(this.labelCipherText1);
            this.Controls.Add(this.labelNormalText1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Marenova sifrovacia aplikacia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Label labelNormalText1;
        private System.Windows.Forms.Label labelCipherText1;
        private System.Windows.Forms.Label labelCipherText2;
        private System.Windows.Forms.Label labelNormalText2;
        private System.Windows.Forms.Label labelShift1;
        private System.Windows.Forms.Label labelShift2;
        private System.Windows.Forms.TextBox textBoxNormalText1;
        private System.Windows.Forms.TextBox textBoxCipherText1;
        private System.Windows.Forms.TextBox textBoxshift1;
        private System.Windows.Forms.TextBox textBoxshift2;
        private System.Windows.Forms.TextBox textBoxNormalText2;
        private System.Windows.Forms.TextBox textBoxCipherText2;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.ToolStripMenuItem programToEncryptAndDecryptYourTextToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear1;
        private System.Windows.Forms.Button buttonClear2;
    }
}

