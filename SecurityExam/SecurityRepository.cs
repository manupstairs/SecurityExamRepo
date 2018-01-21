using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityExam
{
    public class SecurityRepository
    {
        private Security[] Securities { get; set; }

        public SecurityRepository(Security[] securities)
        {
            Securities = securities;
        }

        public IEnumerable<Security> GetSecurities(string instrumentId)
        {
            foreach (var security in Securities.Where(s => s.InstrumentId == instrumentId))
            {
                yield return security;
            }
        }
    }
}
