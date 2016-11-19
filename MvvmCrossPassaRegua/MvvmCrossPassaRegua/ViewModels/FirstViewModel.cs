using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;

namespace MvvmCrossPassaRegua.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private readonly CalculadoraService _calculadoraService;

        public FirstViewModel(CalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        public override void Start()
        {
            TotalPessoas = 2;
            ValorIndividual = 0;
        }

        private double _valorTotal;

        public double ValorTotal
        {
            get { return _valorTotal; }
            set { SetProperty(ref _valorTotal, value); Recalcula(); }
        }

        private int _totalPessoas;

        public int TotalPessoas
        {
            get { return _totalPessoas; }
            set { SetProperty(ref _totalPessoas, value); Recalcula(); }
        }

        private double _valorIndividual;

        public double ValorIndividual
        {
            get { return _valorIndividual; }
            set { SetProperty(ref _valorIndividual, value); }
        }

        private void Recalcula()
        {
            ValorIndividual = Math.Round(_calculadoraService.CalculaIndividual(ValorTotal, TotalPessoas), 2);
        }

        public ICommand GoCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SecondViewModel>(new { valorIndividual = ValorIndividual }));
            }
        }
    }
}
