using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    public class cEmail
    {
        string _mail;
        string _nombre;
        string _nombrePersona;

        public string NombrePersona
        {
            get { return _nombrePersona; }
            set { _nombrePersona = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        cLocalidad _localidad;

        public cLocalidad Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public override string ToString()
        {
            return _mail;
        }
        public cEmail(string mail, string nombre,cLocalidad localidad,string nombrePersona)
        {
            _mail = mail;
            _localidad = localidad;
            _nombre = nombre;
            _nombrePersona = nombrePersona;
        }
    }
}
