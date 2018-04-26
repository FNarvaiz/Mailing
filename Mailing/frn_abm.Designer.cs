namespace Mailing
{
    partial class frn_abm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_izquierdo = new System.Windows.Forms.Panel();
            this.lbl_abajo = new System.Windows.Forms.Label();
            this.pb_progreso = new System.Windows.Forms.ProgressBar();
            this.lbl_arriba = new System.Windows.Forms.Label();
            this.dgrid_objetos = new System.Windows.Forms.DataGridView();
            this.t_tiempo = new System.Windows.Forms.Timer(this.components);
            this.p_izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).BeginInit();
            this.SuspendLayout();
            // 
            // p_izquierdo
            // 
            this.p_izquierdo.BackColor = System.Drawing.Color.CadetBlue;
            this.p_izquierdo.Controls.Add(this.lbl_abajo);
            this.p_izquierdo.Controls.Add(this.pb_progreso);
            this.p_izquierdo.Controls.Add(this.lbl_arriba);
            this.p_izquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_izquierdo.Location = new System.Drawing.Point(0, 0);
            this.p_izquierdo.Name = "p_izquierdo";
            this.p_izquierdo.Padding = new System.Windows.Forms.Padding(5);
            this.p_izquierdo.Size = new System.Drawing.Size(733, 337);
            this.p_izquierdo.TabIndex = 2;
            // 
            // lbl_abajo
            // 
            this.lbl_abajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_abajo.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_abajo.Location = new System.Drawing.Point(5, 250);
            this.lbl_abajo.Name = "lbl_abajo";
            this.lbl_abajo.Size = new System.Drawing.Size(723, 82);
            this.lbl_abajo.TabIndex = 45;
            this.lbl_abajo.Text = "Mensaje: ";
            this.lbl_abajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_progreso
            // 
            this.pb_progreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_progreso.Location = new System.Drawing.Point(5, 218);
            this.pb_progreso.Name = "pb_progreso";
            this.pb_progreso.Size = new System.Drawing.Size(723, 32);
            this.pb_progreso.TabIndex = 44;
            // 
            // lbl_arriba
            // 
            this.lbl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_arriba.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_arriba.Location = new System.Drawing.Point(5, 5);
            this.lbl_arriba.Name = "lbl_arriba";
            this.lbl_arriba.Size = new System.Drawing.Size(723, 213);
            this.lbl_arriba.TabIndex = 43;
            this.lbl_arriba.Text = "Mensaje: ";
            this.lbl_arriba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrid_objetos
            // 
            this.dgrid_objetos.Location = new System.Drawing.Point(0, 0);
            this.dgrid_objetos.Name = "dgrid_objetos";
            this.dgrid_objetos.Size = new System.Drawing.Size(240, 150);
            this.dgrid_objetos.TabIndex = 0;
            // 
            // t_tiempo
            // 
            this.t_tiempo.Interval = 10000;
            this.t_tiempo.Tick += new System.EventHandler(this.EnviarMail);
            // 
            // frn_abm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 337);
            this.Controls.Add(this.p_izquierdo);
            this.Name = "frn_abm";
            this.Text = "Progreso del mailing";
            this.Shown += new System.EventHandler(this.frn_abm_Shown);
            this.p_izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_izquierdo;
        protected System.Windows.Forms.DataGridView dgrid_objetos;
        private System.Windows.Forms.Timer t_tiempo;
        protected System.Windows.Forms.Label lbl_abajo;
        private System.Windows.Forms.ProgressBar pb_progreso;
        protected System.Windows.Forms.Label lbl_arriba;
    }
}