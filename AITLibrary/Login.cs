using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
          String sUserName = usernameTxtBx.Text;
            String sPassword = passwordTxtBx.Text;

            UserLogic userLogic = new UserLogic();
            bool bLoginStatus = userLogic.ValidateUser(sUserName, sPassword);
            if (bLoginStatus == true)
            {
                MessageBox.Show("login Successfull");

            }
            else
            {
                MessageBox.Show("unsuccessful login");
            }
            {
                
            }



        }
        }
    }

