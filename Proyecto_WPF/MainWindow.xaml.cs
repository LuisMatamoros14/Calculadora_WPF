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
using System.Globalization;
using System.Threading;
using System.Windows.Threading;

namespace Proyecto_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculadora miCalculadora = new Calculadora();

        public MainWindow()
        {

            InitializeComponent();
            //this.Dispatcher.BeginInvoke(new ThreadStart(()=>HoraActual()));
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(HoraActual);
            dispatcherTimer.Interval = new TimeSpan(0, 0,0);
            dispatcherTimer.Start();
            //Grid miGrid = new Grid();

            //this.Content = miGrid;

            //Button miBtn = new Button();

            //WrapPanel miWrap = new WrapPanel();

            //TextBlock txt1 = new TextBlock();
            //TextBlock txt2 = new TextBlock();
            //txt1.Text = "Mi btn 1";
            //txt2.Text = "Mi btn 2";

            //txt1.Background = Brushes.White;
            //txt1.Foreground = Brushes.Yellow;

            //miWrap.Children.Add(txt1);
            //miWrap.Children.Add(txt2);

            //miBtn.Content = miWrap;
            //miBtn.Height = 200;
            //miBtn.Width = 200;
            //miBtn.Background = Brushes.Blue;

            //miGrid.Children.Add(miBtn);
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            
            if(miCalculadora.Numero1.Length>0)
            {
                miCalculadora.SetPantalla("/");
                miCalculadora.SetOperacion("/");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }
        }

        private void Multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.Numero1.Length > 0)
            {
                miCalculadora.SetPantalla("X");
                miCalculadora.SetOperacion("X");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }
        }

        private void Resta_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.Numero1.Length > 0)
            {
                miCalculadora.SetPantalla("-");
                miCalculadora.SetOperacion("-");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.Numero1.Length > 0)
            {
                miCalculadora.SetPantalla("+");
                miCalculadora.SetOperacion("+");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.LimpiarPantalla();
            miCalculadora.SetPantalla("0");
            miCalculadora.SetOperacion("");
            miCalculadora.SetPunto(false);
            Resultado.Text = miCalculadora.GetPantalla();
        }

        private void Punto_Click(object sender, RoutedEventArgs e)
        {
            if (!miCalculadora.GetPunto())
            {
                miCalculadora.SetPantalla(".");
                miCalculadora.SetNumeros(".");
            }
            miCalculadora.SetPunto(true);
            
            Resultado.Text = miCalculadora.GetPantalla();
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.Numero1.Length>0 && miCalculadora.Numero1.Length > 0)
            {
                double total;
                double Numero1 = Convert.ToDouble(miCalculadora.Numero1.ToString());
                double Numero2 = Convert.ToDouble(miCalculadora.Numero2.ToString());
                
                switch (miCalculadora.GetOperacion())
                {
                    case "/":
                        if (Numero2 != 0) total = Numero1 / Numero2;
                        else total = 0;
                        miCalculadora.LimpiarPantalla();
                        Resultado.Text = total.ToString();
                        break;
                    case "X":
                        total = Numero1 * Numero2;
                        miCalculadora.LimpiarPantalla();
                        Resultado.Text = total.ToString();
                        break;
                    case "-":
                        total = Numero1 - Numero2;
                        miCalculadora.LimpiarPantalla();
                        Resultado.Text = total.ToString();
                        break;
                    case "+":
                        total = Numero1 + Numero2;
                        miCalculadora.LimpiarPantalla();
                        Resultado.Text = total.ToString();
                        break;
                }

                miCalculadora.SetPunto(false);
            }
        }

        //Numeros

        private void Nueve_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("9");
            miCalculadora.SetNumeros("9");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Ocho_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("8");
            miCalculadora.SetNumeros("8");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Siete_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("7");
            miCalculadora.SetNumeros("7");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Seis_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("6");
            miCalculadora.SetNumeros("6");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Cinco_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("5");
            miCalculadora.SetNumeros("5");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Cuatro_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("4");
            miCalculadora.SetNumeros("4");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Tres_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("3");
            miCalculadora.SetNumeros("3");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Dos_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("2");
            miCalculadora.SetNumeros("2");
            Resultado.Text = miCalculadora.GetPantalla();
        }
        private void Uno_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("1");
            miCalculadora.SetNumeros("1");
            Resultado.Text = miCalculadora.GetPantalla();
        }

        private void Cero_Click(object sender, RoutedEventArgs e)
        {
            miCalculadora.SetPantalla("0");
            miCalculadora.SetNumeros("0");
            Resultado.Text = miCalculadora.GetPantalla();
        }

        private void HoraActual(object obj, EventArgs eventArgs)
        {

            //DateTime horaActual = DateTime.ParseExact("12:00:00", "h:mm:ss", CultureInfo.CurrentCulture);
            LTime.Content = DateTime.Now.ToString("hh:mm:ss");

        }
    }

    public class Calculadora
    {
        public StringBuilder Numero1 = new StringBuilder();

        public StringBuilder Numero2 = new StringBuilder();
        
        private StringBuilder Pantalla = new StringBuilder();
        
        private StringBuilder Operacion = new StringBuilder();

        private Boolean Punto;
        
        List<String> Operaciones = new List<String> { "/", "X", "-","+"};

        public Calculadora()
        {
            Numero1.Append("");
            Numero2.Append("");
            Operacion.Append("");
            Punto = false;

        }

        public void SetOperacion(String Operacion)
        {
            if(this.Operacion.Length==0)
                this.Operacion.Append(Operacion);
        }

        public String GetOperacion()
        {
            return Operacion.ToString();
        }

        public void SetPunto(Boolean Punto)
        {
            this.Punto = Punto;
        }

        public Boolean GetPunto()
        {
            return Punto;
        }

        public void SetPantalla(String Digito)
        {
            if (Operaciones.Contains(Digito) && Pantalla.Equals(Digito))
                return;
            else
                Pantalla.Append(Digito);
        }

        public String GetPantalla()
        {
            return Pantalla.ToString();
        }

        public void SetNumeros(String Numero)
        {
            if (Operacion.Length==0)
            {
                Numero1.Append(Numero);
            }
            else
            {
                Numero2.Append(Numero);
            }
        }

        public void LimpiarPantalla()
        {
            Pantalla.Clear();
            Numero1.Clear();
            Numero2.Clear();
            Operacion.Clear();
        }
    }


}




