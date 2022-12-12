using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ECOM;integrated Security=true;");
        BindingManagerBase bmb;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("Select IdCAT as 'Id',NamCAT as 'Name',DescriptionCAT as 'Description'  from CATEGORES", con);
            da.Fill(dt); DGListCategories.DataSource = dt;
            textId.DataBindings.Add("text", dt, "Id");
            textBoxName.DataBindings.Add("text", dt, "Name");
            textBoxDescription.DataBindings.Add("text", dt, "Description");
            bmb = this.BindingContext[dt];
            position.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn back
            bmb.Position = 0;
            position.Text = (bmb.Position + 1) + "/" + bmb.Count;


        }

        private void DGListCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            position.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            position.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void priviostbtn_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            position.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(btnNew.Text=="Add New")
            {
                btnNew.Text = "Add Categorie";
                bmb.AddNew();
                textBoxName.TabIndex= 1;
                textBoxDescription.TabIndex= 2;
                btnNew.TabIndex= 3;
            }
            else if (textBoxName.Text.Length > 0)
            {
                btnNew.Text = "Add New";
                int id =Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0])+1;
                textId.Text = id.ToString();
                bmb.EndCurrentEdit();
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                MessageBox.Show("Added seccessfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
                da.Update(dt);

            }
           

           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Updated seccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Categorie", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                // bmb.EndCurrentEdit();
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Delete has been Canceled", "Cancel Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
