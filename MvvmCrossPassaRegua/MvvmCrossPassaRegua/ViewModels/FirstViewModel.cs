using MvvmCross.Core.ViewModels;
using System;

namespace MvvmCrossPassaRegua.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private CalculadoraService _calculadoraService;

        public FirstViewModel(CalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        public override void Start()
        {
            TotalPessoas = 2;

            base.Start();
        }

        private int _totalPessoas;

        public int TotalPessoas
        {
            get { return _totalPessoas; }
            set { SetProperty (ref _totalPessoas, value); Recalcular(); }
        }

        private double _valorTotal;

        public double ValorTotal
        {
            get { return _valorTotal; }
            set { SetProperty(ref _valorTotal, value); Recalcular(); }
        }

        private double _valorIndividual;

        public double ValorIndividual
        {
            get { return _valorIndividual; }
            set { SetProperty(ref _valorIndividual, value); }
        }

        private void Recalcular()
        {
            ValorIndividual = Math.Round(_calculadoraService.CalculaIndividual(ValorTotal, TotalPessoas), 2);
        }
    }
}
