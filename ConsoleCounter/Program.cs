using System.Diagnostics.Metrics;

namespace ConsoleCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int contador = 0;
            string comando;
            bool continuar = true;

            Console.Write("From what number should the count start from?\t");
            contador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type + to increase count or - to decrease it. To stop type any other key.");
            while (continuar == true)
            {

                Console.Write("\t\t\t\t");
                comando = Console.ReadLine();
                



                if (comando == "+")
                {
                    //contador++;
                    //contador = mais1(contador);
                    contador = Acrescentar.mais1(contador);
                    Console.WriteLine(contador);
                    Console.WriteLine();


                }

                else if (comando == "-")
                {
                    // contador--;
                    //contador = Menos1(contador);
                    contador = Descontar.Menos1(contador);
                    Console.WriteLine(contador);
                    Console.WriteLine();
                }


                else
                {
                    continuar = false;
                    Console.WriteLine("Bye!");
                }

            }
        }

        

       

        
    }
}