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
            
            if(miCalculadora.GetNumero1().Length>0)
            {
                miCalculadora.SetPantalla("/");
                miCalculadora.SetOperacion("/");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }

        }

        private void Multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.GetNumero1().Length > 0)
            {
                miCalculadora.SetPantalla("X");
                miCalculadora.SetOperacion("X");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }
        }

        private void Resta_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.GetNumero1().Length > 0)
            {
                miCalculadora.SetPantalla("-");
                miCalculadora.SetOperacion("-");
                miCalculadora.SetPunto(false);
                Resultado.Text = miCalculadora.GetPantalla();
            }
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {
            if (miCalculadora.GetNumero1().Length > 0)
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
            if (miCalculadora.GetNumero1().Length>0 && miCalculadora.GetNumero2().Length > 0)
            {
                double total;
                double Numero1 = Convert.ToDouble(miCalculadora.GetNumero1());
                double Numero2 = Convert.ToDouble(miCalculadora.GetNumero2());
                
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
    }

    class Calculadora
    {
        private String Numero1;
        private String Numero2;
        private String Pantalla;
        private String Operacion;
        private Boolean Punto;
        List<String> Operaciones = new List<String> { "/", "X", "-","+"};

        public delegate double OperacionMatematica(double Numero1, double Numero2);

        public Calculadora()
        {
            this.Numero1 = "";
            this.Numero2 = "";
            this.Operacion = "";
            this.Punto = false;

        }

        public void SetNumero1(String Numero1)
        {
            this.Numero1 += Numero1;
        }

        public void SetNumero2(String Numero2)
        {
            this.Numero2 += Numero2;
        }

        public String GetNumero1()
        {
            return Numero1;
        }

        public String GetNumero2()
        {
            return Numero2;
        }

        public void SetOperacion(String Operacion)
        {
            if(this.Operacion.Length==0)
                this.Operacion += Operacion;
        }

        public String GetOperacion()
        {
            return Operacion;
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
                Pantalla += Digito;

        }

        public String GetPantalla()
        {
            return Pantalla;
        }

        public void SetNumeros(String Numero)
        {
            if (Operacion.Length==0)
            {
                this.SetNumero1(Numero);
            }
            else
            {
                this.SetNumero2(Numero);
            }
        }

        public void LimpiarPantalla()
        {
            Pantalla = String.Empty;
            Numero1 = String.Empty;
            Numero2 = String.Empty;
            Operacion = String.Empty;
        }

       
    }
}
