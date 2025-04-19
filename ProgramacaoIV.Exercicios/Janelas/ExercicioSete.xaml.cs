using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {
            InitializeComponent();
        }

        private void ButtonCalcularParcelas_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(txtValorTotal.Text, out decimal valorTotal))
            {

                if (comboBoxParcelas.SelectedItem is ComboBoxItem selectedParcelaItem &&
                    int.TryParse(selectedParcelaItem.Content.ToString(), out int numeroParcelas))
                {

                    decimal valorParcela = valorTotal / numeroParcelas;

                    MessageBox.Show($"O valor de cada parcela será: {valorParcela:C2}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma quantidade válida de parcelas.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor total válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
