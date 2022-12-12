using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_PRODUIT_ECOMMERCE.bisnessLayer
{
    internal class CLS_CUSTOMERS
    {

        
        public void ADD_CUSTOMER(string FirstName, string LastName, string phone, string email, string city, byte[] img)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 20);
            param[0].Value = FirstName;

            param[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 20);
            param[1].Value = LastName;

            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
            param[2].Value = phone;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 20);
            param[3].Value = email;

            param[4] = new SqlParameter("@city", SqlDbType.VarChar, 20);
            param[4].Value = city;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;

           
            DAL.ExecuteCommand("ADD_CUSTOMER", param);

        }





    }

   
}
