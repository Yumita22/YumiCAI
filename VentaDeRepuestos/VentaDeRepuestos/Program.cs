using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Activo = true;
            string Menu = "1] Traer por Categoría\n2] Agregar Repuesto\n3] Quitar Repuesto\n4] Modificar Repuesto\n5] Agregar Stock\n6] Quitar Stockn\n7]Salir";
            VentaRepuesto Venta = new VentaRepuesto("MiauTo", "Avenida Siempre viva 742");
            Console.WriteLine("Bienvenido al negocio MiauTo");
            do
            {
                Console.WriteLine(Menu);
                try
                {
                    string opcion = Console.ReadLine();
                    if (opcion != "7")
                    {
                        switch (opcion)
                        {
                            case "1":
                                Program.TraerPorCategoria(Venta);
                                break;
                            case "2":
                                Program.AgregarRepuesto(Venta);
                                break;
                            case "3":
                                Program.QuitarRepuesto(Venta);
                                break;
                            case "4":
                                Program.ModificarRepuesto(Venta);
                                break;
                            case "5":
                                Program.AgregarStock(Venta);
                                break;
                            case "6":
                                Program.QuitarStock(Venta);
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Gracias por su visita");
                        Activo = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error");
                }

            }
            while (Activo);
            Console.WriteLine("Gracias por utilizar nuestros servicios. Pulse cualquier tecla para salir.");
            Console.ReadKey();



        }
        public static void TraerPorCategoria(VentaRepuesto venta)
        {
            try
            {
                Console.WriteLine("ingrese la categoria");
                string cat = Console.ReadLine();
                int categoria = Convert.ToInt32(cat);
                List<Repuesto> lista = venta.TraerPorCategoria(categoria);
                foreach (Repuesto r in lista)
                {
                    Console.WriteLine(r.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ha ocurrido un error");
            }

        }

        public static void AgregarRepuesto(VentaRepuesto venta)
        {
            try
            {
                Console.WriteLine("Ingrese el codigo");
                string cod = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Precio");
                string pre = Console.ReadLine();
                Console.WriteLine("Ingrese el stock");
                string stk = Console.ReadLine();
                int codigo = Convert.ToInt32(cod);
                double precio = Convert.ToDouble(pre);
                int stock = Convert.ToInt32(stk);
                Repuesto nuevo = new Repuesto(codigo, nombre, precio, stock);
                venta.AgregarRepuesto(nuevo);

            }
            catch (Exception ex)
            {
                throw new Exception("Ha ingresado mal los datos");
            }
        }
        public static void QuitarRepuesto(VentaRepuesto venta)
        {
            List<Repuesto> lista = venta.ListaProductos;
            Console.WriteLine("Seleccione el código a elimiar");
            try
            {
                string c = Console.ReadLine();
                int codigo = Convert.ToInt32(c);
                venta.QuitarRepuesto(codigo);
                Console.WriteLine("El repuesto ha sido quitad");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible realizar la acción");
            }
        }

        public static void ModificarRepuesto(VentaRepuesto venta)
        {
            List<Repuesto> lista = venta.ListaProductos;
           
            try
            {
                Console.WriteLine("Seleccione el código de repuesto a moficiar");
                string c = Console.ReadLine();
                int codigo = Convert.ToInt32(c);
                Console.WriteLine("Seleccione el precio nuevo");
                string p = Console.ReadLine();
                double precio = Convert.ToDouble(p);
                venta.ModificarPrecio(codigo, precio);
                Console.WriteLine("El precio ha sido modificado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible realizar la acción");
            }
        }

        public static void AgregarStock(VentaRepuesto venta)
        {
            try
            {
                Console.WriteLine("Esccriba el codigo");
                string c = Console.ReadLine();
                int codigo = Convert.ToInt32(c);
                Console.WriteLine("Escriba el stock a agregar");
                string stk = Console.ReadLine();
                int stock = Convert.ToInt32(stk);
                venta.AgregarStock(codigo, stock);
                Console.WriteLine("El stock ha sido modificado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible realizar la acción");
            }
        }

        public static void QuitarStock(VentaRepuesto venta)
        {
            try
            {
                Console.WriteLine("Esccriba el código de repuesto");
                string c = Console.ReadLine();
                int codigo = Convert.ToInt32(c);
                Console.WriteLine("Escriba el stock a quitar");
                string stk = Console.ReadLine();
                int stock = Convert.ToInt32(stk);
                venta.QuitarStock(codigo, stock);
                Console.WriteLine("El stock ha sido modificado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible realizar la acción");
            }
        }
    }

}
