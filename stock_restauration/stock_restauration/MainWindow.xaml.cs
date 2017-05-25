﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using System.Windows.Threading;

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow :MetroWindow
    {
        private int btn_orga;
        private int btn_bene;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(horloge);
            timer.Start();

            btn_bene = 2;
            btn_orga = 1;


        }

        private void btn_benevole_Click(object sender, RoutedEventArgs e)
        {

            mdp.mot_passe wind_mdp = new mdp.mot_passe();
            wind_mdp.ShowDialog();
        }

        private void btn_organisateur_Click(object sender, RoutedEventArgs e)
        {
            mdp.mot_passe wind_mdp = new mdp.mot_passe();

            wind_mdp.ShowDialog();        
        }

        private void btn_prog_Click(object sender, RoutedEventArgs e)
        {
            programation wind_programation = new programation();
            wind_programation.ShowDialog();
        }

        private void btn_conf_Click(object sender, RoutedEventArgs e)
        {
            configuration wind_configuration = new configuration();
            mdp.mot_passe wind_mdp = new mdp.mot_passe();
            wind_mdp.ShowDialog();
            wind_configuration.ShowDialog();
        }

        public void horloge (object sender, EventArgs e)
        {
            heure.Content = DateTime.Now.ToLongTimeString();
        }


    }
}
