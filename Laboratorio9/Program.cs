using System;
using System.Collections.Generic;


namespace Laboratorio9
{
    public class Metodo  //classe criada para armazenar os 2 novos metodos 
    {
        //Novo metodo 1
        //------Exercício 4.2 ------
        public void TotalAcimaMedia(List<int> lista)
        {
            int soma = 0;
            int contador = 0;
            decimal media = 0;
            foreach (int numerosint2 in lista)
            {
                Console.WriteLine(numerosint2);
                soma = soma + numerosint2;
                contador++;

                Console.ReadKey();
            }
            media = soma / contador;
            Console.WriteLine("Valor da Média " + media);

            foreach (int numerosint2 in lista)
            {
                if (numerosint2 > media)
                {
                    Console.WriteLine("Valor acima da Média " + numerosint2);
                    Console.ReadKey();
                }
            }

        }
        //Novo metodo 2
        //------Exercício 4.3 ------
        public List<int> ListaAcimaMedia(List<int> lista)
        {
            int soma = 0;
            int contador = 0;
            decimal media = 0;
            foreach (int numerosint2 in lista) //somando os numeros da lista, calculando a quantidade de numeros da lista
            {
                soma = soma + numerosint2;
                contador++;

            }
            media = soma / contador; //calcula a media
            Console.WriteLine("Valor da Média " + media);

            Console.WriteLine("Exibindo nova lista");
            Console.WriteLine();
            List<int> numerosint3 = new List<int>();

            //laço de repetiçao para varrer a primeira lista inteira
            foreach (int linha in lista)
            {
                if (linha > media) //compara se o valor da lista é maior que a média
                {
                    numerosint3.Add(linha);
                }

            }

            return numerosint3;
                       

        }
    }
    internal class Program //classe principal 
    {

        static void Main(string[] args)
        {
            List<string> listaStrings = new List<string>();
            listaStrings.Add("Um"); listaStrings.Add("Hello");
            listaStrings.Add("World"); Console.WriteLine(
            listaStrings[0]);
            Console.WriteLine(listaStrings[1]);
            Console.ReadKey();
            Console.WriteLine(listaStrings[2]);
            Console.ReadKey();

            listaStrings.Add("10");

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework / Core");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.ReadKey();
            Console.WriteLine(q.Dequeue());
            Console.ReadKey();
            Console.WriteLine(q.Dequeue());
            Console.ReadKey();

            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.ReadKey();
            Console.WriteLine(minhaFila.Dequeue());
            Console.ReadKey();
            Console.WriteLine(minhaFila.Dequeue());
            Console.ReadKey();

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";
            Console.WriteLine("O código 55 é: {0}", paises[55]);
            Console.ReadKey();
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
                Console.ReadKey();
            }
            Console.WriteLine();

            // DDD ALTERADO
            Console.WriteLine("------Exercício 4.1 ------");
            Dictionary<string, int> paises2 = new Dictionary<string, int>();
            paises2["ReinoUnido"] = 44;
            paises2["Franca"] = 33;
            paises2["Brasil"] = 55;
            Console.WriteLine("Para o Brasil, o código é: {0}", paises2["Brasil"]);
            Console.ReadKey();
            foreach (KeyValuePair<string, int> item in paises2)
            {

                string pais2 = item.Key;
                int codigo = item.Value;

                Console.WriteLine("País {0} = {1}", pais2, codigo);
                Console.ReadKey();


            }
            Console.WriteLine("------Exercício 4.2 ------");
            List<int> numerosint = new List<int>();
            numerosint.Add(100);
            numerosint.Add(250);
            numerosint.Add(390);
            numerosint.Add(170);

            Metodo metodo = new Metodo();
            metodo.TotalAcimaMedia(numerosint);
            Console.WriteLine();

            Console.WriteLine("------Exercício 4.3 ------");
            List<int> listaAcimaMedia = metodo.ListaAcimaMedia(numerosint);//listaAcimaMedia recebe e guarda a nova lista criada com os numeros acima da média 

            
            foreach (int linha2 in listaAcimaMedia)
            {
                Console.WriteLine("Valor acima da Média " + linha2);
                Console.ReadKey();
            }
            
        }

    }
}   
