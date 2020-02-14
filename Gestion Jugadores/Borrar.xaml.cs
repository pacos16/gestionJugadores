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

namespace Gestion_Jugadores
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Borrar : Window
    {
        public Borrar()
        {
            InitializeComponent();
            tbApellido.IsReadOnly = true;
            tbNombre.IsReadOnly = false;
        }

        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(System.Configuration.ConfigurationManager
                .ConnectionStrings["Gestion_Jugadores.Properties.Settings.ligaConnectionString"].ConnectionString))
            {
                try
                {
                    db.Open();
                    using (MySqlCommand cmd = new MySqlCommand("select * from jugador where ID=?id", db))
                    {
                        cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = int.Parse(tbID.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        tbNombre.Text = reader["NOMBRE"].ToString();
                        tbApellido.Text = reader["APELLIDO"].ToString();
                        db.Close();
                    }

                }
                catch (MySqlException ex)
                {

                    db.Close();
                    MessageBox.Show("Error en la busqueda", "Error", MessageBoxButton.OK);
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error en la introducción", "Error", MessageBoxButton.OK);

                }

            }
        }

        private void BtBorrar_Click(object sender, RoutedEventArgs e)
        {

           var result= MessageBox.Show("Esta seguro que quiere eliminar al jugador " + tbNombre.Text + " " + tbApellido.Text, "Confirmación", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                using (MySqlConnection db = new MySqlConnection(System.Configuration.ConfigurationManager
                    .ConnectionStrings["Gestion_Jugadores.Properties.Settings.ligaConnectionString"].ConnectionString))
                {
                    try
                    {
                        db.Open();
                        using (MySqlCommand cmd = new MySqlCommand("delete from jugador where ID=?id", db))
                        {
                            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = int.Parse(tbID.Text);
                            cmd.ExecuteNonQuery();

                            db.Close();
                            tbID.Text = "";
                            tbNombre.Text = "";
                            tbApellido.Text = "";
                        }

                    }
                    catch (MySqlException ex)
                    {

                        db.Close();
                        MessageBox.Show("Fallo al borrar", "Error", MessageBoxButton.OK);
                    }
                    catch (Exception except)
                    {
                        MessageBox.Show("Error en la id", "Error", MessageBoxButton.OK);

                    }
                }
            }

        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
