using System;

namespace PiedraPapelTijeras
{
    class Program
    {
        static void veredicto(int P1, int maquina)
        {
            if (maquina == 1)
                Console.WriteLine("El enemigo eligio Piedra \n" + "\n");
            if(maquina == 2)
                Console.WriteLine("El enemigo eligio Papel \n" + "\n");
            if (maquina == 3)
                Console.WriteLine("El enemigo eligio Tijera \n" + "\n");
            if (P1 == maquina)
                Console.WriteLine("***Empate*** \n" + "\n");
            if ((P1 == 1 && maquina == 3) || (P1 == 2 && maquina == 1) || (P1 == 3 && maquina == 2))
                Console.WriteLine("***Ganaste*** \n" + "\n");
            if ((maquina == 1 && P1 == 3) || (maquina == 2 && P1 == 1) || (maquina == 3 && P1 == 2))
                Console.WriteLine("***Perdiste*** \n" + "\n");
        }
        static void Main(string[] args)
        {
            int n;
            int opcion;
            Random rnd = new Random();
            Console.WriteLine("Vamos a jugar piedra, papel y tijeras \n" + "\nPresione Enter para continuar. \n");
            string tecla;
            do
            {
                tecla = Console.ReadLine();
                Console.WriteLine();
                if (tecla != "")
                    Console.WriteLine("ERROR, ingresa la opción que te pido");
            } while (tecla != "");

            while (tecla == "")
            {
                Console.WriteLine("Presiona: \n" + "\n1.Para piedra. \n" + "\n2.Para papel \n" + "\n3.Para tijeras \n");
                do
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion < 1 || opcion > 3)
                        Console.WriteLine("ERROR, el número que ingresaste es inválido. Intentalo de nuevo \n" + "\n");
                } while (opcion < 1 || opcion > 3);
                n = rnd.Next(1, 3);

                veredicto(opcion, n);
                Console.WriteLine("==============================");
                Console.WriteLine("Si desea continuar presiona ENTER \n" + "\nSi desea acabar presiona otra tecla");

                tecla = Console.ReadLine();
                if (tecla != "")
                {
                    Console.WriteLine("Se acabó el juego");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
