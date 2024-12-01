namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        // Variável que controla a vez do jogador (X ou O)
        string vez = "X";

        // Construtor da classe MainPage
        public MainPage()
        {
            InitializeComponent(); // Inicializa os componentes da interface definidos no XAML
        }

        // Método que é executado quando um dos botões é clicado
        private void Button_Clicked(object sender, EventArgs e)
        {
            // Captura o botão que foi clicado
            Button btn = (Button)sender;

            // Desativa o botão para impedir que ele seja clicado novamente
            btn.IsEnabled = false;

            // Verifica de quem é a vez (X ou O) e marca no botão
            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O"; // Troca a vez para O
            }
            else
            {
                btn.Text = "O";
                vez = "X"; // Troca a vez para X
            }

            // Verifica se o jogador X ganhou em alguma das combinações possíveis (linhas, colunas ou diagonais)
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X" ||
                btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X" ||
                btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X" ||
                btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X" ||
                btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X" ||
                btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X" ||
                btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X" ||
                btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK"); // Exibe mensagem informando que o X ganhou
                Zerar(); // Reinicia o jogo
                return;
            }

            // Verifica se o jogador O ganhou em alguma das combinações possíveis
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O" ||
                btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O" ||
                btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O" ||
                btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O" ||
                btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O" ||
                btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O" ||
                btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O" ||
                btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK"); // Exibe mensagem informando que o O ganhou
                Zerar(); // Reinicia o jogo
                return;
            }

            // Verifica se todos os botões foram preenchidos (deu velha)
            if (btn10.IsEnabled == false && btn11.IsEnabled == false && btn12.IsEnabled == false &&
                btn20.IsEnabled == false && btn21.IsEnabled == false && btn22.IsEnabled == false &&
                btn30.IsEnabled == false && btn31.IsEnabled == false && btn32.IsEnabled == false)
            {
                DisplayAlert("Deu Velha!", "Ninguém ganhou!", "OK"); // Exibe mensagem de empate (deu velha)
                Zerar(); // Reinicia o jogo
            }
        }

        // Método para reiniciar o jogo (zera todos os botões)
        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X"; // Reseta para o jogador X começar novamente
        }
    }
}
