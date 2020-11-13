using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarbecueChallengeDotNet.Models
{
    public class Participante
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool SeConvidado { get; set; }

        public bool SeVaiBeber { get; set; }
        public bool SeEmpregado { get; set; }

        public bool SeCancelado { get; set; }

    }
}
