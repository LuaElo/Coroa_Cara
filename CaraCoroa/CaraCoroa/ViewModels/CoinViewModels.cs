using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaraCoroa.Models;
using System.Windows.Input;

namespace CaraCoroa.ViewModels
{
    internal partial class CoinViewModels : ObservableObject
    {
        // A logica que une o rolar dado e o "exibr" na tela

        [ObservableProperty]
        private string _lado;

        [ObservableProperty]
        private string _ladoEscolhido;

        [ObservableProperty]
        private string _resultado;


       public CoinViewModels() {
            JogarCommand = new Command(Jogar);
        }

        public ICommand JogarCommand { get; }

        public void Jogar() {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
        }
    }
}
