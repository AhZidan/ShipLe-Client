using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace ShipLe_Client
{
    public partial class ShipLeLogin : Form
    {
        public ShipLeLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameText.Text.Trim() == string.Empty)
            {
                ShowError("Enter a valid username!");
                UsernameText.Focus();
                return;
            }

            if (PasswordText.Text.Trim() == string.Empty)
            {
                ShowError("Enter a Password!");
                PasswordText.Focus();
                return;
            }

            HideError();

            HttpClient HttpRequest = new HttpClient();
            User LoginUser = new User { Username = UsernameText.Text.Trim(), Password = PasswordText.Text.Trim() };

            var Content = new JavaScriptSerializer().Serialize(LoginUser);
            var Response = HttpRequest.PostAsync("http://localhost:50479/User", 
                new StringContent(new JavaScriptSerializer().Serialize(LoginUser), Encoding.UTF8, "application/json")).Result;

        }

        private void ShipLeLogin_Load(object sender, EventArgs e)
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

        User myUser = new User();
        private void CloseError_Click(object sender, EventArgs e)
        {
            HideError();
        }

        private void NewUserLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser Frm = new NewUser();

            Frm.ShowDialog();
        }
    }
}
class User
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string EMail { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


}