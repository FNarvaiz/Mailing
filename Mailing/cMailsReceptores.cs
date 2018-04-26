using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    public class cMailsReceptores
    {
        List<cEmail> _Mails = new List<cEmail>();
        List<cLocalidad> _localidades= new List<cLocalidad>();

        public List<cEmail> Mails
        {
            get { return _Mails; }
            set { _Mails = value; }
        }
        int _indice = 0;
        public cLocalidad BuscarLocalidad(string localidad){
            foreach(cLocalidad aux in _localidades)
                if(aux.Nombre==localidad)
                    return aux;
            cLocalidad nueva= new cLocalidad(localidad);
            _localidades.Add(nueva);
            return nueva;
        }
        public int Indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        public string  SiguienteMail()
        {
            if(Indice<_Mails.Count){
                Indice++;
                return _Mails[Indice].ToString();
            }
            else return null;
        }

        public cEmail AgregarMail(string mail, string nombre, string localidad, string persona)
        {
            cEmail nueva= new cEmail( mail,nombre,BuscarLocalidad(localidad),persona);
            _Mails.Add(nueva);
            return nueva;
        }

    }
}
