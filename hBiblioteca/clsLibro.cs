using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hBiblioteca
{
    public class clsLibro
    {
        public string Titulo {  get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set;}
        public string Editorial { get; set; }
        public string Clasificacion { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }

        //Constructor de la clase base
        public clsLibro(string titulo, string autor, string isbn, string editorial, string clasificacion, double valor, string estado) 
        { 
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Editorial = editorial;
            Clasificacion = clasificacion;
            Valor = valor;
            Estado = estado;
        }
    }
}
