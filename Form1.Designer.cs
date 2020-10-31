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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxPassword);
            this.panel1.Controls.Add(this.BtDesconectar);
            this.panel1.Controls.Add(this.BtConectar);
            this.panel1.Controls.Add(this.LbPassword);
            this.panel1.Controls.Add(this.TxUsuario);
            this.panel1.Controls.Add(this.LbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 58);
            this.panel1.TabIndex = 0;
            // 
            // TxPassword
            // 
            this.TxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPassword.Location = new System.Drawing.Point(403, 25);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.Size = new System.Drawing.Size(125, 22);
            this.TxPassword.TabIndex = 7;
            this.TxPassword.UseSystemPasswordChar = true;
            // 
            // BtDesconectar
            // 
            this.BtDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDesconectar.Location = new System.Drawing.Point(607, 23);
            this.BtDesconectar.Name = "BtDesconectar";
            this.BtDesconectar.Size = new System.Drawing.Size(160, 26);
            this.BtDesconectar.TabIndex = 6;
            this.BtDesconectar.Text = "Desconectar";
            this.BtDesconectar.UseVisualStyleBackColor = true;
            this.BtDesconectar.Visible = false;
            this.BtDesconectar.Click += new System.EventHandler(this.BtDesconectar_Click);
            // 
            // BtConectar
            // 
            this.BtConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConectar.Location = new System.Drawing.Point(607, 23);
            this.BtConectar.Name = "BtConectar";
            this.BtConectar.Size = new System.Drawing.Size(160, 26);
            this.BtConectar.TabIndex = 5;
            this.BtConectar.Text = "Conectar";
            this.BtConectar.UseVisualStyleBackColor = true;
            this.BtConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(354, 28);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(43, 16);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Clave";
            // 
            // TxUsuario
            // 
            this.TxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUsuario.Location = new System.Drawing.Point(83, 25);
            this.TxUsuario.Name = "TxUsuario";
            this.TxUsuario.Size = new System.Drawing.Size(250, 22);
            this.TxUsuario.TabIndex = 2;
            this.TxUsuario.TextChanged += new System.EventHandler(this.TxUsuario_TextChanged);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(12, 27);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(55, 16);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectar usuario";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 578);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tree);
            this.panel5.Location = new System.Drawing.Point(14, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(485, 545);
            this.panel5.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(0, -1);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(484, 545);
            this.tree.TabIndex = 0;
            this.tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tree_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnejecutarsql);
            this.panel3.Controls.Add(this.btnlimpiarsql);
            this.panel3.Controls.Add(this.txtsql);
            this.panel3.Location = new System.Drawing.Point(558, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 183);
            this.panel3.TabIndex = 2;
            // 
            // btnejecutarsql
            // 
            this.btnejecutarsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejecutarsql.Location = new System.Drawing.Point(495, 152);
            this.btnejecutarsql.Name = "btnejecutarsql";
            this.btnejecutarsql.Size = new System.Drawing.Size(128, 26);
            this.btnejecutarsql.TabIndex = 9;
            this.btnejecutarsql.Text = "Ejecutar";
            this.btnejecutarsql.UseVisualStyleBackColor = true;
            this.btnejecutarsql.Click += new System.EventHandler(this.btnejecutarsql_Click);
            // 
            // btnlimpiarsql
            // 
            this.btnlimpiarsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarsql.Location = new System.Drawing.Point(629, 152);
            this.btnlimpiarsql.Name = "btnlimpiarsql";
            this.btnlimpiarsql.Size = new System.Drawing.Size(128, 26);
            this.btnlimpiarsql.TabIndex = 7;
            this.btnlimpiarsql.Text = "Limpiar";
            this.btnlimpiarsql.UseVisualStyleBackColor = true;
            this.btnlimpiarsql.Click += new System.EventHandler(this.btnlimpiarsql_Click);
            // 
            // txtsql
            // 
            this.txtsql.Location = new System.Drawing.Point(10, 12);
            this.txtsql.Name = "txtsql";
            this.txtsql.Size = new System.Drawing.Size(747, 134);
            this.txtsql.TabIndex = 0;
            this.txtsql.Text = "";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(558, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 375);
            this.panel4.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 44);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(747, 310);
            this.dgv.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre del objeto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Objetos de la Base de Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
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
    }
}

