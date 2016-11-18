using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossPassaRegua
{
    public class CalculadoraService
    {
        public virtual double CalculaIndividual(double total, int pessoas, bool dezPorcento = false)
        {
            if (pessoas == 0)
                return 0;
            else
                return (total / pessoas) * (dezPorcento ? 1.1 : 1);
        }
    }
}
