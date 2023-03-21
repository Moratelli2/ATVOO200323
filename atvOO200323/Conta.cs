using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvOO200323
{
     abstract class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int MyProperty { get; set; }
        public TipoMoeda TipoMoeda { get; set; }

        public decimal Saldo { get; set; }

        public TipoConta TipoConta { get; set; }
    }
}
