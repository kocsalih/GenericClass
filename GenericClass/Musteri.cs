using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Musteri
    {
        public int Id { get; set; }
        public Guid MusteriNumara { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DogumTarih { get; set; }
    }
}
