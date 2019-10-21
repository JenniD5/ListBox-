using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    

        //para actualizar una lista, el list no puede hacerlo, ya que observablecollection puede mostrarnos las actualizaicones 
        ObservableCollection<string> Colores = new ObservableCollection<string>();

        public MainWindow()
        {   //no se pude llenar aqui y en el xaml, es en un lado o en el otro.....en xaml se comenta igual que en html 
            InitializeComponent();
            Colores.Add("rojo");
            Colores.Add("negro");
            Colores.Add("azul");
            Colores.Add("blanco");

            //establecer que elementos va a contener
            lstColores.ItemsSource = Colores;
            
        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            Colores.Add(txtcolor.Text);
            txtcolor.Text = "";
           


        }
    }
}
