using MySql.Data.MySqlClient;
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
using Dapper;

namespace Gestion_Jugadores
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class AnyadirJugador : Window
    {
        public AnyadirJugador()
        {
            InitializeComponent();
        }


        private void Button_Aceptar(object sender, RoutedEventArgs e)
        {
            if (tbID.Text.Equals("") || tbEquipo.Text.Equals("") || tbNombre.Text.Equals("") || tbPosicion.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Fatal Exception", MessageBoxButton.OK);
            }
            else
            {


                using (MySqlConnection db = new MySqlConnection(System.Configuration.ConfigurationManager
            .ConnectionStrings["Gestion_Jugadores.Properties.Settings.ligaConnectionString"].ConnectionString))
                {
                    try
                    {
                        db.Open();
                        using (MySqlCommand cmd = new MySqlCommand("Insert INTO jugador (ID,NOMBRE,APELLIDO,EQUIPO,POSICION,FECHA_ALTA,SALARIO)" +
                             "  VALUES(?id,?nombre,?apellido,?equipo,?posicion,?fecha_alta,?salario)", db))
                        {
                            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = int.Parse(tbID.Text);
                            cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = tbNombre.Text;
                            cmd.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = tbApellido.Text;
                            cmd.Parameters.Add("?equipo", MySqlDbType.Int32).Value = int.Parse(tbEquipo.Text);
                            cmd.Parameters.Add("?posicion", MySqlDbType.VarChar).Value = tbPosicion.Text;
                            cmd.Parameters.Add("?fecha_alta", MySqlDbType.DateTime).Value = dpCalendar.SelectedDate;
                            cmd.Parameters.Add("?salario", MySqlDbType.VarChar).Value = tbSalario.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("La operación ha sido realizada con éxito", "Éxito", MessageBoxButton.OK);
                            this.Close();
                        }
                        
                    }catch(MySqlException ex)
                    {
                        
                        db.Close();
                        MessageBox.Show("Error en la inserción", "Error", MessageBoxButton.OK);
                    }

                }

            }
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }
}
