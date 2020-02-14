using MySql.Data.MySqlClient;
using System;
using Dapper;
using System.Data;
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

namespace Gestion_Jugadores
{

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        private List<Jugador> jugadores;
        public MainWindow()
        {
            InitializeComponent();
            RefreshDatagrid();

        }

        private void BtAnyadir_Click(object sender, RoutedEventArgs e)
        {
            AnyadirJugador anyadirJugador = new AnyadirJugador();
            anyadirJugador.ShowDialog();
        }


        private void RefreshDatagrid()
        {
            using (IDbConnection db = new MySqlConnection(System.Configuration.ConfigurationManager
               .ConnectionStrings["Gestion_Jugadores.Properties.Settings.ligaConnectionString"].ConnectionString))
            {
                jugadores = db.Query<Jugador>("Select * from Jugador").ToList();
                dataGrid.ItemsSource = jugadores;

            }

        }

        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.ShowDialog();
        }

        private void BtRefrescar_Click(object sender, RoutedEventArgs e)
        {
            RefreshDatagrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Borrar borrar = new Borrar();
            borrar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VentanaInforme ventanaInforme = new VentanaInforme();
            ventanaInforme.ShowDialog();
        }
    }
}
