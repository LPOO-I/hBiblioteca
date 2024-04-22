using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hBiblioteca
{
    public class clsLibroFisico : clsLibro
    {
        // Constructor de la clase derivada
        public clsLibroFisico(string titulo, string autor, string isbn, string editorial, string clasificacion, double valor, string estado)
            : base(titulo, autor, isbn, editorial, clasificacion, valor, estado)
        {
        }
    }
}
