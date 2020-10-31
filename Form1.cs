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
                BtConectar.Visible = false;
                TxUsuario.Visible = false;
                TxPassword.Visible = false;
                LbPassword.Visible = false;
                LbUsuario.Text = "Conectado con el usuario " + TxUsuario.Text + ".";
                BtDesconectar.Visible = true;
                ora.Close();
                Tree();
            }
            catch (Exception ex)
            {
                MessageBox.Show("IOException:" + ex.Message);
            }
           
        }
        private void TxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = " + TxPassword.Text + "; USER ID = " + TxUsuario.Text + ";");
                    ora.Open();
                    flag = true;
                    BtConectar.Visible = false;
                    TxUsuario.Visible = false;
                    TxPassword.Visible = false;
                    LbPassword.Visible = false;
                    LbUsuario.Text = "Conectado con el usuario " + TxUsuario.Text + ".";
                    BtDesconectar.Visible = true;
                    ora.Close();
                    Tree();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IOException:" + ex.Message);
                }
            }
        }

        private void BtDesconectar_Click(object sender, EventArgs e)
        {
            limpiarTree();
            limpiarSesion();
            limpiar();
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

        private void btnlimpiarsql_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnejecutarsql_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                try
                {
                    string[] consulta = txtsql.Text.Split(' ');
                    consulta[0] = consulta[0].ToLower();
                    string sql = "";
                    if (consulta[0].Equals("select") || consulta[0].Equals("insert") || consulta[0].Equals("update") || consulta[0].Equals("drop") || consulta[0].Equals("delete") || consulta[0].Equals("alter") || consulta[0].Equals("create")) {
                        String aux = txtsql.Text;
                        sql=aux.TrimEnd(';');
                    }
                    else {
                        sql = txtsql.Text;
                    }
                    ora.Open();
                    OracleCommand cmd = new OracleCommand(sql, ora);
                    cmd.CommandType = CommandType.Text;
                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = cmd;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgv.DataSource = tabla;
                    ora.Close();
                    limpiarTree();
                    Tree();
                    
                }
                catch (Exception ex)
                {
                    ora.Close();
                    MessageBox.Show("IOException:" + ex.Message+" error en sql");
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
        public void limpiarSesion()
        {
            TxUsuario.Text = "";
            TxPassword.Text = "";

        }
        public void limpiarTree()
        {
            tree.Nodes.Clear();
        }
        public void Tree()
        {
            
            try
            {
                OracleCommand cmd;
                OracleDataReader reader;

                //TABLAS
                TreeNode node1 = new TreeNode("Tablas");
                ora.Open();
                cmd = new OracleCommand("SELECT * FROM USER_TABLES", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node1.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node1);
                ora.Close();

                //INDICES
                TreeNode node2 = new TreeNode("Índices");
                ora.Open();
                cmd = new OracleCommand("SELECT* FROM USER_INDEXES ORDER BY TABLE_NAME", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node2.Nodes.Add(reader.GetString(0));

                }
                tree.Nodes.Add(node2);
                ora.Close();

                //PAQUETES
                TreeNode node3 = new TreeNode("Paquetes");
                ora.Open();
                cmd = new OracleCommand("SELECT * FROM USER_OBJECTS WHERE OBJECT_TYPE='PACKAGE'", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node3.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node3);
                ora.Close();

                //PROCEDIMIENTOS
                TreeNode node4 = new TreeNode("Procedimientos");
                ora.Open();
                cmd = new OracleCommand("SELECT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE='PROCEDURE'", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node4.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node4);
                ora.Close();

                //FUNCIONES
                TreeNode node5 = new TreeNode("Funciones");
                ora.Open();
                cmd = new OracleCommand("SELECT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE='FUNCTION'", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node5.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node5);
                ora.Close();

                //DISPARADORES
                TreeNode node6 = new TreeNode("Disparadores");
                ora.Open();
                cmd = new OracleCommand("SELECT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE='TRIGGER'", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node6.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node6);
                ora.Close();

                //SECUENCIAS
                TreeNode node7 = new TreeNode("Secuencias");
                ora.Open();
                cmd = new OracleCommand("SELECT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE='SEQUENCE'", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node7.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node7);
                ora.Close();

                //RESTRICCIONES
                TreeNode node8 = new TreeNode("Restricciones");
                ora.Open();
                cmd = new OracleCommand("SELECT  CONSTRAINT_NAME FROM all_constraints where owner = '"+TxUsuario.Text.ToUpper()+"' AND CONSTRAINT_TYPE = 'C' AND CONSTRAINT_NAME NOT LIKE 'BIN$%'", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node8.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node8);
                ora.Close();
                //TABLESPACE
                TreeNode node9 = new TreeNode("Tablespace");
                ora.Open();
                cmd = new OracleCommand("select distinct tablespace_name from dba_data_files", ora);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    node9.Nodes.Add(reader.GetString(0));
                }
                tree.Nodes.Add(node9);
                ora.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("IOException:" + ex.Message+" tree");
            }
        }


        private void tree_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode selectedNode = tree.HitTest(e.Location).Node;
            if (selectedNode != null)
            {
                if (selectedNode.FullPath.ToString().Contains("\\"))
                {
                    string seleccionado = selectedNode.FullPath;
                    string[] split = seleccionado.Split('\\');
                    limpiar();
                    try
                    {
                        OracleCommand cmd;
                        OracleDataReader reader;
                        // CUANDO UNA TABLA ES SELECCIONADA
                        if (split[0].Equals("Tablas"))
                        {
                            ora.Open();

                            cmd = new OracleCommand("select COLUMN_NAME,DATA_TYPE,DATA_LENGTH,DATA_PRECISION from ALL_TAB_COLUMNS where table_name = '" + split[1].ToUpper()+"' AND OWNER='"+TxUsuario.Text.ToUpper()+"'", ora);
                            
                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "ESTRUCTURA: \n";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    /*if (reader.GetString(1).Equals("NUMBER"))
                                    {
                                        cadena = cadena + reader.GetString(0) + "\t" + reader.GetString(1)+ "\n";

                                    }
                                    else
                                    {
                                        cadena = cadena + reader.GetString(0) + "\t" + reader.GetString(1) + "(" + reader.GetInt32(2) + ")" + "\n";
                                    }*/
                                    Console.WriteLine(reader.GetValue(3));
                                    if (reader.GetString(1).Equals("NUMBER") && !reader.GetValue(3).Equals(""))
                                    {
                                        cadena = cadena + reader.GetString(0) + "\t" + reader.GetString(1) + " " + reader.GetValue(3) + "\n";

                                    }
                                    else
                                    {
                                        if (reader.GetString(1).Equals("VARCHAR2"))
                                        {
                                            cadena = cadena + reader.GetString(0) + "\t" + reader.GetString(1) + "(" + reader.GetInt32(2) + ")" + "\n";
                                        }
                                        else
                                        {
                                            cadena = cadena + reader.GetString(0) + "\t" + reader.GetString(1) + "\n";
                                        }
                                    }
                                   

                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();

                            ora.Open();
                            cmd = new OracleCommand("SELECT*FROM " + split[1], ora);
                            cmd.CommandType = CommandType.Text;
                            OracleDataAdapter adaptador = new OracleDataAdapter();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                adaptador.SelectCommand = cmd;
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);
                                dgv.DataSource = tabla;
                                
                            }
                            ora.Close();



                        }
                        // CUANDO UN PAQUETE ES SELECCIONADO
                        if (split[0].Equals("Paquetes"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("select TEXT from ALL_SOURCE WHERE OWNER='" + TxUsuario.Text.ToUpper() + "' AND NAME='" + split[1] + "' AND TYPE='PACKAGE'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = cadena + reader.GetString(0) + "\t";
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();
                        }
                        // CUANDO UN PROCEDIMIENTO ES SELECCIONADO
                        if (split[0].Equals("Procedimientos"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("select TEXT from ALL_SOURCE WHERE OWNER='" + TxUsuario.Text.ToUpper() + "' AND NAME='" + split[1] + "' AND TYPE='PROCEDURE'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = cadena + reader.GetString(0) + "\t";
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();

                        }
                        // CUANDO UNA FUNCION ES SELECCIONADA
                        if (split[0].Equals("Funciones"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("select TEXT from ALL_SOURCE WHERE OWNER='" + TxUsuario.Text.ToUpper() + "' AND NAME='" + split[1] + "' AND TYPE='FUNCTION'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = cadena + reader.GetString(0) + "\t";
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();

                        }
                        // CUANDO UN DISPARADOR ES SELECCIONADO
                        if (split[0].Equals("Disparadores"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("select TEXT from ALL_SOURCE WHERE OWNER='" + TxUsuario.Text.ToUpper() + "' AND NAME='" + split[1] + "' AND TYPE='TRIGGER'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = cadena + reader.GetString(0) + "\t";
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();


                        }
                        // CUANDO UNA RESTRICCION ES SELECCIONADA
                        if (split[0].Equals("Restricciones"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("SELECT CONSTRAINT_NAME,TABLE_NAME,SEARCH_CONDITION FROM all_constraints  where owner='"+TxUsuario.Text.ToUpper()+"' AND CONSTRAINT_TYPE='C' AND CONSTRAINT_NAME='"+split[1]+"'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = "Nombre\t\t" + reader.GetString(0) + "\nUbicación\t" + reader.GetString(1) + "\nCondición\t\t" + reader.GetString(2)+"";
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();
                        }

                        // CUANDO UN INDICE ES SELECCIONADA
                        if (split[0].Equals("Índices"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("SELECT INDEX_NAME, TABLE_NAME,UNIQUENESS,TABLESPACE_NAME FROM user_indexes WHERE INDEX_NAME='"+ split[1] + "'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = "Nombre\t\t" + reader.GetString(0) + "\nTabla: \t\t"+ reader.GetString(1) + "\nUnicidad: \t" + reader.GetString(2) + "\nTablespace: \t" + reader.GetString(3);
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();

                            ora.Open();
                            cmd = new OracleCommand("SELECT*FROM user_indexes WHERE INDEX_NAME='" + split[1]+"'", ora);
                            cmd.CommandType = CommandType.Text;
                            OracleDataAdapter adaptador = new OracleDataAdapter();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                adaptador.SelectCommand = cmd;
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);
                                dgv.DataSource = tabla;

                            }
                            ora.Close();
                        }

                        // CUANDO UNA SECUENCIA ES SELECCIONADA
                        if (split[0].Equals("Secuencias"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("SELECT sequence_name,min_value, max_value,increment_by,last_number FROM user_sequences WHERE sequence_name='" + split[1] + "'", ora);

                            cmd.CommandType = CommandType.Text;
                            reader = cmd.ExecuteReader();
                            String cadena = "";
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cadena = "Nombre\t\t" + reader.GetString(0) + "\nValor Min: \t" + reader.GetValue(1) + "\nValor Max: \t" + reader.GetValue(2) + "\nIncremento de: \t" + reader.GetValue(3) + "\nÚltimo Número: \t" + reader.GetValue(4);
                                }
                            }
                            txtsql.Text = cadena;
                            ora.Close();

                            ora.Open();
                            cmd = new OracleCommand("SELECT * FROM user_sequences WHERE SEQUENCE_NAME='" + split[1] + "'", ora);
                            cmd.CommandType = CommandType.Text;
                            OracleDataAdapter adaptador = new OracleDataAdapter();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                adaptador.SelectCommand = cmd;
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);
                                dgv.DataSource = tabla;

                            }
                            ora.Close();
                        }
                        if (split[0].Equals("Tablespace"))
                        {
                            ora.Open();
                            cmd = new OracleCommand("select tablespace_name Nombre, file_name Datafile,status Estado, bytes, round(bytes/1048576) Megabytes from dba_data_files where tablespace_name='" + split[1]+"'", ora);

                            cmd.CommandType = CommandType.Text;
                            
                            OracleDataAdapter adaptador = new OracleDataAdapter();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                adaptador.SelectCommand = cmd;
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);
                                dgv.DataSource = tabla;

                            }
                            ora.Close();
                        }


                    }
                    catch (Exception ex)
                    {
                        ora.Close();
                        MessageBox.Show("IOException:" + ex.Message +" tree_clicker");
                    }   
                }

            }
        }
    }
}
