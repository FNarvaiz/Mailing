using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
namespace Mailing
{

    public class cMail
    {
        MailMessage _email = new MailMessage();
        SmtpClient _client = new SmtpClient();
        public cMail()
        {
            
        }

        private void MandarMail(out System.Net.Mail.SmtpException exception)
        {
            try
            {
                _client.Send(_email);
                exception = null;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                exception = ex;
                //http://stackoverflow.com/questions/5983779/catch-exception-that-is-thrown-in-different-thread
            }
        }
        public void EnviarMail(cEmail receptor, string asunto, string msj, string urlAdjunto,bool enviarCopia)
        {
            //SmtpClient client = new SmtpClient(); // CLIENTE STMP
            try
            {
                msj = msj.Replace("NOMBREPERSONA", receptor.NombrePersona);
                msj = msj.Replace("NOMBRE", receptor.Nombre);
                String[] emails = receptor.Mail.Split(','); // ARREGLO DE RECEPTORES

                for (int i = 0; i < emails.Length; i++) // RECORRO EL AREREGLO
                {
                    _email.To.Add(emails[i]); // AGREGO CADA RECEPTOR
                }
                _client.UseDefaultCredentials = true;

                _email.From = new MailAddress(cConfiguracion.MailEmisor, cConfiguracion.NombreEmisor, System.Text.Encoding.UTF8); // DATOS DEL EMISOR
                _email.Subject = asunto; // ASUNTO DEL EMAIL
                _email.SubjectEncoding = System.Text.Encoding.UTF8; // TIPO ENCODING ASUNTO
                _email.Bcc.Add("marketing@costareservas.com");
                if (cConfiguracion.EsHTML)
                    _email.Body = FormularMensajeHTML(msj); // MENSAJE
                else
                    _email.Body = msj;
                _email.BodyEncoding = System.Text.Encoding.UTF8; // TIPO ENCODING MENSAJE
                _email.IsBodyHtml = cConfiguracion.EsHTML; // ES HTML ?    
                if (urlAdjunto != "")
                {
                    Attachment adjunto = new Attachment(urlAdjunto);
                    _email.Attachments.Add(adjunto);
                }
                _client.Credentials = new System.Net.NetworkCredential(cConfiguracion.MailEmisor,cConfiguracion.Password); // CREDENCIALES EMAIL (USUARIO/PASS)  
                _client.Host = cConfiguracion.ServerHost;
                _client.Port = cConfiguracion.Puerto;
                _client.EnableSsl = cConfiguracion.EnableSsl1;
                if (cConfiguracion.ServerHost == "smtp.gmail.com")
                {
                    _client.Port = cConfiguracion.Puerto;
                    _client.EnableSsl = true; //SSL
                }
                _client.Send(_email);//ENVIO EL MAIL
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                string saltosDeLinea = "No se a podido enviar el email- Mensaje: "+ex.Message  ;
                if (ex.InnerException != null)
                    saltosDeLinea += " ,mensaje interno:" + ex.InnerException.Message;
                /*decimal partes = saltosDeLinea.Length / 30;
                if (partes >= 1)
                {
                    int diferencia=0;
                    for(int x=1;x<partes;x++){
                        saltosDeLinea = saltosDeLinea.Insert(x * 30 + diferencia, "\n");
                        diferencia += 2;
                    }
                }*/
                throw new Exception(saltosDeLinea); //TIRO UNA EXCEPCION BIEN PIOLA.
            }
        }
        private int Index(int indexInicio,string texto){
            for(int x=indexInicio;x<texto.Length-1;x++){
                if (texto[x] == ' ')
                    return x;
            }
            return texto.Length-1;
        }
        private string Cuandrante(string contenido)
        {
            return "<div style='margin:3px 1px;border:1px solid #B39DDB;text-align: center; background-color:#EDE7F6;color:#000;padding: 5px; font-weight: normal;' >" + contenido + "</div>";
        }
        private string EstiloResaltadoHorrible(string texto)
        {
            return "<h2 style='margin:3px 2px;display: inline-block; background-color:#FFF70E;color:#000;padding: 2px;border-radius: 2px; font-weight: normal;font-size: 15pt;' >" + texto + "</h2>";
        }
        private string EstiloResaltado(string texto)
        {
            return "<h3 style='margin:1px 2px;display: inline-block; background-color:#B39DDB;color:#000;padding: 5px;border-radius: 2px; font-weight: normal;font-size: 12pt;' >" + texto + "</h3>";
        }
        private string EstiloCuadrilla(string texto)
        {
            return "<h3 style='margin:1px 0px;border:3px solid #B39DDB;color:#000;border-radius: 2px; font-weight: normal;font-size: 12pt;' >" + texto + "</h3>";
        }
        private string EstiloParrafo(string texto)
        {
            return "<h4 style='color:#000; font-weight: normal;font-size: 12pt;' >" + texto + "</h4>";
        }
        private string EstiloTitulo(string texto)
        {
            return "<h2 style='margin:6px 0px;color: #000;font-weight: normal;font-size: 17pt;' >" + texto + "</h2>";
        }
        private string PorDefecto(string texto)
        {
            return "<p>" + texto + "</p>";
        }
        private string Imagen(string vinculo)
        {
            return "<div style='width:100%; background-color:#A54686;'><img src='http://" + vinculo + "' /></div>";
        }
        private string Vinculo(string vinculo)
        {
            string text= vinculo.Replace("www.","");
            text=text.Replace(".com","");
            return "<a HREF=http://"+vinculo+">"+text+"</a>";
        }
        private string Firma()
         {
             return "<table width='100%' border='0' cellspacing='10' cellpadding='0' style='border-top-width:3px; border-top-style:solid; border-top-color:#c3ccd4;'>" +
  "<tr>" +
   "<td width='200' align='right' valign='top'><img src='http://www.costareservas.com/images/LogoChico.PNG' alt='Logo' hspace='5' /></td>  <td align='left' valign='top' style='padding:10px;'>" +
   " <p><font face='Arial, Helvetica, sans-serif' color='#1b232a' style='font-size:18px;'>Facundo Narvaiz</font><br />    <font face='Arial, Helvetica, sans-serif' color='#a6acaf' ><em  style='font-size:12px;'>CostaReservas</em></font><br />    <font face='Arial, Helvetica, sans-serif' style='font-size:12px'><strong><font color='#37424a'>+54 2291 467079</font></strong> ·  <a href='mailto:marketing@costareservas.com'>marketing@costareservas.com</a> </font><br />   </p>" +
    "<p><font face='Arial, Helvetica, sans-serif' color='#1b232a'  style='font-size:14px;'><i>'Tiempo en vida'</i></font><br />        <font face='Arial, Helvetica, sans-serif' color='#37424a' size='-1'> <a href='http://www.costareservas.com'>www.costareservas.com</a></font></p></td></tr></table>";
         }
        /*
         public void EnviarMailDeErrores(string receptores, string asunto, string msj, string urlAdjunto, cUsuario oUsuario)
         {

             String[] partes = msj.Split('\n');
             msj="";
             foreach (string parte in partes)
                 msj += EstiloCuadrilla(EstiloParrafo(parte));
             EnviarMail(receptores, asunto, msj, urlAdjunto, oUsuario);
         }
        */
        public string FormularMensajeHTML(string mensaje)
        {
            string msj = "";
            String[] partes = mensaje.Split('#');
            string texto = "";
            foreach (string parte in partes)
            {
                if (parte.Contains("<1>"))
                    msj += EstiloTitulo(parte.Replace("<1>", "")) + "</br>";
                else if (parte.Contains("<2>"))
                    msj += EstiloResaltadoHorrible(parte.Replace("<2>", "")) + "</br>";
                else if (parte.Contains("<3>"))
                    msj += Imagen(parte.Replace("<3>", "")) + "</br>";
                else if (parte.Contains("<4>"))
                    msj += Vinculo(parte.Replace("<4>", ""));
                else if (parte.Contains("<5>"))
                    msj += EstiloParrafo(parte.Replace("<5>", "") + "</br></br>");
                else
                    msj += PorDefecto(texto) + "</br>";
            }
            msj += Firma();
            return msj;
        }
                /*String[] partesDeParte = partes[0].Split('\n');
                 foreach (string parte in partesDeParte)
                     msj += EstiloTitulo(parte) + "</br>";

                
                 msj += FormaluarDatosReserva(oReserva);

                 msj += FormularPagosSenias(oReserva);
                

                 if (partes.Length == 2)
                 {

                     msj += EstiloParrafo(partes[1].Replace("\n", "<br>"));
                 }
                 else
                 {
                     msj += EstiloResaltadoHorrible(partes[1].Replace("\n", "<br>"));
                     msj += EstiloParrafo(partes[2].Replace("\n", "<br>"));
                 }
                     msj += Firma(oUsuDeEnvio, oReserva);
               
                 if(enviar)
                     EnviarMail(oReserva.Cliente.Mail(), _leyenda.Titulo, msj, "", oUsuDeEnvio);
                
        
             }
             return msj;
         }
         private string FormularPagosSenias(cReserva oReserva)
         {
             string msj = "";
             if (!oReserva.Estado.Cancelada)
             {
                 if (oReserva.Pagos() != null)
                 {
                     if (oReserva.Pagos().Count > 0)
                     {
                         if (oReserva.TotalPagos() > 0)
                         {
                             string contenidoseña = EstiloTitulo("Pagos realizados");
                             foreach (cPago aux in oReserva.Pagos())
                                 if (!(aux is cSenia))
                                     contenidoseña += EstiloCuadrilla("Fecha: " + aux.Fecha.ToShortDateString() + " | Importe: $" + Math.Round(aux.Importe));
                                 else if (!((cSenia)aux).Pendiente)
                                     contenidoseña += EstiloCuadrilla("Fecha: " + aux.Fecha.ToShortDateString() + " | Importe: $" + Math.Round(aux.Importe));
                              msj += Cuandrante(contenidoseña);
                         }
                         if (oReserva.SeniaPediente())
                         {

                             cSenia oSenia = (cSenia)oReserva.oSeniaPediente();
                             string contenidoseña = EstiloTitulo("Seña") + EstiloParrafo("Importe: $" + Math.Round(oSenia.Importe) + " Fecha de vencimiento:" + oSenia.Vencimiento.ToShortDateString());
                             if (oSenia.oContrato() != null)
                             {
                                 if (oSenia.FormaPago.EnviarDatos)
                                 {
                                     contenidoseña += EstiloTitulo("Datos cuenta bancaria");
                                     string sucursal = "";

                                     if (oSenia.oContrato().Cuenta.oSucursal().Numero != 0)
                                         sucursal = " | Suc:" + oSenia.oContrato().Cuenta.oSucursal().Numero;
                                     string cuit = "";
                                     if (oSenia.oContrato().Cuenta.CUIT_CUIL != "0")
                                         if (oSenia.oContrato().Cuenta.EsCuit())
                                             cuit = " | CUIT:" + oSenia.oContrato().Cuenta.CUIT_CUIL;
                                         else
                                             cuit = " | CUIL:" + oSenia.oContrato().Cuenta.CUIT_CUIL;

                                     contenidoseña += EstiloCuadrilla("Titular: " + oSenia.oContrato().Cuenta.Titular + " | Banco:" + oSenia.oContrato().Cuenta.oBanco().Nombre + sucursal + " | " + oSenia.oContrato().Cuenta.oTipoCuenta().Nombre + ": " + oSenia.oContrato().Cuenta.NroCuenta + " | CBU: " + oSenia.oContrato().Cuenta.CBU + cuit);
                                 }
                             }
                             msj += Cuandrante(contenidoseña);
                         }
                     }
                 }
             }
             return msj;
         }
         private string  FormaluarDatosReserva(cReserva oReserva){
             string msj= EstiloResaltado("DNI: " + oReserva.Cliente.DNI) +EstiloResaltado("Pasajero: " + oReserva.Cliente.Nombre) + EstiloResaltado("Tel/cel: " + oReserva.Cliente.Telefono() + "/" + oReserva.Cliente.Celular());
                 msj+= EstiloResaltado("Nro de reserva: " + oReserva.Nro )+ EstiloResaltado("Estado: " + oReserva.Estado.Nombre)+ EstiloTitulo("LEER ATENTAMENTE") ;
                 msj += EstiloResaltadoHorrible("CHECK-IN: " + oReserva.Desde.ToShortDateString() + "  " + cConfiguracion.HoraCheckIn + "hs - CHECK-OUT: " + oReserva.Hasta.ToShortDateString() + "  " + cConfiguracion.HoraCheckOut + "hs ");
                 string contenido="";
                 if (oReserva.EstadiasComplejas().Count > 0)
                 {
                     //contenido=EstiloTitulo("Unidades reservadas");
                     foreach (cEstadiaCompleja obj in oReserva.EstadiasComplejas())
                     {
                         string tipo;
                         if (obj.Lugar is cUnidadExterna) tipo = "Unidad: "+obj.Lugar.Nombre+" | Tipo: " + obj.Tipo.Nombre + " | Paquete: " + obj.Paquete.Nombre;
                         else
                             tipo = "Habitación: " + obj.Tipo.Nombre;
                         contenido += EstiloCuadrilla(tipo + " | Cant pasajeros: " + obj.Pax /*+ " | Importe: $" + Math.Round(obj.Importe));
                        
                     }
                 }
                
                
                 if(oReserva.Adicionales().Count>0){
                     bool _primero = false;
                     string adicionales = "Tiene: ";
                     foreach (cEstadia aux in oReserva.Adicionales())
                     {
                         if (_primero)
                         {
                             adicionales += ((cAdicional)aux.Lugar).Tipo().Descripcion;
                             _primero = false;
                         }
                         else
                             adicionales += " - " + ((cAdicional)aux.Lugar).Tipo().Descripcion;
                        
                     }
                    
                             contenido += EstiloParrafo(adicionales+".");
                   
                 }
                
                 contenido += EstiloParrafo("Total estadia: $" + Math.Round(oReserva.TotalEstadiasComplejas()));
                 if(oReserva.Comentarios!="")
                     contenido += EstiloParrafo("Comentarios: " + oReserva.Comentarios);
                 msj += Cuandrante(contenido);
                 return msj;
         }*/

    }
}
