using System;
using System.Collections.Generic;
using System.Text;

namespace CLASS_13_10_22
{
    internal class Tarea
    {
        ListaMultimedia lista = new ListaMultimedia();

        public void Iniciar()
        {
            bool repetir = true;

            while (repetir)
            {
                Console.Clear();
                Console.WriteLine("=============================");
                Console.WriteLine("Biblioteca - Contenido Multimedia");
                Console.WriteLine("=============================");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar nueva al inicio");
                Console.WriteLine("2. Agregar nueva al final");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("-----------------------------");


                int opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        NuevaMultimedia(1);
                        break;

                    case 2:
                        NuevaMultimedia(2);
                        break;
                    case 3:
                        BuscarMultimedia();
                        break;

                    default:
                        Console.WriteLine("La opción seleccionada no es valida");
                        break;
                }

                Console.WriteLine("¿Desea realizar alguna otra operaciön? (Y/N)");
                string repetirOpciones = Console.ReadLine();

                if(repetirOpciones.ToLower() == "y")
                {
                    repetir = true;
                }
                else
                {
                    repetir = false;
                }
            }


        }

        private void NuevaMultimedia(int inOrOut)
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Nueva Multimedia");
            Console.WriteLine("=============================");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar Película");
            Console.WriteLine("2. Agregar Música");
            Console.WriteLine("-----------------------------");

            int opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarPelicula(inOrOut);
                    break;

                case 2:
                    AgregarMusica(inOrOut);
                    break;

                default:
                    Console.WriteLine("La opción seleccionada no es valida");
                    break;
            }



        }

        private void AgregarPelicula(int inOrOut)
        {
            Multimedia pelicula = new Multimedia();

            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Nueva Pelicula");
            Console.WriteLine("=============================");
            Console.Write("Introduzca el nombre:");
            pelicula.Nombre = Console.ReadLine();

            Console.Write("Introduzca el precio:");
            pelicula.Precio = float.Parse(Console.ReadLine());

            Console.Write("Introduzca el genero:");
            pelicula.Genero = Console.ReadLine();

            pelicula.Tipo = "PELICULA";

            if (inOrOut == 1)
            {
                lista.AgregarInicio(pelicula);
            }
            else
            {
                lista.AgregarFinal(pelicula);
            }

        }

        private void AgregarMusica(int inOrOut)
        {
            Multimedia musica = new Multimedia();

            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Nueva Música");
            Console.WriteLine("=============================");
            Console.Write("Introduzca el nombre:");
            musica.Nombre = Console.ReadLine();

            Console.Write("Introduzca el precio:");
            musica.Precio = float.Parse(Console.ReadLine());

            Console.Write("Introduzca el genero:");
            musica.Genero = Console.ReadLine();

            musica.Tipo = "MUSICA";

            if(inOrOut == 1)
            {
                lista.AgregarInicio(musica);
            }
            else
            {
                lista.AgregarFinal(musica);
            }
            
        }

        private void BuscarMultimedia()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Buscar Multimedia");
            Console.WriteLine("=============================");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Listar todo");
            Console.WriteLine("2. Buscar por genero");
            Console.WriteLine("-----------------------------");

            int opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("=============================");
                    Console.WriteLine("Listado de Multimedia");
                    Console.WriteLine("=============================");
                    MostrarLista(lista.inicio);
                    break;

                case 2:
                    BuscarMultimediaPorGenero();
                    break;

                default:
                    Console.WriteLine("La opción seleccionada no es valida");
                    break;
            }
        }

        private void BuscarMultimediaPorGenero()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Buscar Multimedia");
            Console.WriteLine("=============================");
            Console.Write("Introduzca el genero:");

            string genero = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine($"Listado de Multimedia: {genero}");
            Console.WriteLine("=============================");

            MostrarListaPorGenero(lista.inicio,genero);
        }

        private void MostrarLista(Multimedia nodo)
        {
            
            if (nodo != null)
            {
                Console.WriteLine($"{nodo.Tipo} -- {nodo.Nombre} -- {nodo.Genero} -- ${nodo.Precio}");
                MostrarLista(nodo.Siguiente);
            }
        }

        private void MostrarListaPorGenero(Multimedia nodo, string genero)
        {

            if (nodo != null)
            {
                if(nodo.Genero.ToLower() == genero.ToLower())
                {
                    Console.WriteLine($"{nodo.Tipo} -- {nodo.Nombre} -- {nodo.Genero} -- ${nodo.Precio}");
                }
                MostrarListaPorGenero(nodo.Siguiente, genero);
            }
        }
    }
}
