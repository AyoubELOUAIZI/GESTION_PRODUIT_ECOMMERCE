using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.bisnessLayer
{
    internal class CLS_CUSTOMERS
    {
      //  DataAccessLayer DAL = new DataAccessLayer();
      

        public void ADD_CUSTOMER(string FirstName, string LastName, string phone, string email, string city, byte[] img)
        {
            DataAccessLayer DAL = new DataAccessLayer();///////////
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

        public void UPDATE_CUSTOMER(string FirstName, string LastName, string phone, string email, string city, byte[] img,int idcus)
        {
            DataAccessLayer DAL = new DataAccessLayer();////////
            SqlParameter[] param = new SqlParameter[7];
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

             param[6] = new SqlParameter("@idcus", SqlDbType.Int);
            param[6].Value = idcus ;


            DAL.ExecuteCommand("UPDATE_CUSTOMER", param);

        }

        public void DELETE_CUSTOMER(int idcus)
        {
            DataAccessLayer DAL = new DataAccessLayer();/////
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idcus", SqlDbType.Int);
            param[0].Value = idcus;
            DAL.ExecuteCommand("DELETE_CUSTOMER", param);
        }



        public DataTable GetAllCustomers()
        {
            DataAccessLayer DAL = new DataAccessLayer();////////
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllCustomers", null);
            return dt;
        }

        internal DataTable SEARCH_CUSTOMER(string text)
        {
            DataAccessLayer DAL = new DataAccessLayer();//////
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.VarChar,20);
            param[0].Value = text;
            dt = DAL.SelectData("SEARCH_CUSTOMER", param);
            return dt;
        }
    }

   
}
