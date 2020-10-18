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
        public bool flag = false;
        private OracleConnection ora;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = " + TxPassword.Text + "; USER ID = " + TxUsuario.Text + ";");
                ora.Open();
                flag = true;
                MessageBox.Show("Conectado a la base de datos");
                BtConectar.Visible = false;
                TxUsuario.Visible = false;
                TxPassword.Visible = false;
                LbPassword.Visible = false;
                LbUsuario.Text = "Conectado con el usuario " + TxUsuario.Text + ".";
                BtDesconectar.Visible = true;
                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("IOException:" + ex.Message);
            }
           
        }

        private void BtDesconectar_Click(object sender, EventArgs e)
        {
            ora.Close();
            MessageBox.Show("Desconectado de la base de datos");
            flag = false;
            BtDesconectar.Visible = false;
            BtConectar.Visible = true;
            TxUsuario.Visible = true;
            TxPassword.Visible = true;
            LbPassword.Visible = true;
            LbUsuario.Text = "Usuario";
            
        }

        private void TxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnejecutarsql_Click(object sender, EventArgs e)
        {
            //ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = sistemas; USER ID = johan;");
            //string sql = "create sequence secuencia3 increment by -1 start with 100 maxvalue 100 minvalue 0 ";

            if (flag == true)
            {
                // SQL Statement
                ora.Open();

                string sql = txtsql.Text;
                OracleCommand cmd = new OracleCommand(sql, ora);

                try
                {
                    cmd.CommandType = CommandType.Text;
                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = cmd;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgv.DataSource = tabla;
                    MessageBox.Show("Ejecutado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IOException:" + ex.Message);
                }
                finally
                {
                    ora.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor inicie sesión");
            }

        }
        public void limpiar()
        {
            txtsql.Text = "";
            dgv.DataSource = new DataTable();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
