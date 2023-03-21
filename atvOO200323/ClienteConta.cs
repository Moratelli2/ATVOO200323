using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvOO200323
{
    class ClienteConta
    {
        public Cliente Cliente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }

        public ContaPoupanca ContaPoupanca { get; set; }

        public DateTime Data { get; set; }
    }
}
