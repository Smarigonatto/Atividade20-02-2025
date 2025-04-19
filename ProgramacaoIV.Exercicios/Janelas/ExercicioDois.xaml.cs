using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioDois : Window
    {
        public ExercicioDois()
        {
            InitializeComponent();
        }

        private void ConverterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double celsius = Convert.ToDouble(TextBoxCelsius.Text);

                double fahrenheit = (celsius * 9 / 5) + 32;


                MessageBox.Show($"O valor em Fahrenheit é: {fahrenheit}°F", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido em Celsius.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

