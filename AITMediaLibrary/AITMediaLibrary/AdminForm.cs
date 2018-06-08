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
    public partial class AdminForm : Form
    {
        private UserLogic userLogic = new UserLogic();
        private MediaLogic mediaLogic = new MediaLogic();
        private UserModel selectedUser = null;
        

        public AdminForm()
        {
            InitializeComponent();
        }

        //Display data
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Auto resize columns
            userGridView.AutoResizeColumns();
            userGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;  
            //User grid view
            RefreshUserList();
            userLevelComboBox.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));

        }

        private void RefreshUserList()
        {
            userGridView.DataSource = userLogic.GetListOfUsers();
        }

        //User data grid view
        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0) // -1 the header row, dont care about it
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of user models
                List<UserModel> users = (List<UserModel>)userGridView.DataSource;
                UserModel user = users[row];
                selectedUser = users.ElementAt<UserModel>(row);//get from this position
                selectedUserLabel.Text = "Selected User: " + user.UserName;
            }
        }
                
        //Refresh
        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        //Update password
        private void updatePasswordButton_Click(object sender, EventArgs e)
        {            
            try
            {
                    int rowsAffected = userLogic.UpdatePassword(newPasswordTextBox.Text, selectedUser.UserID, CurrentUser.UserLevel);
                    if (rowsAffected > 0)
                    {
                        //worked
                        MessageBox.Show(selectedUser.UserName + " password updated!");
                    }
                    else
                    {
                        //didnt
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user selected!");
            }
            RefreshUserList();
        }

        //Delete user
        private void deleteSelectedUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                int affectedRows = userLogic.DeleteUserByUserID(selectedUser.UserID, CurrentUser.UserLevel);
                //if affectedRows > 0, deleted some people, else didnt
                selectedUser = null;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user selected!");
            }
            RefreshUserList();
        }

        //Add user button
        private void addUserButton_Click(object sender, EventArgs e)
        {
            //get enum back out of datasource of combo box........
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelComboBox.Text);

            int affectedRows = userLogic.AddNewUser(userNameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);
            //if affectedRows > 0, success!

            RefreshUserList();
        }

        //Go to Media Editor
        private void mediaEditorButton_Click(object sender, EventArgs e)
        {
            MediaLogic mediaLogic = new MediaLogic();
            
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaEditor));
            t.Start();
            this.Close();
        }

        public static void OpenMediaEditor()
        {
            Application.Run(new MediaEditor());
        }

        //Log out
        private void logOutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = " ";
            CurrentUser.UserId = 0;
            CurrentUser.UserLevel = 0;

            System.Threading.Thread t = new System.Threading.Thread(OpenLogin);
            t.Start();
            Close();
        }
        //Open login
        private static void OpenLogin()
        {
            Application.Run(new Form1());
        }
        
    }
}
