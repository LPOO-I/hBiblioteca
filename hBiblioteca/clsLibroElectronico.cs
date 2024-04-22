using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hBiblioteca
{
    public class clsLibroElectronico : clsLibro
    {
        public int NumeroDescargas { get; set; }

        // Constructor de la clase derivada
        public clsLibroElectronico(string titulo, string autor, string isbn, string editorial, string clasificacion, double valor, string estado, int numeroDescargas)
            : base(titulo, autor, isbn, editorial, clasificacion, valor, estado)
        {
            NumeroDescargas = numeroDescargas;
        }
    }
} 
