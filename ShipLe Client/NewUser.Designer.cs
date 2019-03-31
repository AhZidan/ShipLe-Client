namespace ShipLe_Client
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordConfirmText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.UserImageBox = new System.Windows.Forms.PictureBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CloseError = new System.Windows.Forms.PictureBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(171, 12);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(185, 24);
            this.UsernameText.TabIndex = 1;
            this.UsernameText.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameText_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(171, 114);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(185, 24);
            this.PasswordText.TabIndex = 7;
            this.PasswordText.UseSystemPasswordChar = true;
            this.PasswordText.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordText_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password Confirmation:";
            // 
            // PasswordConfirmText
            // 
            this.PasswordConfirmText.Location = new System.Drawing.Point(171, 144);
            this.PasswordConfirmText.Name = "PasswordConfirmText";
            this.PasswordConfirmText.Size = new System.Drawing.Size(185, 24);
            this.PasswordConfirmText.TabIndex = 9;
            this.PasswordConfirmText.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(171, 174);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(185, 24);
            this.EmailText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "First Name:";
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(171, 42);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(185, 24);
            this.FirstNameText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last Name:";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(171, 72);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(185, 24);
            this.LastNameText.TabIndex = 5;
            // 
            // UserImageBox
            // 
            this.UserImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserImageBox.Location = new System.Drawing.Point(397, 16);
            this.UserImageBox.Name = "UserImageBox";
            this.UserImageBox.Size = new System.Drawing.Size(150, 149);
            this.UserImageBox.TabIndex = 2;
            this.UserImageBox.TabStop = false;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(446, 212);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(101, 44);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CloseError
            // 
            this.CloseError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseError.Image = ((System.Drawing.Image)(resources.GetObject("CloseError.Image")));
            this.CloseError.Location = new System.Drawing.Point(332, 211);
            this.CloseError.Name = "CloseError";
            this.CloseError.Size = new System.Drawing.Size(24, 24);
            this.CloseError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseError.TabIndex = 14;
            this.CloseError.TabStop = false;
            this.CloseError.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.LightYellow;
            this.ErrorLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLabel.Image = ((System.Drawing.Image)(resources.GetObject("ErrorLabel.Image")));
            this.ErrorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorLabel.Location = new System.Drawing.Point(25, 211);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(331, 45);
            this.ErrorLabel.TabIndex = 13;
            this.ErrorLabel.Text = "Invalid Username";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // NewUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(566, 268);
            this.Controls.Add(this.CloseError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.UserImageBox);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordConfirmText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordConfirmText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.PictureBox UserImageBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.PictureBox CloseError;
        private System.Windows.Forms.Label ErrorLabel;
    }
}