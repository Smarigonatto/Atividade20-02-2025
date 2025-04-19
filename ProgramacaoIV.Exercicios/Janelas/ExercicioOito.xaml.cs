using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioOito : Window
    {
        public enum DiaDaSemana
        {
            Domingo = 0,
            Segunda = 1,
            Terça = 2,
            Quarta = 3,
            Quinta = 4,
            Sexta = 5,
            Sábado = 6
        }

        public ExercicioOito()
        {
            InitializeComponent();
        }
        private void ButtonVerificarDia_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate.HasValue)
            {
                DateTime dataSelecionada = datePicker.SelectedDate.Value;
                DiaDaSemana diaSemana = (DiaDaSemana)dataSelecionada.DayOfWeek;

                MessageBox.Show($"A data selecionada cai em uma {diaSemana}.", "Dia da Semana", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
