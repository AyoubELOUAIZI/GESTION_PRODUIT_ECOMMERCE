using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;

namespace GESTION_PRODUIT_ECOMMERCE.pisnessLayer
{
    internal class CLS_LOGIN
    {
        public DataTable Login(String userName,String password)
        {
            
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user", SqlDbType.VarChar,20);
            param[0].Value= userName;

            param[1] = new SqlParameter("@PASS",SqlDbType.VarChar,10);
            param[1].Value= password;

            DAL.open();
            DataTable dt=new DataTable();
            dt = DAL.SelectData("SP_LOGIN",param);
            DAL.close();    
            return dt;
        }
    } 
}
