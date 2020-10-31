namespace Proyecto_Software_2
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.BtDesconectar = new System.Windows.Forms.Button();
            this.BtConectar = new System.Windows.Forms.Button();
            this.LbPassword = new System.Windows.Forms.Label();
            this.TxUsuario = new System.Windows.Forms.TextBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tree = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnejecutarsql = new System.Windows.Forms.Button();
            this.btnlimpiarsql = new System.Windows.Forms.Button();
            this.txtsql = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.TxPassword);
            this.panel1.Controls.Add(this.BtDesconectar);
            this.panel1.Controls.Add(this.BtConectar);
            this.panel1.Controls.Add(this.LbPassword);
            this.panel1.Controls.Add(this.TxUsuario);
            this.panel1.Controls.Add(this.LbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 68);
            this.panel1.TabIndex = 0;
            // 
            // TxPassword
            // 
            this.TxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPassword.Location = new System.Drawing.Point(410, 25);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.Size = new System.Drawing.Size(169, 26);
            this.TxPassword.TabIndex = 1;
            this.TxPassword.UseSystemPasswordChar = true;
            this.TxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxPassword_KeyPress);
            // 
            // BtDesconectar
            // 
            this.BtDesconectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtDesconectar.BackgroundImage")));
            this.BtDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDesconectar.FlatAppearance.BorderSize = 0;
            this.BtDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDesconectar.Location = new System.Drawing.Point(619, 21);
            this.BtDesconectar.Name = "BtDesconectar";
            this.BtDesconectar.Size = new System.Drawing.Size(162, 30);
            this.BtDesconectar.TabIndex = 6;
            this.BtDesconectar.UseVisualStyleBackColor = true;
            this.BtDesconectar.Visible = false;
            this.BtDesconectar.Click += new System.EventHandler(this.BtDesconectar_Click);
            // 
            // BtConectar
            // 
            this.BtConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtConectar.BackgroundImage")));
            this.BtConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtConectar.FlatAppearance.BorderSize = 0;
            this.BtConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConectar.Location = new System.Drawing.Point(619, 21);
            this.BtConectar.Name = "BtConectar";
            this.BtConectar.Size = new System.Drawing.Size(161, 30);
            this.BtConectar.TabIndex = 2;
            this.BtConectar.UseVisualStyleBackColor = false;
            this.BtConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(356, 25);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(48, 20);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Clave";
            // 
            // TxUsuario
            // 
            this.TxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUsuario.Location = new System.Drawing.Point(80, 25);
            this.TxUsuario.Name = "TxUsuario";
            this.TxUsuario.Size = new System.Drawing.Size(250, 26);
            this.TxUsuario.TabIndex = 0;
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(10, 27);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(64, 20);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectar usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 596);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.tree);
            this.panel5.Location = new System.Drawing.Point(14, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(485, 537);
            this.panel5.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree.Indent = 22;
            this.tree.ItemHeight = 19;
            this.tree.Location = new System.Drawing.Point(-1, -1);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(484, 526);
            this.tree.TabIndex = 0;
            this.tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tree_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.btnejecutarsql);
            this.panel3.Controls.Add(this.btnlimpiarsql);
            this.panel3.Controls.Add(this.txtsql);
            this.panel3.Location = new System.Drawing.Point(558, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 201);
            this.panel3.TabIndex = 2;
            // 
            // btnejecutarsql
            // 
            this.btnejecutarsql.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnejecutarsql.BackgroundImage")));
            this.btnejecutarsql.FlatAppearance.BorderSize = 0;
            this.btnejecutarsql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnejecutarsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejecutarsql.Location = new System.Drawing.Point(495, 171);
            this.btnejecutarsql.Name = "btnejecutarsql";
            this.btnejecutarsql.Size = new System.Drawing.Size(128, 26);
            this.btnejecutarsql.TabIndex = 9;
            this.btnejecutarsql.UseVisualStyleBackColor = true;
            this.btnejecutarsql.Click += new System.EventHandler(this.btnejecutarsql_Click);
            // 
            // btnlimpiarsql
            // 
            this.btnlimpiarsql.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiarsql.BackgroundImage")));
            this.btnlimpiarsql.FlatAppearance.BorderSize = 0;
            this.btnlimpiarsql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarsql.Location = new System.Drawing.Point(629, 171);
            this.btnlimpiarsql.Name = "btnlimpiarsql";
            this.btnlimpiarsql.Size = new System.Drawing.Size(128, 26);
            this.btnlimpiarsql.TabIndex = 7;
            this.btnlimpiarsql.UseVisualStyleBackColor = true;
            this.btnlimpiarsql.Click += new System.EventHandler(this.btnlimpiarsql_Click);
            // 
            // txtsql
            // 
            this.txtsql.BackColor = System.Drawing.Color.White;
            this.txtsql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsql.Location = new System.Drawing.Point(10, 31);
            this.txtsql.Name = "txtsql";
            this.txtsql.Size = new System.Drawing.Size(747, 134);
            this.txtsql.TabIndex = 0;
            this.txtsql.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(558, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 375);
            this.panel4.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "Null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(10, 44);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(747, 320);
            this.dgv.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre del objeto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Objetos de la Base de Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(1007, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 92);
            this.panel6.TabIndex = 9;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación: Consulta y Administración de una base de datos en Oracle";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TxUsuario;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Button BtDesconectar;
        private System.Windows.Forms.Button BtConectar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnejecutarsql;
        private System.Windows.Forms.Button btnlimpiarsql;
        private System.Windows.Forms.RichTextBox txtsql;
        private System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Panel panel6;
    }
}

