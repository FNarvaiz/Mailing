using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Mailing
{
    public partial class frn_abm : Form
    {
        int _enviado = 0;
        string _mailsInvalidos = "";
        Form1 _form;
        
        
        public frn_abm(Form1 formulario)
        {
            InitializeComponent();
            _form = formulario;
        }


        private void frn_abm_Shown(object sender, EventArgs e)
        {
            EnviarMail(sender, e);
            t_tiempo.Enabled = true;
            pb_progreso.Maximum = _form.Receptores.Mails.Count;
        }
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void EnviarMail(object sender, EventArgs e)
        {
            if (_enviado < _form.Receptores.Mails.Count)
            {
                cMail mailing = new cMail();
                cEmail receptor = _form.Receptores.Mails[_enviado];
                decimal total = ((Convert.ToDecimal(_enviado) / Convert.ToDecimal(_form.Receptores.Mails.Count)) * 100);
                pb_progreso.Value = _enviado;
                pb_progreso.Update();
                lbl_arriba.Text = "Enviando mails a: " + receptor.Nombre + " - " + receptor.Mail;
                lbl_arriba.Text += "\nMails invalidos por ahora:" + _mailsInvalidos;
                lbl_abajo.Text = "Porcentaje=" + Math.Round(total) + "% Enviados: " + _enviado + " de " + _form.Receptores.Mails.Count;
                lbl_abajo.Refresh();
                lbl_arriba.Refresh();
                _enviado++;
                try
                {
                    mailing.EnviarMail(receptor, _form.Asunto(), _form.Mensaje(), _form.Adjuntar(), true);
                }
                catch (Exception ex)
                {

                    _enviado -= 10;
                    lbl_abajo.Text += "Porcentaje=" + Math.Round(total) + "% Enviados: " + _enviado + " de " + _form.Receptores.Mails.Count;
                    lbl_abajo.Text += "\nError al enviar los correos:" + ex.Message + "\nSe volvera a intentar en 1 minutos.";
                }
            }
            else
            {
                t_tiempo.Stop();
                Close();
            }
        }


    }
}
