using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    public class cLocalidad
    {
    //ATRIBUTOS
        int _id;
        string _nombre;
        //PROPIEDADES
        public override string ToString()
        {
            return Nombre;
        }
        
        public string Nombre
        {
            set
            {
                if (value == "")
                    throw new Exception("La localidad no puede ser vacía");
                else
                    _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }
        //CONSTRUCTORES

        public cLocalidad(int id, string nombre)
        {
            ID (id);
            Nombre = nombre;
                    }
        public cLocalidad(string nombre)
        {
            Nombre = nombre;
            ;
        }
        //METODOS
        public int ID()
        {
                return _id;   
        }
        public void ID(int id)
        {
            _id = id;
        }


    }
}
