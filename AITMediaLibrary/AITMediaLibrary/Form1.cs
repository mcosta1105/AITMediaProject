using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
                

        private void Login()
        {
            UserLogic userLogic = new UserLogic();
            try
            {
                List<UserModel> users = userLogic.GetListOfUsersByUserNameAndPassword(usernameTextBox.Text, passwordTextBox.Text);
                //if got some users
                if (users.Count > 0)
                {
                    CurrentUser.UserName = users[0].UserName;
                    CurrentUser.UserLevel = users[0].UserLevel;
                    CurrentUser.UserId = users[0].UserID;



                    //we only care about the first user in the list
                    if (users[0].UserLevel == 3)
                    {
                        //go to admin page/form                    
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));
                        t.Start();
                    }
                    else
                    {
                        //go to student/normal form
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaForm));
                        t.Start();
                    }
                    //kill this form
                    this.Close();
                }
                else
                {
                    //ERROR, no match
                    errorLabel.Text = "Error:  no user matching this username and password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database unsuccessful, please try again!");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        public static void OpenMediaForm()
        {
            Application.Run(new MediaBrowser());
        }

        public static void OpenAdminForm()
        {
            Application.Run(new AdminForm());
        }


        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                Login();
        }
    }
}
