using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public enum TipoUsuario
    {
        [Description("Tem acesso total ao sistema")]
        Administrador,

        [Description("Usuário com permissões limitadas")]
        UsuarioComum,

        [Description("Acesso apenas para visualização")]
        Visitante
    }

    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();
            comboBoxTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario)).Cast<TipoUsuario>();
        }

        private void ButtonExibirDescricao_Click(object sender, RoutedEventArgs e)
        {
            comboBoxTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario)).Cast<TipoUsuario>();
            if (comboBoxTipoUsuario.SelectedItem is TipoUsuario tipoUsuarioSelecionado)
            {
                string descricao = ObterDescricaoEnum(tipoUsuarioSelecionado);

                MessageBox.Show(descricao, "Descrição do Tipo de Usuário", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um tipo de usuário.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private string ObterDescricaoEnum(Enum valorEnum)
        {
            FieldInfo fieldInfo = valorEnum.GetType().GetField(valorEnum.ToString());
            DescriptionAttribute[] atributos = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return atributos.Length > 0 ? atributos[0].Description : valorEnum.ToString();
        }
    }
}
