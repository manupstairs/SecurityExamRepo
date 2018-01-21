using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityExam
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 10;
            var random = new Random();
            var securities = new Security[count];

            for (int i = 0; i < count; i++)
            {
                var id = random.Next(count);
                securities[i] = new Security { InstrumentId = id.ToString() };
            }

            var securityRepository = new SecurityRepository(securities);

            var results = securities.Select(s=> s.InstrumentId).Distinct()
                .SelectMany(id => securityRepository.GetSecurities(id),(id, result) => result)
                .OrderBy(s => s.InstrumentId);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
