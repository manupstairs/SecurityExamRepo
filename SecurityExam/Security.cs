using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityExam
{
    public class Security
    {
        public string InstrumentId { get; set; }

        public override string ToString()
        {
            return $"InstrumentId:{InstrumentId},   HashCode:{GetHashCode()}";
        }
    }
}
