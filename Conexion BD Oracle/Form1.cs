using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Conexion_BD_Oracle
{
    public partial class Form1 : Form
    {
        // CMD:     odbcad32.exe
        OdbcConnection db_conn = new OdbcConnection(@"Dsn=nts;
                                                    HST=5155922.connect.api.netsuite.com;
                                                    PRT=1708;
                                                    UID=lgras@cedal.com.ar;
                                                    password=Net-Lg242024;");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConectarBD();
        }

        private void ConectarBD()
        {
            try
            {
                // Crear la conexión
                using (db_conn)
                {
                
                    if (btn_ConectarBD.Text == "Conectar a BD")
                    {
                        // Abrir la conexión
                        db_conn.Open();
                        MessageBox.Show("Conexión exitosa a Oracle.");

                        if (db_conn.State == ConnectionState.Open)
                        {
                            lbl_estado.Text = "Conectado a BD Netsuite.";
                            btn_ConectarBD.Text = "Desconectar BD";
                        }

                        // consultas SQL u otras operaciones en la base de datos
                        // OracleCommand command = new OracleCommand("SELECT * FROM mi_tabla", connection);
                        // OracleDataReader reader = command.ExecuteReader();
                        // while (reader.Read())
                        // {
                        //     
                        // }
                    }
                    else
                    {
                        // Abrir la conexión
                        db_conn.Close();
                        MessageBox.Show("Se ha cerrado la conexión a Oracle.");

                        if (db_conn.State == ConnectionState.Closed)
                        {
                            lbl_estado.Text = "Sin Conexión.";
                            btn_ConectarBD.Text = "Conectar a BD";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a Oracle: \n-Error: " + ex.Message);
            }
        }

        private void btn_ConectarBD_Click(object sender, EventArgs e)
        {
            ConectarBD();
        }
    }
}
