using System;
using System.Collections.Generic;
using System.Configuration;
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
    public partial class VentanaInforme : Window
    {
        public VentanaInforme()
        {
            InitializeComponent();
            ligaDataSet dsTodaLaLiga = new ligaDataSet();
            informeDatos.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            dsTodaLaLiga.BeginInit();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = dsTodaLaLiga.jugador; informeDatos.LocalReport.DataSources.Add(reportDataSource1);
            informeDatos.LocalReport.ReportPath = "Report1.rdlc";
            dsTodaLaLiga.EndInit();
            try
            {
                String conexion = ConfigurationManager.ConnectionStrings["Gestion_Jugadores.Properties.Settings.ligaConnectionString"].ConnectionString;
                MySql.Data.MySqlClient.MySqlDataAdapter JugadoreTableAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter("Select * From jugador as j,equipo as e where j.equipo=e.id", conexion);
                dsTodaLaLiga.Clear();
                JugadoreTableAdapter.Fill(dsTodaLaLiga);
                informeDatos.RefreshReport();
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception);
            }
            informeDatos.RefreshReport();
            
        }
    }
}
