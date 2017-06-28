using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;


namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour configuration.xaml
    /// </summary>
    public partial class configuration : MetroWindow
    {
        public configuration()
        {
            InitializeComponent();

            BDD_adresse.Text = Properties.Settings.Default.BDD_adresse;
            BDD_nom.Text = Properties.Settings.Default.BDD_nom;
            BDD_user.Text = Properties.Settings.Default.BDD_user;
            BDD_password.Text = Properties.Settings.Default.BDD_password;
        }

        private void BT_VALIDER_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default["BDD_adresse"] = BDD_adresse.Text;
            Properties.Settings.Default["BDD_nom"] = BDD_nom.Text;
            Properties.Settings.Default["BDD_user"] = BDD_user.Text;
            Properties.Settings.Default["BDD_password"] = BDD_password.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }




    }


}
