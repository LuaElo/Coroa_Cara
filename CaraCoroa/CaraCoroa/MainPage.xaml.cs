namespace CaraCoroa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void rolarButton_Clicked(object sender, EventArgs e)
        {
            // Joga a moeda 0 é coroa e 1 é cara
            //Jogar moeda
            // Primero desafio utilizar uma Enumeração para cara ou coroa
            int coin = new Random().Next(2);
            if (coin == 1)
            {

                cara.Source = "coroa.jpeg";
            }
            if (coin == 0)
            {
                cara.Source = "cara.jpeg";
            }
            string selectedSide = Convert.ToString(escolha.SelectedItem);

            if (coin == 0 && selectedSide == "Coroa"){
                ResulLabel.Text = "Parabens, você ganhou";
            }
            if (coin == 1 && selectedSide == "Coroa")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }

            if (coin == 0 && selectedSide == "Cara")
            {
                ResulLabel.Text = "Parabens, você ganhou";
            }
            if (coin == 1 && selectedSide == "Cara")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }


            // Verificar o que o usuario selecionou

            // Se o usuario selecionou alguma coisa, exibe uma mesagem de "vitoria"
            //Se o usuario selecionou alguma coisa errada, exibe uma mesagem de "derrota"
        }
    }

}
