using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    internal class Node
    {
        private Person value;
        private Node next;
        private Node previous;

        public Node (Person value)
        {
            this.value = value;
            this.next = null;
        }

        public void setValue(Person value) { this.value = value;}
        public Person getValue() { return this.value;}
        public void setNext(Node node) { this.next = node; }
        public Node getNext() { return this.next;}
        public void setPrevious (Node previous) { this.previous = previous; }
        public Node getprevious() { return this.previous; }
    }
}
