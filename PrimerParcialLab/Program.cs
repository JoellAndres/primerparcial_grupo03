using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLab
{
    class Program
    {
        static void pedirOpcion(ref int opc)
        {
            try
            {
                opc = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n"+ex.Message);
            }
        }

        static void verificarOpcionSalida(ref string opc)
        {
            Console.Write("“¿Está seguro que desea salir? S/N”.");

            do {
                opc = Console.ReadLine();
                opc = opc.ToUpper();
            } while ((opc != "S")&&(opc != "N"));
        }

        static string calcularDescuento(int cantCamisas, float precioTotal, ref float precioConDcto)
        {

            precioConDcto = precioTotal;

            if ((cantCamisas >= 3) && (cantCamisas <= 5))
            {
                precioConDcto *= 0.90f;
                return "10";
            }
            else if (cantCamisas > 5)
            {
                precioConDcto *= 0.80f;
                return "20";
            }
            else
                return "0";
            
        }
        static void Main(string[] args)
        {
            //Grupo de acción N° 1
            //Integrantes: Veloci, Franco - Tuma, Joel
            int opc = 0;
            string opc2 = "";
            float precioTotal=0.0f, precioConDescuento = 0.0f;
            int carritoCamisa = 0;

            do {
                Console.WriteLine("Camisas PRADBIT – Ventas minoristas y mayoristas");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1 - Añadir camisa al carro de compras");
                Console.WriteLine("2 - Eliminar camisa del carro de compras");
                Console.WriteLine("3 - Salir");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Cantidad de camisas en el carro de compras:" + carritoCamisa);
                Console.WriteLine("-Precio unitario: $1000");
                Console.WriteLine("-Precio total sin descuento: $" + precioTotal);                
                Console.WriteLine("-Tipo de descuento aplicado: %" + calcularDescuento(carritoCamisa, precioTotal, ref precioConDescuento));
                Console.WriteLine("-Precio final con descuento: $" + precioConDescuento);
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Ingrese una opción del menú: ");
                
                //Pidiendo opcion
                pedirOpcion(ref opc);

                switch (opc)
                {
                    case 1:
                        carritoCamisa++;
                        precioTotal += 1000;
                        break;

                    case 2:
                        if (carritoCamisa > 0)
                        {
                            carritoCamisa--;
                            precioTotal -= 1000;
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay camisas en el carrito");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }

                        break;

                    case 3:
                        Console.Clear();
                        verificarOpcionSalida(ref opc2);
                        
                        if (opc2 == "N")                                                   
                            opc = 0; //Volviendo a ejecutar                            
                                                    
                                                    
                        break;

                    default:
                        Console.WriteLine("Opcion ingresada incorrecta (1-3)");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
                                
                Console.Clear();
            } while(opc != 3);
        }
    }
}
