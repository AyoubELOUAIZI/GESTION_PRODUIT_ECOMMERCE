using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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

    }


}
