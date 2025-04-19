using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioDez : Window
    {
        private Random random = new Random();

        public ExercicioDez()
        {
            InitializeComponent();
        }

        private void ButtonSortear_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7);

            if (numeroSorteado == 6)
            {
                MessageBox.Show($"Você tirou {numeroSorteado}: Você ganhou!", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Você tirou {numeroSorteado}: Tente novamente!", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
