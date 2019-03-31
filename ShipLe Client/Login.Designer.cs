namespace ShipLe_Client
{
    partial class ShipLeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipLeLogin));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.NewUserLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserImageBox = new System.Windows.Forms.PictureBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CloseError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseError)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(22, 225);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(74, 17);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(103, 221);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(221, 24);
            this.UsernameText.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(25, 255);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 17);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(103, 251);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(221, 24);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(103, 283);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(111, 17);
            this.ForgotPasswordLabel.TabIndex = 4;
            this.ForgotPasswordLabel.TabStop = true;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            // 
            // NewUserLabel
            // 
            this.NewUserLabel.AutoSize = true;
            this.NewUserLabel.Location = new System.Drawing.Point(124, 472);
            this.NewUserLabel.Name = "NewUserLabel";
            this.NewUserLabel.Size = new System.Drawing.Size(109, 17);
            this.NewUserLabel.TabIndex = 6;
            this.NewUserLabel.TabStop = true;
            this.NewUserLabel.Text = "Create New User";
            this.NewUserLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUserLabel_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(91, 411);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(174, 40);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserImageBox
            // 
            this.UserImageBox.Image = ((System.Drawing.Image)(resources.GetObject("UserImageBox.Image")));
            this.UserImageBox.Location = new System.Drawing.Point(127, 52);
            this.UserImageBox.Name = "UserImageBox";
            this.UserImageBox.Size = new System.Drawing.Size(128, 128);
            this.UserImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserImageBox.TabIndex = 5;
            this.UserImageBox.TabStop = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.LightYellow;
            this.ErrorLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLabel.Image = ((System.Drawing.Image)(resources.GetObject("ErrorLabel.Image")));
            this.ErrorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 324);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(331, 45);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Invalid Username";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // CloseError
            // 
            this.CloseError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseError.Image = ((System.Drawing.Image)(resources.GetObject("CloseError.Image")));
            this.CloseError.Location = new System.Drawing.Point(319, 324);
            this.CloseError.Name = "CloseError";
            this.CloseError.Size = new System.Drawing.Size(24, 24);
            this.CloseError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseError.TabIndex = 7;
            this.CloseError.TabStop = false;
            this.CloseError.Visible = false;
            this.CloseError.Click += new System.EventHandler(this.CloseError_Click);
            // 
            // ShipLeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 557);
            this.Controls.Add(this.CloseError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.UserImageBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NewUserLabel);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShipLeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShipLe Client";
            this.Load += new System.EventHandler(this.ShipLeLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.LinkLabel ForgotPasswordLabel;
        private System.Windows.Forms.LinkLabel NewUserLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox UserImageBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.PictureBox CloseError;
    }
}

