using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using TestWebApp2.DAL;
using System.Data;


namespace TestWebApp2 
{
    
    public class BAL
    {
        public void insertUser(string name, string email, int gender)
        {
            DAL sa = new DAL();
            sa.insert(name,email,gender);
        }
        
        public DataTable select()
        {
            DAL sa = new DAL();
            return sa.select();
        }
       

    }
}