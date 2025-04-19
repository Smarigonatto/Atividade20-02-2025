using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioSeis : Window
    {
        private int contador = 0;

        public ExercicioSeis()
        {
            InitializeComponent();
        }
        private void ButtonContarCliques_Click(object sender, RoutedEventArgs e)
        {
            contador++;

            MessageBox.Show($"Você clicou {contador} vezes!", "Contador de Cliques", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
