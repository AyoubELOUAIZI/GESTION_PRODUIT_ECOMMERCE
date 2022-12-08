﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FormMain : Form
    {
        private static FormMain frm;
        static void frm_formClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FormMain getFormMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FormMain();
                    frm.FormClosed +=new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }

        }
        public FormMain()
        {
            InitializeComponent();
            if(frm == null)
            {
                frm = this;
            }
            this.productToolStripMenuItem.Enabled= false;
            this.customersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.buckupToolStripMenuItem.Enabled = false;
            this.restoreBackupToolStripMenuItem.Enabled = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm=new FormLogin();
            frm.ShowDialog(this);
        }
    }
}
