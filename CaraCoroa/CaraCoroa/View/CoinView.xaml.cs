using CaraCoroa.Models;
using CaraCoroa.ViewModels;

namespace CaraCoroa.View;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
        escolha.SelectedIndex = 0;
		BindingContext = new CoinViewModels();
    }

	private void CoinFlipButton_Clicked(object sender, EventArgs e)
	{
		string ladoSelecionado = escolha.SelectedItem.ToString();
		Coin coin = new Coin();
		string resultado = coin.Jogar(ladoSelecionado);
        ResulLabel.Text = resultado;
        cara.Source = $"{coin.Lado}.png";
	} 
}