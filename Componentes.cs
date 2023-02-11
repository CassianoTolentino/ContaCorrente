using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Componentes
    {
        protected static string GeradorIdConta()
        {
            var chars = "24C53574A81";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }
    }
}
