using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericRepository<T> where T:class
    {
        public GenericRepository()
        {
            //context: EF DBfirst
        }

        public virtual List<T> Getir()
        {

            return null;

        }

        public virtual void YeniKayitEkle(T data)
        {
            //bize gelen T tipi içerisindeki bilgiyi T Tipinin işaret etmiş olduğu tabloya datayı ekleriz
        }
    }
}
