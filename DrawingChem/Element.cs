using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingChem
{
    class Element
    {
        private string name;
        private string symbol;
        private int atomicNumber;


        public string Name => name;
        public string Symbol => symbol;
        public int AtomicNumber => atomicNumber;

        public Element(string n, string symbl, int atomicN)
        {
            name = n;
            symbol = symbl;
            atomicNumber = atomicN;
        }

        public override string ToString()
        {

            return "Name: "+ name + " Symbol: " + symbol + "Atomic Number: " + atomicNumber;
        }
    }
}
