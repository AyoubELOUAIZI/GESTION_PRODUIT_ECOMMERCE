using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESTION_PRODUIT_ECOMMERCE.pisnessLayer;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FormLogin : Form
    {
        CLS_LOGIN log =new CLS_LOGIN();
        public FormLogin()
        {
            InitializeComponent();
        }

       

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.Login(userNametxt.Text,passtxt.Text);
            if(dt.Rows.Count>0 ) {
                // MessageBox.Show("log in secssed");
                /* FormMain frm=new FormMain();
                  frm.productToolStripMenuItem.Enabled = true;
                  frm.customersToolStripMenuItem.Enabled = true;
                  frm.usersToolStripMenuItem.Enabled = true;
                  frm.buckupToolStripMenuItem.Enabled = true;
                  frm.restoreBackupToolStripMenuItem.Enabled = true; */
                if (dt.Rows[0][3].ToString() == "administrator")
                {
                    FormMain.getFormMain.productToolStripMenuItem.Enabled = true;
                    FormMain.getFormMain.customersToolStripMenuItem.Enabled = true;
                    FormMain.getFormMain.usersToolStripMenuItem.Enabled = true;
                    FormMain.getFormMain.buckupToolStripMenuItem.Enabled = true;
                    FormMain.getFormMain.restoreBackupToolStripMenuItem.Enabled = true;

                    FormMain.getFormMain.usersToolStripMenuItem.Visible = true;
                    FormMain.getFormMain.buckupToolStripMenuItem.Visible = true;
                    FormMain.getFormMain.restoreBackupToolStripMenuItem.Visible = true;
                    Program.SellerName = dt.Rows[0]["SellerName"].ToString();
                    this.Close();
                }
                else if(dt.Rows[0][3].ToString() == "normal user") {
                    FormMain.getFormMain.productToolStripMenuItem.Enabled = true;
                    FormMain.getFormMain.customersToolStripMenuItem.Enabled = true;
                    FormMain.getFormMain.usersToolStripMenuItem.Visible = false; 
                    FormMain.getFormMain.buckupToolStripMenuItem.Visible = false;
                    FormMain.getFormMain.restoreBackupToolStripMenuItem.Visible = false;
                    Program.SellerName = dt.Rows[0]["SellerName"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(dt.Rows[0][3].ToString());
                } 

            }
            else
            {
                MessageBox.Show("log in failled");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
