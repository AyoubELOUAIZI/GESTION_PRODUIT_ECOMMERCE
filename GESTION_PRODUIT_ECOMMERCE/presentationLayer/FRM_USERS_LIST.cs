using GESTION_PRODUIT_ECOMMERCE.bisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FRM_USERS_LIST : Form
    {
        public FRM_USERS_LIST()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER ADD_USER= new FRM_ADD_USER();
            ADD_USER.ShowDialog();
        }

        private void FRM_USERS_LIST_Load(object sender, EventArgs e)
        {
            fillDatagridViewofUsers();
           // this.dataGridView1.Rows[1].Selected = true;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.Columns[2].Width = 110;
        }

        void fillDatagridViewofUsers()
        {
            CLS_USER USER = new CLS_USER();
            dataGridView1.DataSource = USER.GET_ALL_USERS();
          //  this.dataGridView1.Columns[3].Width = 130;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   picturUser.Image= dataGridView1.
          //  byte[] img1 = (byte[])this.dataGridView1.CurrentRow.Cells[4].Value;
          //  MemoryStream ms = new MemoryStream(img1);
          //  this.picturUser.Image = Image.FromStream(ms);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {      
                //   picturUser.Image= dataGridView1.
                byte[] img1 = (byte[])this.dataGridView1.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(img1);
                this.picturUser.Image = Image.FromStream(ms);
           
        }

        private void boxSearch_TextChanged(object sender, EventArgs e)
        {
            CLS_USER USER = new CLS_USER();
            DataTable dt = new DataTable();
             dt = USER.SearchUser(boxSearch.Text);
            dataGridView1.DataSource = dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CLS_USER USER = new CLS_USER();
                USER.DeleteUser(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("User deleted seccessfully");
                fillDatagridViewofUsers();
            }
            else
            {
                MessageBox.Show("deleting has been canceled", "Cancel Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER update_USER = new FRM_ADD_USER();
            update_USER.boxUserName.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update_USER.boxSellername.Text= this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            update_USER.boxPassword.Text= this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update_USER.boxConfirmPass.Text= this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update_USER.comboTypeUser.Text= this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //image takes somme steps always
            byte[] img1 = (byte[])this.dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img1);
            update_USER.userImage.Image = Image.FromStream(ms);
            //change the button text
            update_USER.btnAddUser.Text = "Update User";
            btnRefrech.BackColor = Color.Aqua;
            btnRefrech.Focus();
            update_USER.idUsertoUpdate=int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            update_USER.ShowDialog();
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            fillDatagridViewofUsers();
            btnRefrech.BackColor = Color.Gainsboro;

        }
    }
}
