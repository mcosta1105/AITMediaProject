using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class UserLogic
    {
        #region attributes

        private UserDAO userDAO;

        #endregion

        //constructor
        public UserLogic()
        {
            userDAO = new UserDAO();
        }

        public List<UserModel> GetListOfUsers()
        {
            List<UserModel> users = new List<UserModel>();//build an empty list of users

            //get users in form of data table from Data Access layer
            UserDS.TabUserDataTable userTable = userDAO.GetUserDataTable();

            GetListOfUsersFromDataTable(users, userTable);

            return users; //give list to whoever asked for it
        }

        public List<UserModel> GetListOfUsersByUserNameAndPassword(string username, string password)
        {
            List<UserModel> users = new List<UserModel>();//build an empty list of users

            //get users in form of data table from Data Access layer
            UserDS.TabUserDataTable userTable = userDAO.GetUserByUserNamePassword(username, password);

            GetListOfUsersFromDataTable(users, userTable);

            return users; //give list to whoever asked for it
        }

        private static void GetListOfUsersFromDataTable(List<UserModel> users, UserDS.TabUserDataTable userTable)
        {
            //but we wanna use our models instead, not a datatable!!
            //so, for every row in our table
                       
            foreach (UserDS.TabUserRow row in userTable.Rows)
            {
                //create a user model representing that row
                UserModel user = UserModel.Parse(row);
                users.Add(user);//add to our list of users
            }
            
        }

        //NEW
        //New user
        public int AddNewUser(string username, string password, int userLevel, string email)
        {
            return userDAO.InsertNewUser(username, password, userLevel, email);
        }

        //Update Password
        public int UpdatePassword(string newPassword, int userID, int userLevel)
        {
            if (userLevel < 3)//not an admin, can't change users password!
                return -1;
            else
                return userDAO.UpdatePassword(newPassword, userID);
        }

        //Delete user by ID
        public int DeleteUserByUserID(int userID, int userLevel)
        {
            if (userLevel < 3)//not an admin, can't delete users!
                return -1;
            else
                return userDAO.DeleteUserByUserID(userID);
        }

        
    }
}
