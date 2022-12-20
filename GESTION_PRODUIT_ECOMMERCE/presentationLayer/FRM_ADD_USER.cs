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
    public partial class FRM_ADD_USER : Form
    {
        public int idUsertoUpdate;
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxUserName.Text = string.Empty;
            boxPassword.Text = string.Empty;
            boxSellername.Text = string.Empty;
            boxConfirmPass.Text = string.Empty;
            userImage.Image = Properties.Resources.Avatar;
            
        }

        private void FRM_ADD_USER_Load(object sender, EventArgs e)
        {
            userImage.Image = Properties.Resources.Avatar;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(boxPassword.Text == string.Empty || boxConfirmPass.Text == string.Empty ||boxUserName.Text == string.Empty|| boxSellername.Text == string.Empty)
            {
                MessageBox.Show("please Complete All feilds of the form","Complete the form",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(boxPassword.Text != boxConfirmPass.Text)
            {
                MessageBox.Show("you have problem\npassWord not Confermed successfully", "error passWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxPassword.Focus();
                return;
            }

            if (comboTypeUser.Text != "administrator" && comboTypeUser.Text != "normal user")
            {
                MessageBox.Show("you have problem\nType of User is not correct", "error Type user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboTypeUser.Focus();
                return;
            }

            if(btnAddUser.Text== "Update User")
            {
                CLS_USER user1 = new CLS_USER();
                MemoryStream ms1 = new MemoryStream();
                userImage.Image.Save(ms1, userImage.Image.RawFormat);
                byte[] imgbyte1 = ms1.ToArray();
                user1.UPDATE_USER(boxUserName.Text, boxPassword.Text, comboTypeUser.Text, imgbyte1, boxSellername.Text,idUsertoUpdate);
                MessageBox.Show("User " + boxUserName + " has been Updated seccessfully", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CLS_USER user=new CLS_USER();
            MemoryStream ms = new MemoryStream();
            userImage.Image.Save(ms, userImage.Image.RawFormat);
            byte[] imgbyte = ms.ToArray();
            user.ADD_USER(boxUserName.Text,boxPassword.Text,comboTypeUser.Text, imgbyte, boxSellername.Text);
            MessageBox.Show("User "+boxUserName+" has been add seccessfully", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void userImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images folder | *.jpg; *.png; *.SVG; *.gif; *.bmp ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                userImage.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
