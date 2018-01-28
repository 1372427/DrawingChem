using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingChem
{
    class Drawer
    {

        ChemData data = new ChemData();

        public string Draw(string compound)
        {
            if (!CountUppervLower(compound)) compound = SearchByName();
            List<Element> elements = new List<Element>();
            List<string> elToFind = new List<string>();
            string curr = compound.Substring(0,1);
            for (int i = 1; i < compound.Length; i++) {
                if (int.TryParse(compound.Substring(i, 1), out int res))
                {
                    for (int j = 0; j < res; j++)
                    {
                        elToFind.Add(curr);
                    }
                    curr = "";
                }
                else if (compound.Substring(i, 1)== compound.Substring(i, 1).ToUpper()) //new element
                {
                    if(curr!="")elToFind.Add(curr);
                    curr = compound.Substring(i,1);
                } 
                else
                {
                    curr += compound.Substring(i, 1);
                }
                    }
            if (curr != "") elToFind.Add(curr);
            for(int i=0; i<elToFind.Count; i++)
            {
                Element el = data.FindElement(elToFind[i]);
                if (el == null)
                {
                    return "This is not a valid compound";
                }
                elements.Add(el);
            }

            //create adj matrix 
            List<int> valenceEl = new List<int>();
            for(int i=0; i<elements.Count; i++)
            {
                valenceEl.Add(data.FindProbableAmtValenceEl(elements[i])- elements[i].AtomicNumber);
            }

            //search for connection
            string toReturn = "";
            List<string> result = Solve(elements, valenceEl);
            if (result == null) return "Error, cannot solve";
            for (int i=0; i<result.Count; i++)
            {
                toReturn += result[i];
            }
            return toReturn;

        }

        private bool done = false;

        private List<string> moves = new List<string>();

        private List<string> Solve(List<Element> elements, List<int> valenceEl)
        {
            
                for (int i = 0; i < elements.Count; i++)
                {
                int startVal = valenceEl[i];
                    while (valenceEl[i] > 0)
                    {
                        for (int j = i + 1; j < elements.Count; j++)
                        {
                            if (valenceEl[j]> 0)
                            {
                                moves.Add(elements[i] + " bond with " + elements[j]);
                                valenceEl[i]--;
                                valenceEl[j]--;
                                Solve(elements, valenceEl);
                            valenceEl[i]++;
                            valenceEl[j]++;
                            moves.RemoveAt(moves.Count-1);
                                Console.WriteLine(elements[i].Name +"&" + elements[j].Name);
                            }
                        }if (startVal == valenceEl[i]) return null;
                    }
                }
            
           return moves;
        }

        private string SearchByName()
        {
            throw new NotImplementedException();
        }

        private bool CountUppervLower(string comp)
        {
            int upper = 0;
            int lower = 0;
            for(int i=0; i< comp.Length; i++)
            {
                if (comp.Substring(i, 1) == comp.Substring(i, 1).ToUpper()) upper++;
                else lower++;
            }
            return upper> lower;
        }
    }
}
