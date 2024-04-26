using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    internal class Person
    {
        private string name;
        private string lastname;
        private string birthdate;

        public Person (string name, string lastname, string birthdate)
        {
            this.name = name;
            this.lastname = lastname;
            this.birthdate = birthdate;
        }

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public void setLastname(string lastname) {  this.lastname = lastname; }
        public string getLastName() { return this.lastname; }
        public void setBirthDate(string birthdate) { this.birthdate = birthdate; }
        public string getBirthDate() { return this.birthdate; }

    }
}
