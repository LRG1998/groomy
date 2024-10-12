namespace Groomy
{
    partial class Login
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.txtPassInput = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(45, 49);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(55, 13);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Username: ";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(45, 68);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(55, 13);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Password: ";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(107, 41);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(100, 20);
            this.txtUserInput.TabIndex = 2;
            // 
            // txtPassInput
            // 
            this.txtPassInput.Location = new System.Drawing.Point(107, 68);
            this.txtPassInput.Name = "txtPassInput";
            this.txtPassInput.PasswordChar = '*';
            this.txtPassInput.Size = new System.Drawing.Size(100, 20);
            this.txtPassInput.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(45, 123);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "&Login";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 123);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 158);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassInput);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.TextBox txtPassInput;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
    }
}

