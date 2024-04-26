using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList("Estudiantes");

            Node node = new Node(new Person("Pablo", "Paredes", "23/09/2005"));

            myList.addNode(node);

            node = new Node(new Person("Ricardo","Ramos","12/09/2002"));

            myList.addNode(node);

            node = new Node(new Person("Samuel", "Beteta", "12/09/2002"));

            myList.addNode(node);

            Node newNode = new Node(new Person("Santiago", "Garcia", "12/09/2002"));
            myList.addNodeAtIndex(newNode, 5);

            //myList.printData(); 

            //myList.removeNode();

            myList.inversePrintData();

            Console.WriteLine("--------------- || Agregar con índice ||-------------");

            myList.printData();

            Console.ReadKey();
        }
    }
}
