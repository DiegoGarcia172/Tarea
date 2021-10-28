using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Variable
    {
        private string nombre;
        private string Matricula;

        public String matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Variable()
        {
          nombre=""; 
          Matricula="";

        }

        public override string ToString()
        {
            return nombre + "" + Matricula;  
        }






    }
}
