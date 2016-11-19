using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossPassaRegua.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private double _valorIndividual;

        public double ValorIndividual
        {
            get { return _valorIndividual; }
            set { SetProperty(ref _valorIndividual, value); }
        }


        public void Init(double valorIndividual)
        {
            ValorIndividual = valorIndividual;
        } 
    }
}
