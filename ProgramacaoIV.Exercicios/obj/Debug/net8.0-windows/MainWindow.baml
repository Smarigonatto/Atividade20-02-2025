   M S B A M L   `   `   `  ����S  OProgramacaoIV.Exercicios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ProgramacaoIV.ExerciciosProgramacaoIV.Exercicios  5   	   )    #ProgramacaoIV.Exercicios.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ProgramacaoIV.Exercicios     5   	     � Title$  
Atividades��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��5q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��45 �6   �� 5      $��45 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnExercicioUm��5      $��0��5      $��1��5       ,  (MaterialDesignRaisedSecondaryLightButton#��[  5      $	��145��5       � ToolTip$&  Soma de Dois Números (Inteiros)��5       $��Exercício 1��5!      {�5"      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5#      �� 5%   
   -   5        $ btnExercicioDois��5&   
   $��1��5'   
   $��1��5(   
   #��[  5)   
   $	��145��5*   
   $0 *Conversor de Temperatura (Ponto Flutuante)��5+   
   $��Exercício 2��5,   
   {�5-   
   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5.   
   �� 50   
   -   5        $ btnExercicioTres��51   
   $��2��52   
   $��1��53   
   #��[  54   
   $	��145��55   
   $/ )Dias Até o Próximo Aniversário (Datas)��56   
   $��Exercício 3��57   
    � Cursor$
 Hand��59   )   {�58   
   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window59   )   �� 5;   
   -   5        $ btnExercicioQuatro��5<      $��3��5=      $��1��5>      #��[  5?      $	��145��5@      $+ %Verificador de Maioridade (Booleano) ��5A      $��Exercício 4��5B      $
 Hand��5D   .   {�5C      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5D   .   �� 5E   
   -   5        $ btnExercicioCinco��5F      $��4��5G      $��1��5H      #��[  5I      $	��145��5J      $3 -Exibir Descrição de um Enum (Enumerações)��5K      $��Exercício 5��5L      $
 Hand��5N   -   {�5M      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5N   -   �� 5O   
   -   5        $ btnExercicioSeis��5P      $��0��5Q      $��2��5R      #��[  5S      $	��145��5T      $% Contador de Cliques (Inteiros) ��5U      $��Exercício 6��5V      $
 Hand��5X   ,   {�5W      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5X   ,   �� 5Y   
   -   5        $ btnExercicioSete��5Z      $��1��5[      $��2��5\      #��[  5]      $	��145��5^      $8 2Simulador de Pagamento Parcelado (Ponto Flutuante)��5_      $��Exercício 7��5`      $
 Hand��5b   ,   {�5a      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5b   ,   �� 5c   
   -   5        $ btnExercicioOito��5d      $��2��5e      $��2��5f      #��[  5g      $	��145��5h      $5 /Verificar Dia da Semana (Datas e Enumerações)��5i      $��Exercício 8��5j      $
 Hand��5l   ,   {�5k      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5l   ,   �� 5m   
   -	   5        $ btnExercicioNove��5n      $��3��5o      $��2��5p      #��[  5q      $	��145��5r      $ Liga/Desliga (Booleano)��5s      $��Exercício 9��5t      $
 Hand��5v   ,   {�5u      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5v   ,   �� 5w   
   -
   5        $ btnExercicioDez��5x      $��4��5y      $��2��5z      #��[  5{      $	��145��5|      $5 /Simulador de Sorteio (Inteiros e Enumerações)��5}      $��Exercício 10��5~      $
 Hand��5�   +   {�5      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5�   +   5�      5�      