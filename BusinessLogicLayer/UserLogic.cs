using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
public class UserLogic
    {
        public bool ValidateUser(string sUsername, string sPassword)
        {
            UserDAO userDAO = new UserDAO();
            bool bloginStatus = userDAO.ValidateUser(sUsername, sPassword);
       

            return bloginStatus;


        }
    }
}
