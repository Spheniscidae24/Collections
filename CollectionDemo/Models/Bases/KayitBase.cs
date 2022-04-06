using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.Models.Bases
{
    public abstract class KayitBase
    {
        public int Id { get; set; }

        protected KayitBase()
        {
            Id = -1;
        }

        protected KayitBase(int id)
        {
            Id = id;
        }
    }
}
