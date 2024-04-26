using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    internal class LinkedList
    {
        private string name;
        private Node head;
        private Node tail;

        public LinkedList(string name)
        {
            this.name = name;
            this.head = null;
            this.tail = null;
        }

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name;}
        public void setHead(Node head) { this.head = head;}
        public Node getHead() { return this.head; }

        public void setTail(Node tail) { this.tail = tail;}
        public Node getTail() { return this.tail; }
        public bool isEmpty() 
        {
            return this.head == null;
        }
        
        public void addNodeAtIndex(Node newNode, int index)
        {
            if (index < 0)
            {
                Console.WriteLine("El índice debe ser igual o mayor que cero.");
                return;
            }

            if (index == 0)
            {
                newNode.setNext(this.head);
                if (this.head != null)
                    this.head.setPrevious(newNode);
                this.head = newNode;
                if (this.tail == null)
                    this.tail = newNode;
                return;
            }

            Node aux = this.head;
            int currentIndex = 0;

            while (aux != null && currentIndex < index - 1)
            {
                aux = aux.getNext();
                currentIndex++;
            }

            if (aux == null)
            {
                Console.WriteLine("El índice está fuera de rango.");
                return;
            }

            newNode.setNext(aux.getNext());
            newNode.setPrevious(aux);

            if (aux.getNext() != null)
                aux.getNext().setPrevious(newNode);
            aux.setNext(newNode);

            if (newNode.getNext() == null)
                this.tail = newNode;
        }

        public void addNode(Node newNode) 
        {
            if (isEmpty())
            {
                this.head = newNode;            
            }
            else 
            { 
                Node aux = this.head;

                while(aux.getNext() != null) 
                { 
                    aux = aux.getNext();
                }

                newNode.setPrevious(aux);
                aux.setNext(newNode);
                this.tail = newNode;
            }
        }
    
        public void printData()
        {
            Node aux = this.head;

            while (aux != null)
            {
                Console.WriteLine($"Nombre: {aux.getValue().getName()}");
                aux = aux.getNext();
            }
            
        }

        public void removeNode() 
        {
            if (!isEmpty()) 
            { 
                Node aux = this.head;
                Node last = null;

                while(aux.getNext() != null) 
                {
                    if(aux.getNext().getNext() == null) 
                    {
                        last =aux.getNext();
                        break;                    
                    }
                    aux = aux.getNext();
                }

                last.setPrevious(null);
                aux.setNext(null);
                this.tail = aux;
            }     
        }

        public void inversePrintData() 
        {
            Node aux = this.tail;
            while (aux != null) 
            {
                Console.WriteLine($"Nombre: {aux.getValue().getName()}");
                aux = aux.getprevious();
            }
        }

    }
}
