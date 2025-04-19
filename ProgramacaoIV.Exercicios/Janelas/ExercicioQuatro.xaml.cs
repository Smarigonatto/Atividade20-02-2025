using ProgramacaoIV.Exercicios.Janelas;
using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioQuatro : Window
    {
        public ExercicioQuatro()
        {
            InitializeComponent();
        }

        private void ButtonVerificarIdade_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(IdadeTextBox.Text, out int idade))
            {
                string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
                MessageBox.Show(mensagem, "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
