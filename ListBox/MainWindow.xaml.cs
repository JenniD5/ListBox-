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
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();

        public MainWindow()
        {   //no se pude llenar aqui y en el xaml, es en un lado o en el otro.....en xaml se comenta igual que en html 
            InitializeComponent();
            Colores.Add(new Color("rojo", "#124","(00,00)"));
            Colores.Add(new Color("Verde", "#80", "(050,0560)"));
            Colores.Add(new Color("azul", "#876", "(060,450)"));
            //establecer que elementos va a contener
            lstColores.ItemsSource = Colores;
            
        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {


           Colores.Add(new Color(txtcolor.Text,txthexagecimal.Text,txtrgb.Text));
            txtcolor.Text = "";
            txthexagecimal.Text = "";
            txtrgb.Text = "";


        }


        private void LstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (lstColores.SelectedIndex != -1)
            {
                txtcolor_Copy.Text = Colores[lstColores.SelectedIndex].Nombre;
                txthexagecimal_Copy.Text = Colores[lstColores.SelectedIndex].Hexadecimal;
                txtrgb_Copy.Text = Colores[lstColores.SelectedIndex].RGB;
            }
            lstColores.Items.Refresh();


        }

        private void Btneliminar_Click(object sender, RoutedEventArgs e)
        {
            if(lstColores.SelectedIndex !=-1)/*para indicar que no hay nada seleccionado*/
            {
                Colores.RemoveAt(lstColores.SelectedIndex);  //para borrar elementos del list box 
            }
        }

        private void Btnmodificar_Click_1(object sender, RoutedEventArgs e)
        {
            if(lstColores.SelectedIndex !=-1)

            {

                //para modificar primero se busca en la lista, y la clasificacion a la que se iria si se cambia, igalado a la entrada de la caja de teto en la que se va a hacer le cambio
                Colores[lstColores.SelectedIndex].Nombre = txtcolor_Copy.Text;
                Colores[lstColores.SelectedIndex].Hexadecimal = txthexagecimal_Copy.Text;
                Colores[lstColores.SelectedIndex].RGB = txtrgb_Copy.Text;
            }
        }
    }
}
