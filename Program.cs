using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9lpro1232222
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00, 0.00);

            Console.WriteLine("Ingrese la marca del automovil: ");
            objAutomovil.DefinirMarca(Console.ReadLine());

            Console.WriteLine("Ingrese el modelo del automóvil: ");
            objAutomovil.DefinirModelo(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Ingrese el precio del automóvil: ");
            objAutomovil.DefinirPrecio(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Ingrese si hay disponibilidad del automóvil: ");
            objAutomovil.CambiarDisponibilidad(Convert.ToBoolean(Console.ReadLine()));

            Console.WriteLine("Ingrese el descuento aplicado: ");
            objAutomovil.DefinirDescuentoAplicado(Convert.ToDouble(Console.ReadLine())); 


            //Se siguen pidiendo los datos...

            //Aquí mostramos toda la info:
            Console.WriteLine(objAutomovil.MostrarInformacion());

            //Esto es para que la consola no se cierre:
            Console.ReadKey();
        }
    }

    class Automovil
    {
        //Atributos privados:
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;
        private double miDescuento;

        //Métodos públicos:
   
        //Este public Automovil es el constructor
        public Automovil(int Modelo, double Precio, string Marca, bool Disponible, double TipoCambioDolar, double DescuentoAlicado, double MiDescuento)
        {
            modelo = Modelo;
            precio = Precio;
            marca = Marca;
            disponible = Disponible;
            tipoCambioDolar = TipoCambioDolar;
            descuentoAplicado = DescuentoAlicado;
            miDescuento = MiDescuento;
        }

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }

        public void DefinirMarca(string unMarca)
        {
            marca = unMarca;
        } 

        public void DefinirTipoCambio(double unTipoCambio)
        {
            unTipoCambio = precio / tipoCambioDolar;
            tipoCambioDolar = unTipoCambio;
        }

        public void CambiarDisponibilidad(bool v)
        {
            if (disponible == true)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }

         public string MostrarDisponibilidad()
         {
            if (disponible == true)
            {
                return "Disponible";
            }
            else
            {
                return "No se encuentra disponoble actualmente";
            }
         }

        public void DefinirDescuentoAplicado(double unDescuentoAplicado)
        {
            miDescuento = precio * unDescuentoAplicado;
            unDescuentoAplicado = precio - miDescuento;
            descuentoAplicado = unDescuentoAplicado;
        }

       

        public string MostrarInformacion()
        {
            return "Marca: " + marca + ", modelo: " + modelo + ", Precio de venta: Q" + precio + ", Precio en dolares $" + tipoCambioDolar + " " + " Disponibilidad: " + MostrarDisponibilidad() + ", El descuento aplicado: " + descuentoAplicado;
        }
    }

}

    

    

