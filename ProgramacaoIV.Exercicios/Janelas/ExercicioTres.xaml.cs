using ProgramacaoIV.Exercicios.Janelas;
using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        private void ButtonCalcularDias_Click(object sender, RoutedEventArgs e)
        {
            if (datePickerNascimento.SelectedDate.HasValue)
            {
                DateTime nascimento = datePickerNascimento.SelectedDate.Value;

                DateTime hoje = DateTime.Now;

                DateTime proximoAniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

                if (hoje > proximoAniversario)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }

                int diasRestantes = (proximoAniversario - hoje).Days;

                MessageBox.Show($"Faltam {diasRestantes} dias para o seu próximo aniversário!");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data de nascimento.");
            }
        }
    }
}
