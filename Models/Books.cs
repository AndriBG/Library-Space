using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Space.Models
{
    public class Books
    {
        public int idlibro { get; set; }
        public string nombre { get; set; }
        public int autor { get; set; }
        public string genero { get; set; }
        public decimal precio { get; set; }
        public string editorial { get; set; }
        public int Cant_disponible { get; set; }
    }
}
