using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioNove : Window
    {
        // Variável booleana para armazenar o estado do interruptor
        private bool isLigado = false;

        public ExercicioNove()
        {
            InitializeComponent();
        }

        private void ButtonToggle_Click(object sender, RoutedEventArgs e)
        {
            isLigado = !isLigado;

            if (isLigado)
            {
                buttonToggle.Content = "Ligado";
                MessageBox.Show("O estado atual é: Ligado", "Estado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                buttonToggle.Content = "Desligado";
                MessageBox.Show("O estado atual é: Desligado", "Estado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
