using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class MusteriGeneric<T>
    {
        public T Id { get;  set; }
        public T MusteriNumarasi { get; set; }
        public string TcKİmlikNumarasi { get; set; }
        public string Isım { get;  set; }
        public string Soyisim { get;  set; }
        public DateTime DogumTarih { get;  set; }



        public T MusteriNumarasiAl()
        {
            return MusteriNumarasi;
        }
    }
}
