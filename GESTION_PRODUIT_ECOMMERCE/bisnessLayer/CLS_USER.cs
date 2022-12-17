using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GESTION_PRODUIT_ECOMMERCE.bisnessLayer
{
    internal class CLS_USER
    {
                                                        
        public void ADD_USER(string username, string password, string typeuser, byte[] image, string SellerName)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 20);
            param[0].Value = username;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 10);
            param[1].Value = password;

            param[2] = new SqlParameter("@typeuser", SqlDbType.VarChar, 20);
            param[2].Value = typeuser;

            param[3] = new SqlParameter("@image", SqlDbType.Image);
            param[3].Value = image;

            param[4] = new SqlParameter("@SellerName", SqlDbType.VarChar, 25);
            param[4].Value = SellerName;

            DAL.ExecuteCommand("ADD_USER", param);

        }


        public void UPDATE_USER(string username, string password, string typeuser, byte[] image, string SellerName,int iduser)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 20);
            param[0].Value = username;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 10);
            param[1].Value = password;

            param[2] = new SqlParameter("@typeuser", SqlDbType.VarChar, 20);
            param[2].Value = typeuser;

            param[3] = new SqlParameter("@image", SqlDbType.Image);
            param[3].Value = image;

            param[4] = new SqlParameter("@SellerName", SqlDbType.VarChar, 25);
            param[4].Value = SellerName;

            param[5] = new SqlParameter("@iduser", SqlDbType.Int);
            param[5].Value = iduser;

            DAL.ExecuteCommand("UPDATE_USER", param);

        }

        public DataTable GET_ALL_USERS()
        {
            DataAccessLayer DAL = new DataAccessLayer();////////
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_USERS", null);
            return dt;
        }

        internal void DeleteUser(int idUser)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idUser", SqlDbType.Int);
            param[0].Value = idUser;
            DAL.ExecuteCommand("DeleteUser", param);
        }

        internal DataTable SearchUser(string input)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@input", SqlDbType.VarChar, 20);
            param[0].Value = input;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchUser", param);
            return dt;
        }
    }
}
