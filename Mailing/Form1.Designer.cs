namespace Mailing
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bs_mails = new System.Windows.Forms.BindingSource(this.components);
            this.p_buscador = new System.Windows.Forms.Panel();
            this.txt_asunto = new System.Windows.Forms.TextBox();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_prueba = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_adjuntar = new System.Windows.Forms.TextBox();
            this.btn_adjuntar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.cms_formato = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCambiarLugar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTarjetaDeRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parrafoGrandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.p_der = new System.Windows.Forms.Panel();
            this.btn_todos = new System.Windows.Forms.Button();
            this.dgrid_objetos = new System.Windows.Forms.DataGridView();
            this.Incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_mails)).BeginInit();
            this.p_buscador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cms_formato.SuspendLayout();
            this.p_der.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).BeginInit();
            this.SuspendLayout();
            // 
            // p_buscador
            // 
            this.p_buscador.Controls.Add(this.txt_asunto);
            this.p_buscador.Controls.Add(this.lbl_busqueda);
            this.p_buscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_buscador.Location = new System.Drawing.Point(0, 0);
            this.p_buscador.Name = "p_buscador";
            this.p_buscador.Padding = new System.Windows.Forms.Padding(10);
            this.p_buscador.Size = new System.Drawing.Size(593, 48);
            this.p_buscador.TabIndex = 43;
            // 
            // txt_asunto
            // 
            this.txt_asunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_asunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_asunto.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asunto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_asunto.Location = new System.Drawing.Point(91, 10);
            this.txt_asunto.MaxLength = 100;
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(492, 30);
            this.txt_asunto.TabIndex = 38;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;
            this.lbl_busqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_busqueda.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_busqueda.Location = new System.Drawing.Point(10, 10);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(81, 28);
            this.lbl_busqueda.TabIndex = 39;
            this.lbl_busqueda.Text = "Asunto: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_prueba);
            this.panel1.Controls.Add(this.btn_datos);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.panel1.Size = new System.Drawing.Size(593, 48);
            this.panel1.TabIndex = 44;
            // 
            // btn_prueba
            // 
            this.btn_prueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btn_prueba.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_prueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prueba.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prueba.ForeColor = System.Drawing.Color.White;
            this.btn_prueba.Location = new System.Drawing.Point(74, 5);
            this.btn_prueba.Name = "btn_prueba";
            this.btn_prueba.Size = new System.Drawing.Size(127, 38);
            this.btn_prueba.TabIndex = 7;
            this.btn_prueba.Text = "Mail Prueba";
            this.btn_prueba.UseVisualStyleBackColor = false;
            this.btn_prueba.Click += new System.EventHandler(this.btn_prueba_Click);
            // 
            // btn_datos
            // 
            this.btn_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btn_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datos.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos.ForeColor = System.Drawing.Color.White;
            this.btn_datos.Location = new System.Drawing.Point(5, 5);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(69, 38);
            this.btn_datos.TabIndex = 6;
            this.btn_datos.Text = "Datos";
            this.btn_datos.UseVisualStyleBackColor = false;
            this.btn_datos.Click += new System.EventHandler(this.btn_datos_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btn_agregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(469, 5);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(114, 38);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Enviar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_adjuntar);
            this.panel3.Controls.Add(this.btn_adjuntar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 358);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(593, 52);
            this.panel3.TabIndex = 46;
            // 
            // txt_adjuntar
            // 
            this.txt_adjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adjuntar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_adjuntar.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adjuntar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_adjuntar.Location = new System.Drawing.Point(104, 10);
            this.txt_adjuntar.MaxLength = 100;
            this.txt_adjuntar.Name = "txt_adjuntar";
            this.txt_adjuntar.Size = new System.Drawing.Size(439, 30);
            this.txt_adjuntar.TabIndex = 41;
            // 
            // btn_adjuntar
            // 
            this.btn_adjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btn_adjuntar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_adjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adjuntar.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adjuntar.ForeColor = System.Drawing.Color.White;
            this.btn_adjuntar.Location = new System.Drawing.Point(543, 10);
            this.btn_adjuntar.Name = "btn_adjuntar";
            this.btn_adjuntar.Size = new System.Drawing.Size(40, 32);
            this.btn_adjuntar.TabIndex = 40;
            this.btn_adjuntar.Text = "...";
            this.btn_adjuntar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_adjuntar.UseVisualStyleBackColor = false;
            this.btn_adjuntar.Click += new System.EventHandler(this.btn_adjuntar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Adjuntar :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_mensaje);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(593, 310);
            this.panel2.TabIndex = 47;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mensaje.ContextMenuStrip = this.cms_formato;
            this.txt_mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mensaje.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mensaje.Location = new System.Drawing.Point(10, 38);
            this.txt_mensaje.MaxLength = 80000;
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(573, 262);
            this.txt_mensaje.TabIndex = 38;
            this.txt_mensaje.TextChanged += new System.EventHandler(this.txt_mensaje_TextChanged);
            // 
            // cms_formato
            // 
            this.cms_formato.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cms_formato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCambiarLugar,
            this.cmsTarjetaDeRegistro,
            this.imagenToolStripMenuItem,
            this.vinculoToolStripMenuItem,
            this.parrafoGrandeToolStripMenuItem});
            this.cms_formato.Name = "cms_opciones";
            this.cms_formato.ShowImageMargin = false;
            this.cms_formato.Size = new System.Drawing.Size(222, 134);
            // 
            // cmsCambiarLugar
            // 
            this.cmsCambiarLugar.Name = "cmsCambiarLugar";
            this.cmsCambiarLugar.Size = new System.Drawing.Size(221, 26);
            this.cmsCambiarLugar.Tag = "#<1>";
            this.cmsCambiarLugar.Text = "Estilo titulo";
            this.cmsCambiarLugar.Click += new System.EventHandler(this.cmsCambiarLugar_Click);
            // 
            // cmsTarjetaDeRegistro
            // 
            this.cmsTarjetaDeRegistro.Name = "cmsTarjetaDeRegistro";
            this.cmsTarjetaDeRegistro.Size = new System.Drawing.Size(221, 26);
            this.cmsTarjetaDeRegistro.Tag = "#<2>";
            this.cmsTarjetaDeRegistro.Text = "Estilo resaltado amarillo";
            this.cmsTarjetaDeRegistro.Click += new System.EventHandler(this.cmsCambiarLugar_Click);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.imagenToolStripMenuItem.Tag = "#<3>";
            this.imagenToolStripMenuItem.Text = "Imagen";
            this.imagenToolStripMenuItem.Click += new System.EventHandler(this.cmsCambiarLugar_Click);
            // 
            // vinculoToolStripMenuItem
            // 
            this.vinculoToolStripMenuItem.Name = "vinculoToolStripMenuItem";
            this.vinculoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.vinculoToolStripMenuItem.Tag = "#<4>";
            this.vinculoToolStripMenuItem.Text = "Enlace";
            this.vinculoToolStripMenuItem.Click += new System.EventHandler(this.cmsCambiarLugar_Click);
            // 
            // parrafoGrandeToolStripMenuItem
            // 
            this.parrafoGrandeToolStripMenuItem.Name = "parrafoGrandeToolStripMenuItem";
            this.parrafoGrandeToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.parrafoGrandeToolStripMenuItem.Tag = "#<5>";
            this.parrafoGrandeToolStripMenuItem.Text = "Parrafo grande";
            this.parrafoGrandeToolStripMenuItem.Click += new System.EventHandler(this.cmsCambiarLugar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mensaje: ";
            // 
            // p_der
            // 
            this.p_der.Controls.Add(this.panel2);
            this.p_der.Controls.Add(this.panel3);
            this.p_der.Controls.Add(this.panel1);
            this.p_der.Controls.Add(this.p_buscador);
            this.p_der.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_der.Location = new System.Drawing.Point(361, 0);
            this.p_der.Name = "p_der";
            this.p_der.Size = new System.Drawing.Size(593, 458);
            this.p_der.TabIndex = 48;
            // 
            // btn_todos
            // 
            this.btn_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btn_todos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todos.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.ForeColor = System.Drawing.Color.White;
            this.btn_todos.Location = new System.Drawing.Point(0, 420);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(361, 38);
            this.btn_todos.TabIndex = 217;
            this.btn_todos.Text = "Select todos";
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // dgrid_objetos
            // 
            this.dgrid_objetos.AllowUserToAddRows = false;
            this.dgrid_objetos.AllowUserToDeleteRows = false;
            this.dgrid_objetos.AllowUserToResizeRows = false;
            this.dgrid_objetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_objetos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_objetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_objetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_objetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_objetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_objetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Incluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_objetos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_objetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_objetos.Location = new System.Drawing.Point(0, 0);
            this.dgrid_objetos.Name = "dgrid_objetos";
            this.dgrid_objetos.RowHeadersVisible = false;
            this.dgrid_objetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_objetos.Size = new System.Drawing.Size(361, 420);
            this.dgrid_objetos.TabIndex = 218;
            // 
            // Incluir
            // 
            this.Incluir.HeaderText = "Alta";
            this.Incluir.IndeterminateValue = "True";
            this.Incluir.Name = "Incluir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 458);
            this.Controls.Add(this.dgrid_objetos);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.p_der);
            this.Name = "Form1";
            this.Text = "Sistema simple de mailing masivo con tiempo de envio 10 mails cada 4 minutos";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bs_mails)).EndInit();
            this.p_buscador.ResumeLayout(false);
            this.p_buscador.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cms_formato.ResumeLayout(false);
            this.p_der.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_mails;
        protected System.Windows.Forms.Panel p_buscador;
        protected System.Windows.Forms.TextBox txt_asunto;
        protected System.Windows.Forms.Label lbl_busqueda;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.TextBox txt_mensaje;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        protected System.Windows.Forms.TextBox txt_adjuntar;
        private System.Windows.Forms.Button btn_adjuntar;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Button btn_prueba;
        private System.Windows.Forms.Panel p_der;
        private System.Windows.Forms.ContextMenuStrip cms_formato;
        private System.Windows.Forms.ToolStripMenuItem cmsCambiarLugar;
        private System.Windows.Forms.ToolStripMenuItem cmsTarjetaDeRegistro;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parrafoGrandeToolStripMenuItem;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.DataGridView dgrid_objetos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluir;
    }
}

