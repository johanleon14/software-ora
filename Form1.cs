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


namespace Proyecto_Software_2
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        private OracleConnection ora;
        private void button1_Click(object sender, EventArgs e)
        {
            ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = "+TxPassword.Text+"; USER ID = "+TxUsuario.Text+";");
            //OracleConnection conexion = new OracleConnection("DATA SOURCE =");
            ora.Open();
            MessageBox.Show("Conectado a la base de datos");
            BtConectar.Visible = false;
            TxUsuario.Visible = false;
            TxPassword.Visible = false;
            LbPassword.Visible = false;
            LbUsuario.Text = "Conectado con el usuario " + TxUsuario.Text+".";
            BtDesconectar.Visible = true;
        }

        private void BtDesconectar_Click(object sender, EventArgs e)
        {
            ora.Close();
            MessageBox.Show("Desconectado de la base de datos");
            BtDesconectar.Visible = false;
            BtConectar.Visible = true;
            TxUsuario.Visible = true;
            TxPassword.Visible = true;
            LbPassword.Visible = true;
            LbUsuario.Text = "Usuario";
            
        }
    }
}
