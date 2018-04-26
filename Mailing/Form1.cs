using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace Mailing
{
    public partial class Form1 : Form
    {
        Excel.Application oXLEmisor;
        Excel._Workbook oWBEmisor;
        Excel._Worksheet oSheetEmisor;
        List<cEmail> _Emails = new List<cEmail>();
        cMailsReceptores _receptores = new cMailsReceptores();
        cMail mail = new cMail();
        public cMailsReceptores Receptores
        {
            get { return _receptores; }
            set { _receptores = value; }
        }
        public string Asunto()
        {
            return txt_asunto.Text;
        }
        public string Mensaje()
        {
            return txt_mensaje.Text;
        }
        public string Adjuntar()
        {
            return txt_adjuntar.Text; 
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void ActualizarGrilla()
        {

            dgrid_objetos.DataSource = bs_mails;
            for (int x = 1; x < dgrid_objetos.Columns.Count; x++)
                dgrid_objetos.Columns[x].ReadOnly = true;
            foreach (DataGridViewRow DR in dgrid_objetos.Rows)
            {
                DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)DR.Cells[0];
                celdaCheck.Value = false;
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            _receptores.Mails.Clear();
            foreach (DataGridViewRow DR in dgrid_objetos.Rows)
            {

                DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)DR.Cells[0];
                if ((Boolean)celdaCheck.Value)
                    _receptores.Mails.Add((cEmail)DR.DataBoundItem);
            }
            frn_abm frm = new frn_abm(this);
            frm.Show();
            
            string mensaje=txt_mensaje.Text+"\n";
            foreach(cEmail aux in _receptores.Mails)
                mensaje+=aux.ToString();
            mail.EnviarMail(new cEmail("facu.232@gmail.com", "", null, ""), "Mail enviado-" + txt_asunto.Text, mensaje, Adjuntar(), false);
        }
        void pasarDatos()
        {
            try
            {
                OpenFileDialog fichero = new OpenFileDialog();
                fichero.Title = "Seleccione base de datos de mails";
                fichero.Filter = "Excel Worksheets 2007(*.xlsx)|*.xlsx|Excel Worksheets 2003(*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    oXLEmisor = new Excel.Application();
                    oWBEmisor = (Excel._Workbook)(oXLEmisor.Workbooks.Open(fichero.FileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value));
                    oSheetEmisor = (Excel._Worksheet)oWBEmisor.ActiveSheet;

                    string line;
                    string[] PrimerSplit;
                    string[] SegundoSplit;
                    string nombre = "";
                    string direccion = "";
                    string localidad = "";
                    // Read the file and display it line by line.  
                    System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + "\\google.txt");
                    file.ReadLine();
                    int fila = 2;

                    while ((line = file.ReadLine()) != null)
                    {
                        PrimerSplit = line.Split('*');
                        direccion = "";
                        nombre = (PrimerSplit[0].Split(','))[0];
                        SegundoSplit = PrimerSplit[1].Split(',');
                        localidad = SegundoSplit[0].Replace(" My Contacts ::: ", "");
                        localidad = localidad.Replace("Hoteles ", "");
                        foreach (string mail in SegundoSplit)
                            if (mail.Contains('@'))
                                direccion = mail;
                        if (PrimerSplit.Count() == 3)
                        {
                            SegundoSplit = PrimerSplit[2].Split(',');

                            foreach (string mail in SegundoSplit)
                            {
                                if (mail.Contains('@'))
                                {
                                    if (direccion != "")
                                        direccion += ",";
                                    direccion += mail;
                                }
                            }
                            oSheetEmisor.Cells[fila, 1] = direccion;
                            oSheetEmisor.Cells[fila, 2] = nombre;
                            oSheetEmisor.Cells[fila, 3] = localidad;
                            fila++;
                        }
                    }
                    file.Close();
                    oSheetEmisor = null;
                    fichero.Dispose();
                    oWBEmisor.Close();
                    oWBEmisor = null;
                    oXLEmisor.Quit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de lectura");
            }
        }


        private void btn_datos_Click(object sender, EventArgs e)
        {
            try{
                if (cConfiguracion.MailEmisor == "")
                {
                    OpenFileDialog fichero = new OpenFileDialog();
                    fichero.Title = "Seleccione base de datos de mails";
                    fichero.Filter = "Excel Worksheets 2007(*.xlsx)|*.xlsx|Excel Worksheets 2003(*.xls)|*.xls";
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        oXLEmisor = new Excel.Application();
                        oWBEmisor = (Excel._Workbook)(oXLEmisor.Workbooks.Open(fichero.FileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value));
                        oSheetEmisor = (Excel._Worksheet)oWBEmisor.ActiveSheet;
                        cConfiguracion.MailEmisor = Convert.ToString(oSheetEmisor.Cells[4, 5].Value);
                        cConfiguracion.Puerto = Convert.ToInt32(oSheetEmisor.Cells[2, 5].Value);
                        cConfiguracion.ServerHost = Convert.ToString(oSheetEmisor.Cells[3, 5].Value);
                        
                        cConfiguracion.Password = Convert.ToString(oSheetEmisor.Cells[5, 5].Value);
                        cConfiguracion.EnableSsl1 = Convert.ToBoolean(oSheetEmisor.Cells[6, 5].Value);
                        cConfiguracion.EsHTML = Convert.ToBoolean(oSheetEmisor.Cells[7, 5].Value);
                        cConfiguracion.NombreEmisor = Convert.ToString(oSheetEmisor.Cells[8, 5].Value);
                        int tope = 1000;
                        string mail = "";
                        string nombre = "";
                        string Localidad = "";
                        string nombrePersona="";
                        string hoy = "";
                        for (int x = 2; x < tope; x++)
                        {
                            hoy = Convert.ToString(oSheetEmisor.Cells[x, 5].Value);
                            if (oSheetEmisor.Cells[x, 1].Value != null )
                            {
                                if (hoy == "hoy")
                                {
                                    mail = Convert.ToString(oSheetEmisor.Cells[x, 1].Value);
                                    nombre = Convert.ToString(oSheetEmisor.Cells[x, 2].Value);
                                    Localidad = Convert.ToString(oSheetEmisor.Cells[x, 3].Value);
                                    nombrePersona = Convert.ToString(oSheetEmisor.Cells[x, 4].Value);
                                    if (mail == "")
                                        tope = x;
                                    else
                                        _Emails.Add(_receptores.AgregarMail(mail, nombre, Localidad, nombrePersona));
                                }
                            }
                            else
                                tope = x;

                        }
                        
                        bs_mails.ResetBindings(false);
                        bs_mails.DataSource = _Emails;
                        ActualizarGrilla();
                        oSheetEmisor = null;
                        fichero.Dispose();
                        oWBEmisor.Close();
                        oWBEmisor = null;
                        oXLEmisor.Quit();
                    }

                }
                else
                {
                    MessageBox.Show(cConfiguracion.Puerto + " " + cConfiguracion.ServerHost + " " + cConfiguracion.MailEmisor + " " + cConfiguracion.Password + " " + cConfiguracion.EnableSsl1 + " " + cConfiguracion.EsHTML);
                }
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                errorMessage += theException.StackTrace;
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void btn_adjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fichero = new OpenFileDialog();
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    txt_adjuntar.Text = fichero.FileName;
                }
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void btn_prueba_Click(object sender, EventArgs e)
        {
            try
            {
                cMail mailing = new cMail();
                mailing.EnviarMail(new cEmail("facu.232@gmail.com","Costa",null,"Facundo Narvaiz"), Asunto(), Mensaje(), Adjuntar(),true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmsCambiarLugar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = ((ToolStripMenuItem)sender);
            int cursor = txt_mensaje.SelectionStart;
            txt_mensaje.Text = txt_mensaje.Text.Insert(cursor, obj.Tag.ToString());
            txt_mensaje.SelectionStart = cursor + obj.Tag.ToString().Length;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
            btn_datos_Click(sender, e);
        }

        private void txt_mensaje_TextChanged(object sender, EventArgs e)
        {
            
                    }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow DR in dgrid_objetos.Rows)
            {
                DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)DR.Cells[0];
                celdaCheck.Value = !(bool)celdaCheck.Value;
            }
        }
    }
}
