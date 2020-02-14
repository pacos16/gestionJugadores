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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {

        public int id;
        public Modificar()
        {
            InitializeComponent();
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
                        tbNombre.Text= reader["NOMBRE"].ToString();
                        tbAltura.Text= reader["ALTURA"].ToString();
                        tbEquipo.Text= reader["EQUIPO"].ToString();
                        tbPosicion.Text= reader["POSICION"].ToString();
                        tbSalario.Text= reader["SALARIO"].ToString();
                        dpCalendar.SelectedDate = DateTime.Parse( reader["FECHA_ALTA"].ToString());
                        tbApellido.Text = reader["APELLIDO"].ToString();
                        id = int.Parse(reader["ID"].ToString());

                        db.Close();
                    }

                }
                catch (MySqlException ex)
                {

                    db.Close();
                    MessageBox.Show("Error en la busqueda", "Error", MessageBoxButton.OK);
                }catch(Exception except)
                {
                    MessageBox.Show("Error en la introducción", "Error", MessageBoxButton.OK);

                }

            }


        }

        private void BtAceptar_Click(object sender, RoutedEventArgs e)
        {

            using (MySqlConnection db = new MySqlConnection(System.Configuration.ConfigurationManager
          .ConnectionStrings["Gestion_Jugadores.Properties.Settings.ligaConnectionString"].ConnectionString))
            {
                try
                {
                    db.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE jugador SET NOMBRE=@nombre,APELLIDO=@apellido,EQUIPO=@equipo,POSICION=@posicion,FECHA_ALTA=@fecha_alta,SALARIO=@salario WHERE ID=@id", db))
                    {
                        cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                        cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = tbNombre.Text;
                        cmd.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = tbApellido.Text;
                        cmd.Parameters.Add("@equipo", MySqlDbType.Int32).Value = int.Parse(tbEquipo.Text);
                        cmd.Parameters.Add("@posicion", MySqlDbType.VarChar).Value = tbPosicion.Text;
                        cmd.Parameters.Add("@fecha_alta", MySqlDbType.DateTime).Value = dpCalendar.SelectedDate;
                        cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = tbSalario.Text;
                        cmd.ExecuteNonQuery();
                        db.Close();
                        MessageBox.Show("La operación ha sido realizada con éxito", "Éxito", MessageBoxButton.OK);
                        this.Close();
                    }

                }
                catch (MySqlException ex)
                {

                    db.Close();
                    MessageBox.Show("Error en la inserción", "Error", MessageBoxButton.OK);
                }

            }

        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
