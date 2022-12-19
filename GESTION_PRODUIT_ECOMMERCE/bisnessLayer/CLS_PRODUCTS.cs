using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GESTION_PRODUIT_ECOMMERCE.bisnessLayer
{
    internal class CLS_PRODUCTS
    {

        public DataTable GET_ALL_PRODUCTS()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            return dt;
        }

        public DataTable GET_ALL_PRODUCTS_AMAGES()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PRODUCTS_AMAGES", null);
            return dt;
        }

        public DataTable GetAllGategores()
        {
            DataAccessLayer DAL = new DataAccessLayer();       
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllGategores", null);
            return dt;
        }

        public void ADD_PRODUCT(string proName,string description ,int qte,float price,byte[] img1,byte[] img2,byte[] img3,int idcat)
        {
           DataAccessLayer DAL=new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@pname", SqlDbType.VarChar,20);
            param[0].Value = proName;

            param[1] = new SqlParameter("@desc", SqlDbType.VarChar,300);
            param[1].Value = description;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;

            param[4] = new SqlParameter("@img1", SqlDbType.Image);
            param[4].Value = img1;

            param[5] = new SqlParameter("@img2", SqlDbType.Image);
            param[5].Value = img2;

            param[6] = new SqlParameter("@img3", SqlDbType.Image);
            param[6].Value = img3;
           
            param[7] = new SqlParameter("@idcat", SqlDbType.Int);
            param[7].Value = idcat;         
            DAL.ExecuteCommand("AddProduct",param);
           
        }

        public void Update_PRODUCT(string proName, string description, int qte, float price, byte[] img1, byte[] img2, byte[] img3, int idcat,int idproduct)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@pname", SqlDbType.VarChar, 20);
            param[0].Value = proName;

            param[1] = new SqlParameter("@desc", SqlDbType.VarChar, 300);
            param[1].Value = description;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;

            param[4] = new SqlParameter("@img1", SqlDbType.Image);
            param[4].Value = img1;

            param[5] = new SqlParameter("@img2", SqlDbType.Image);
            param[5].Value = img2;

            param[6] = new SqlParameter("@img3", SqlDbType.Image);
            param[6].Value = img3;

            param[7] = new SqlParameter("@idcat", SqlDbType.Int);
            param[7].Value = idcat;

             param[8] = new SqlParameter("@id", SqlDbType.Int);
            param[8].Value = idproduct;

            DAL.ExecuteCommand("UpdateProduct", param);

        }

        public DataTable Search(string input)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@input", SqlDbType.VarChar, 20);
            param[0].Value = input;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("PS_Chearch", param);
            return dt;
        }

        public void DeleteProduct(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.ExecuteCommand("DeleteProduct", param);       
        }

        public DataTable GET_PRODUCT_IMAGE1(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PID", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PRODUCT_IMAGE1", param);
            return dt;
        }
        
        public DataTable GET_PRODUCT_IMAGE2(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PID", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PRODUCT_IMAGE2", param);
            return dt;
        }
        
        public DataTable GET_PRODUCT_IMAGE3(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PID", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PRODUCT_IMAGE3", param);
            return dt;
        }
    }
}
