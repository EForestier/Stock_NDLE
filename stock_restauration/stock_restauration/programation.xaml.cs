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
using System.Windows.Threading;


namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour programation.xaml
    /// </summary>
    public partial class programation : MetroWindow
    {
       

        public programation()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(horloge);
            timer.Start();

        }

        public void horloge(object sender, EventArgs e)
        {
            heure.Content = DateTime.Now.ToLongTimeString();
        }
    }
}
