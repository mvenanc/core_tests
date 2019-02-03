using System;
using System.Collections.Generic;

namespace exercicio_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string> {"Maria" , "Alex"};

            list.Add("Marcio"); //adiciona ao final da lista
            list.Add("Jair");
            list.Add("Antonio");
            list.Add("Ana");
            list.Add("Joao");

            list.Insert(0,"Primeiro"); //insert, insere em um local na lista

            foreach(var item in list){
                Console.WriteLine(item);

            }

            Console.WriteLine(list.Count);

            //string s1 = list.Find(Test); // com função
            string s1 = list.Find(x=>x[0]=='A'); // com lambda
            Console.WriteLine("Comeca com A " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima ocorrencia com A " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posicao A : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posicao A : " + pos2);   

            List<string> res = list.FindAll(x => x.Length == 6);
            Console.WriteLine("----------------------");
            foreach(var item in res){
                Console.WriteLine(item);
            }

            list.Remove("Joao");
            Console.WriteLine("----------------------");
            foreach(var item in list){
                Console.WriteLine(item);

            }            

            list.RemoveAll(x => x.Length == 3);
            Console.WriteLine("----------------------");
            foreach(var item in list){
                Console.WriteLine(item);

            }            

            list.RemoveAt(0);
            Console.WriteLine("----------------------");
            foreach(var item in list){
                Console.WriteLine(item);

            }            

            list.RemoveRange(0,2);
            Console.WriteLine("----------------------");
            foreach(var item in list){
                Console.WriteLine(item);

            }                        
        }

        static bool Test(string s){
            return s[0] == 'A';
        }
        
    }
}
