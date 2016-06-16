using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exa1
{
    class Program
    {
        static  Global Producto= new Global();

        static int option = 0;
        static int size = 5;
        [Flags]
      enum productoPrice
        {
        
        };

        static void AddProducto()
        {
          
            int r = 0, i = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Producto.size)
                {
                    Console.WriteLine("*-* Global Machines  *-*");
                    Console.WriteLine("Ingreso de productos.             ");
                    Console.Write("Digite el codigo:                  ");
                    Producto.SetProductoCod(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el nombre del producto:    ");
                    Producto.SetProductoNombre(Console.ReadLine());
                    Console.Write("Digite el tipo del producto:     ");
                    Console.WriteLine("\nfrituras\nreposteria\nrefrescos gas\nrefrescos natu\nconfiteria");
                    Producto.SetProductoTipo(Console.ReadLine());
                    Console.Write("Digite la fecha de vencimiento(dd/mm/aaaa):");
                    Producto.SetBookVencimiento(Console.ReadLine());
                    Console.Write("Digite el nombre del proveedor:");
                    Producto.SetBookProvee(Console.ReadLine());
                    Console.Write("Digite el precio:   ");
                    Producto.SetBookPrecio(double.Parse(Console.ReadLine()));
                   
                    Console.Write("Digite el estante en el que esta ubicado(1 el mas alto):    ");
                    Console.WriteLine("\nEstante1\nEstante2\nEstante3\nEstante4\nEstante5");

                    Producto.SetBookEs(int.Parse(Console.ReadLine()));
                    
                    if (Producto.AddData(Producto) == true)
                        Console.WriteLine("Producto agregado correctamente");
                    else
                        Console.WriteLine("Producto no agregado");
                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de productos  lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ShowProductos()
        {
          
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine("*-* Global Machines *-*");
            Console.WriteLine("       Listado de Productos           ");
            for (i = 0; i < Producto.size; i++)
            {
                Producto.PrintData(i);
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("Codigo:       " + Producto.GetProductoCod());
                Console.WriteLine("Nombre:   " + Producto.GetProductoNombre());
               

                /*Console.WriteLine("Auto:     " + );
                Console.WriteLine("Precio:   " + );*/
            }
            Console.ReadKey();
        }

        static void SeekProductos()
        {
            //buscar libro
            int ID = 0, reg = 0, r = 0;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global  Machines *-*");
                Console.WriteLine("Búsquedad de productos.           ");
                Console.WriteLine("Digite el codigo del producto a buscar");
                ID = int.Parse(Console.ReadLine());
                if (Producto.SeekData(ID) == true)
                {
                    reg = ID;
                    Console.WriteLine("Registro: " + reg);
                    Console.WriteLine("codigo:       " + Producto.GetProductoCod());
                    Console.WriteLine("Nombre:   " + Producto.GetProductoNombre());
                    /*Console.WriteLine("Auto:     " + );
                    Console.WriteLine("Precio:   " + );*/
                }
                else
                    Console.WriteLine("No se encontro ese codigo");
                Console.WriteLine("Desea buscar otro Producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void PrintInvoice()
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            Console.WriteLine(currentPath + @"\Invoice.txt");

            StreamWriter sw = new StreamWriter(currentPath + @"\Invoice.txt");
           
        }

        static void Main()
        {
            //inicializar el objeto
            Producto.SetSize(size);
            Producto.Initdata();

            PrintInvoice();

            do
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de Productos.");
                Console.WriteLine("2. Modificación de Modificacion de productos.");
                Console.WriteLine("3. Eliminación de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddProducto();
                            break;
                        }
                    case 2:
                        {
                        
                            break;
                        }
                    case 3:
                        {
                           
                            break;
                        }
                    case 4:
                        {
                            SeekProductos();
                            break;
                        }
                    case 5:
                        {
                            ShowProductos();
                            break;
                        }
                    case 6:
                        {
                           
                            break;
                        }
                    case 7:
                       
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}