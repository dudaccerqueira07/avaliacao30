using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string escolhaComputador;
        int pontuacaoPc = 0;
        int pontuacaoVoce = 0;
        List<string> pedraPapelTesoura = new List<string>() { "Pedra", "Papel", "Tesoura" };
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnPedra_Click(object sender, RoutedEventArgs e)
        {
            EsconderFotos();
            var rnd = new Random();
            escolhaComputador = pedraPapelTesoura[rnd.Next(pedraPapelTesoura.Count)];
            if(escolhaComputador == "Pedra")
            {
                pedraPC.Visibility = Visibility.Visible;
                pedraVC.Visibility = Visibility.Visible;
                pontuacaoPc++;
                pontuacaoVoce++;
                Vencedor.Text = "Empate";
                ptsPc.Text = $"{pontuacaoPc}";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
            if (escolhaComputador == "Papel")
            {
                papelPC.Visibility = Visibility.Visible;
                pedraVC.Visibility = Visibility.Visible;
                pontuacaoPc++;
                Vencedor.Text = "Computador Venceu";
                ptsPc.Text = $"{pontuacaoPc}";
            }
            if (escolhaComputador == "Tesoura")
            {
                tesouraPC.Visibility = Visibility.Visible;
                pedraVC.Visibility = Visibility.Visible;
                pontuacaoVoce++;
                Vencedor.Text = "Você Venceu";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
        }

        private void btnPapel_Click(object sender, RoutedEventArgs e)
        {
            EsconderFotos();
            var rnd = new Random();
            escolhaComputador = pedraPapelTesoura[rnd.Next(pedraPapelTesoura.Count)];
            if (escolhaComputador == "Papel")
            {
                papelPC.Visibility = Visibility.Visible;
                papelVC.Visibility = Visibility.Visible;
                pontuacaoPc++;
                pontuacaoVoce++;
                Vencedor.Text = "Empate";
                ptsPc.Text = $"{pontuacaoPc}";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
            if (escolhaComputador == "Tesoura")
            {
                tesouraPC.Visibility = Visibility.Visible;
                papelVC.Visibility = Visibility.Visible;
                pontuacaoPc++;
                Vencedor.Text = "Computador Venceu";
                ptsPc.Text = $"{pontuacaoPc}";
            }
            if (escolhaComputador == "Pedra")
            {
                pedraPC.Visibility = Visibility.Visible;
                papelVC.Visibility = Visibility.Visible;
                pontuacaoVoce++;
                Vencedor.Text = "Você Venceu";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
        }

        private void btnTesoura_Click(object sender, RoutedEventArgs e)
        {
            EsconderFotos();
            var rnd = new Random();
            escolhaComputador = pedraPapelTesoura[rnd.Next(pedraPapelTesoura.Count)];
            if (escolhaComputador == "Tesoura")
            {
                tesouraPC.Visibility = Visibility.Visible;
                tesouraVC.Visibility = Visibility.Visible;
                pontuacaoPc++;
                pontuacaoVoce++;
                Vencedor.Text = "Empate";
                ptsPc.Text = $"{pontuacaoPc}";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
            if (escolhaComputador == "Pedra")
            {
                pedraPC.Visibility = Visibility.Visible;
                tesouraVC.Visibility = Visibility.Visible;
                pontuacaoPc++;
                Vencedor.Text = "Computador Venceu";
                ptsPc.Text = $"{pontuacaoPc}";
            }
            if (escolhaComputador == "Papel")
            {
                papelPC.Visibility = Visibility.Visible;
                tesouraVC.Visibility = Visibility.Visible;
                pontuacaoVoce++;
                Vencedor.Text = "Você Venceu";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
        }

        private void EsconderFotos()
        {
            papelPC.Visibility = Visibility.Hidden;
            papelVC.Visibility = Visibility.Hidden;
            pedraPC.Visibility = Visibility.Hidden;
            pedraVC.Visibility = Visibility.Hidden;
            tesouraPC.Visibility = Visibility.Hidden;
            tesouraVC.Visibility = Visibility.Hidden;
        }
    }
}
