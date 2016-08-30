namespace v1
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
            this.connect = new System.Windows.Forms.Button();
            this.ResultField = new System.Windows.Forms.RichTextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Paswbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(775, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // ResultField
            // 
            this.ResultField.Location = new System.Drawing.Point(24, 53);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(745, 595);
            this.ResultField.TabIndex = 1;
            this.ResultField.Text = "";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(24, 15);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 2;
            this.LoginBox.Text = "dgorgulenko";
            // 
            // Paswbox
            // 
            this.Paswbox.Location = new System.Drawing.Point(130, 15);
            this.Paswbox.Name = "Paswbox";
            this.Paswbox.PasswordChar = '*';
            this.Paswbox.Size = new System.Drawing.Size(100, 20);
            this.Paswbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 670);
            this.Controls.Add(this.Paswbox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.RichTextBox ResultField;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox Paswbox;

    }
}

