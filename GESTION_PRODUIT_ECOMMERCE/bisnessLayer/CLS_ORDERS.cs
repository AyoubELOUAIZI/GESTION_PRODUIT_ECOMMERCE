using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_PRODUIT_ECOMMERCE.bisnessLayer
{
    internal class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DataAccessLayer DAL = new DataAccessLayer();////////
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            return dt;
        }

  
        public void AddOrdere(int IdOrder, DateTime DateOrder, int IdCustomer, string Seller)
        {
            DataAccessLayer DAL = new DataAccessLayer();///////////
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[0].Value = IdOrder;

            param[1] = new SqlParameter("@DateOrder", SqlDbType.DateTime);
            param[1].Value = DateOrder;

            param[2] = new SqlParameter("@IdCustomer", SqlDbType.Int);
            param[2].Value = IdCustomer;

            param[3] = new SqlParameter("@Seller", SqlDbType.VarChar,20);
            param[3].Value = Seller;

            DAL.ExecuteCommand("AddOrdere", param);

        }

        public void Add_order_details(int IdProduct, int IdOrder, int Qte, float DESCOUNT, float AMOUNT, float TOTALAMOUNT)
        {
            DataAccessLayer DAL = new DataAccessLayer();///////////
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;

            param[1] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[1].Value = IdOrder;

            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;

            param[3] = new SqlParameter("@DESCOUNT", SqlDbType.Float);
            param[3].Value = DESCOUNT;

            param[4] = new SqlParameter("@AMOUNT", SqlDbType.Float);
            param[4].Value = AMOUNT;

            param[5] = new SqlParameter("@TOTALAMOUNT", SqlDbType.Float);
            param[5].Value = TOTALAMOUNT;

            DAL.ExecuteCommand("Add_order_details", param);

        }

        public DataTable VerifyQte(int idproduct, int Qteinput)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@idproduct", SqlDbType.Int);
            param[0].Value = idproduct;

            param[1] = new SqlParameter("@Qteinput", SqlDbType.Int);
            param[1].Value = Qteinput;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifyQte", param);
            return dt;
        }

        internal object GET_ALL_ORDERS()
        {
            DataAccessLayer DAL = new DataAccessLayer();////////
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_ORDERS", null);
            return dt;
        }

        internal DataTable SearchOrder(string text)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text", SqlDbType.VarChar, 20);
            param[0].Value = text;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchOrder", param);
            return dt;

        }
    }


}
