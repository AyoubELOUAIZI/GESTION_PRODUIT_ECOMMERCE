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
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = username;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 20);
            param[1].Value = password;

            param[2] = new SqlParameter("@typeuser", SqlDbType.VarChar, 20);
            param[2].Value = typeuser;

            param[3] = new SqlParameter("@image", SqlDbType.Image);
            param[3].Value = image;

            param[4] = new SqlParameter("@SellerName", SqlDbType.VarChar, 25);
            param[4].Value = SellerName;

            DAL.ExecuteCommand("ADD_USER", param);

        }



    }
}
