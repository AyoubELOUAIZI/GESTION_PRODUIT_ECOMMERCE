//to connect with data base directly
//it is the point to access data and information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; //to intract with data

namespace GESTION_PRODUIT_ECOMMERCE.dataAccessLayer
{
    internal class DataAccessLayer
    {
        SqlConnection con= new SqlConnection(@"Server=.\SQLEXPRESS;Database=ECOM;integrated Security=true;");

        public DataAccessLayer()
        {
           // this.sqlconnection = new SqlConnection("");
        }

        //methode to open the connection
        public void open()
        {
            if (con.State != ConnectionState.Open )
            {
                con.Open();
            }
        }
        //methode to close the connection
        public void close()
        {
            if (con.State != ConnectionState.Closed )
            {
                con.Close();
            }
        }

        //Methode to read data from data base
        public DataTable SelectData(String stord_procedure,SqlParameter [] param)
        {
            SqlCommand cmd=new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stord_procedure;
            cmd.Connection= con;

            if(param != null) { 
                for(int i=0;i<param.Length;i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Methode to Insert Update delete data from data base
        public void ExecuteCommand(string stord_procedure, SqlParameter[] param)
        {
           // this.close();
            this.open(); //to open connection
            SqlCommand cmd=new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stord_procedure;
            cmd.Connection = con;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);        
            }
          //  this.open();
            cmd.BeginExecuteNonQuery();
            //.close(); //to close connection
        }


    }
}
