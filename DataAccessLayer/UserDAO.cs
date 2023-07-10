using DataAccessLayer.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class UserDAO
    {
        
        public bool ValidateUser(string sUserName, string sPassword) 
        {
            TabUserTableAdapter objTabUserTableAdapter = new TabUserTableAdapter();
            DataSet1.TabUserDataTable objTabUserDataTable = objTabUserTableAdapter.ValidateUserLogin(sUserName,sPassword); 
            
            return false; }
    }
}
