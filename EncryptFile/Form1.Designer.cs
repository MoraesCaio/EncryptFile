namespace EncryptFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encInputTBox = new System.Windows.Forms.TextBox();
            this.encOFD = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.encInBrowse = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.encButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.encOutBrowse = new System.Windows.Forms.Button();
            this.encOutputTBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.decOutBrowse = new System.Windows.Forms.Button();
            this.decOutputTBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.decInBrowse = new System.Windows.Forms.Button();
            this.decInputTBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.encSFD = new System.Windows.Forms.SaveFileDialog();
            this.decOFD = new System.Windows.Forms.OpenFileDialog();
            this.decFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // encInputTBox
            // 
            this.encInputTBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encInputTBox.Location = new System.Drawing.Point(35, 18);
            this.encInputTBox.Name = "encInputTBox";
            this.encInputTBox.Size = new System.Drawing.Size(181, 20);
            this.encInputTBox.TabIndex = 3;
            // 
            // encOFD
            // 
            this.encOFD.FileOk += new System.ComponentModel.CancelEventHandler(this.encOFD_FileOk);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.encInBrowse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.encInputTBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // encInBrowse
            // 
            this.encInBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encInBrowse.AutoSize = true;
            this.encInBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.encInBrowse.Location = new System.Drawing.Point(3, 16);
            this.encInBrowse.Name = "encInBrowse";
            this.encInBrowse.Size = new System.Drawing.Size(26, 23);
            this.encInBrowse.TabIndex = 2;
            this.encInBrowse.Text = "...";
            this.encInBrowse.UseVisualStyleBackColor = true;
            this.encInBrowse.Click += new System.EventHandler(this.encInBrowse_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.passwordTBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(439, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password (8 characters)";
            // 
            // passwordTBox
            // 
            this.passwordTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.passwordTBox, 3);
            this.passwordTBox.Location = new System.Drawing.Point(3, 17);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.PasswordChar = '*';
            this.passwordTBox.Size = new System.Drawing.Size(433, 20);
            this.passwordTBox.TabIndex = 1;
            // 
            // encButton
            // 
            this.encButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.encButton.Location = new System.Drawing.Point(72, 3);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(75, 23);
            this.encButton.TabIndex = 6;
            this.encButton.Text = "Encrypt!";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // decButton
            // 
            this.decButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decButton.AutoSize = true;
            this.decButton.Location = new System.Drawing.Point(300, 3);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(57, 23);
            this.decButton.TabIndex = 11;
            this.decButton.Text = "Decrypt!";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(445, 182);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.encOutBrowse, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.encOutputTBox, 1, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 101);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(216, 43);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Output File";
            this.label5.Visible = false;
            // 
            // encOutBrowse
            // 
            this.encOutBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encOutBrowse.AutoSize = true;
            this.encOutBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.encOutBrowse.Location = new System.Drawing.Point(3, 16);
            this.encOutBrowse.Name = "encOutBrowse";
            this.encOutBrowse.Size = new System.Drawing.Size(26, 23);
            this.encOutBrowse.TabIndex = 4;
            this.encOutBrowse.Text = "...";
            this.encOutBrowse.UseVisualStyleBackColor = true;
            this.encOutBrowse.Visible = false;
            this.encOutBrowse.Click += new System.EventHandler(this.encOutBrowse_Click);
            // 
            // encOutputTBox
            // 
            this.encOutputTBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encOutputTBox.Location = new System.Drawing.Point(35, 18);
            this.encOutputTBox.Name = "encOutputTBox";
            this.encOutputTBox.Size = new System.Drawing.Size(181, 20);
            this.encOutputTBox.TabIndex = 5;
            this.encOutputTBox.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.decOutBrowse, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.decOutputTBox, 1, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(225, 101);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(216, 43);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Output File";
            this.label4.Visible = false;
            // 
            // decOutBrowse
            // 
            this.decOutBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decOutBrowse.AutoSize = true;
            this.decOutBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decOutBrowse.Location = new System.Drawing.Point(3, 16);
            this.decOutBrowse.Name = "decOutBrowse";
            this.decOutBrowse.Size = new System.Drawing.Size(26, 23);
            this.decOutBrowse.TabIndex = 9;
            this.decOutBrowse.Text = "...";
            this.decOutBrowse.UseVisualStyleBackColor = true;
            this.decOutBrowse.Visible = false;
            // 
            // decOutputTBox
            // 
            this.decOutputTBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.decOutputTBox.Location = new System.Drawing.Point(35, 18);
            this.decOutputTBox.Name = "decOutputTBox";
            this.decOutputTBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decOutputTBox.Size = new System.Drawing.Size(181, 20);
            this.decOutputTBox.TabIndex = 10;
            this.decOutputTBox.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.decInBrowse, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.decInputTBox, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(225, 51);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(216, 43);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input File";
            // 
            // decInBrowse
            // 
            this.decInBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decInBrowse.AutoSize = true;
            this.decInBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decInBrowse.Location = new System.Drawing.Point(3, 16);
            this.decInBrowse.Name = "decInBrowse";
            this.decInBrowse.Size = new System.Drawing.Size(26, 23);
            this.decInBrowse.TabIndex = 7;
            this.decInBrowse.Text = "...";
            this.decInBrowse.UseVisualStyleBackColor = true;
            this.decInBrowse.Click += new System.EventHandler(this.decInBrowse_Click);
            // 
            // decInputTBox
            // 
            this.decInputTBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.decInputTBox.Location = new System.Drawing.Point(35, 18);
            this.decInputTBox.Name = "decInputTBox";
            this.decInputTBox.Size = new System.Drawing.Size(181, 20);
            this.decInputTBox.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.encButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.decButton, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 150);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(439, 29);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // encSFD
            // 
            this.encSFD.Filter = "All Files (*.*)|*.*";
            // 
            // decOFD
            // 
            this.decOFD.FileOk += new System.ComponentModel.CancelEventHandler(this.decOFD_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 335);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt File";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox encInputTBox;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.TextBox decInputTBox;
        private System.Windows.Forms.TextBox decOutputTBox;
        private System.Windows.Forms.TextBox encOutputTBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encInBrowse;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.OpenFileDialog encOFD;
        private System.Windows.Forms.OpenFileDialog decOFD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog encSFD;
        private System.Windows.Forms.Button decInBrowse;
        private System.Windows.Forms.Button decOutBrowse;
        private System.Windows.Forms.Button encOutBrowse;
        private System.Windows.Forms.FolderBrowserDialog decFBD;
    }
}

