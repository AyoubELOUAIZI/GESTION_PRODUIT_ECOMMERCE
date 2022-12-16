using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESTION_PRODUIT_ECOMMERCE.presentationLayer;

namespace GESTION_PRODUIT_ECOMMERCE
{
    internal static class Program
    {
        public static string SellerName = "UnkownSeller";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_ORDERS());
        }
    }
}
