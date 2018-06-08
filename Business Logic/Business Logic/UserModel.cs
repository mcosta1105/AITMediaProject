using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class UserModel
    {
        //attribute
        private int userId;
        //property
        public int UserID
        {
            set{ 
                userId = value;
            }
            get { 
                return userId; 
            }
        }
        //propfull- tab tab
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private int userLevel;

        public int UserLevel
        {
            get { return userLevel; }
            set { userLevel = value; }
        }

        //takes a row of data from the UserDataSet and creates a UserModel from it
        public static UserModel Parse(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
                return null;

            UserModel userModel = new UserModel();
            userModel.UserID = userRow.UID;
            userModel.UserName = userRow.UserName;
            userModel.UserLevel = userRow.UserLevel;

            return userModel;
        }

    }
}
