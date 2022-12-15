using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTLA.DTO
{
    class CBBItems
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
