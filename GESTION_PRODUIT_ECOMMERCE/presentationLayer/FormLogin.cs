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
            Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.Login(userNametxt.Text,passtxt.Text);
            if(dt.Rows.Count>0 ) {
                MessageBox.Show("log in secssed");
            }
            else
            {
                MessageBox.Show("log in failled");

            }
        }
    }
}
