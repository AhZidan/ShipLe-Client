using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipLe_Client
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void ShowError(string ErrorMessage)
        {
            ErrorLabel.Text = ErrorMessage.Trim();

            CloseError.Visible = true;
            ErrorLabel.Visible = true;
        }

        private void HideError()
        {
            ErrorLabel.Visible = false;
            CloseError.Visible = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (UsernameText.Text.Trim() == string.Empty)
            {
                ShowError("Please enter a username!");
                UsernameText.Focus();

                return;
            }

            if (PasswordText.Text.Trim() == string.Empty)
            {
                ShowError("Please enter a password!");
                PasswordText.Focus();

                return;
            }

            HideError();
        }

        private void UsernameText_Validating(object sender, CancelEventArgs e)
        {

        }

        private void PasswordText_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}
