using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingChem
{
    //just for storing all elements
    class ChemData
    {

        private List<int> valenceCnt = new List<int>{2, 10, 18};

        private Dictionary<string, Element> elementDic = new Dictionary<string, Element>();


        public ChemData()
        {
            CreateDiction();

        }

        private void CreateDiction()
        {
            Element H = new Element("Hydrogen", "H", 1);
            Element C = new Element("Carbon", "C", 6);
            Element O = new Element("Oxygen", "O", 8);

            elementDic.Add("H", H);
            elementDic.Add("C", C);
            elementDic.Add("O", O);


        }

        public bool ElementExist(string name)
        {

            if (elementDic.ContainsKey(name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1).ToLower())) return true;
            if (name.Length > 2)//search for element
                return SearchByName(name.ToLower()) != null;
            if (int.TryParse(name, out int atomN) && SearchByAtomicNumber(atomN) != null)
                return true;
            return false;
        }

        public Element FindElement(string name)
        {
            if (elementDic.ContainsKey(name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1).ToLower())) return elementDic[name.Substring(0,1).ToUpper() + name.Substring(1, name.Length-1).ToLower()];
            if (name.Length > 2)//search for element
                return SearchByName(name.ToLower());
            if (int.TryParse(name, out int atomN) )
                return SearchByAtomicNumber(atomN);
            return null;
        }

        public Element SearchByName(string name)
        {
            foreach(string symbol in elementDic.Keys)
            {
                if (elementDic[symbol].Name.ToLower() == name) return elementDic[symbol];
            }

            return null;
        }

        public Element SearchByAtomicNumber(int atomN)
        {

            foreach (string symbol in elementDic.Keys)
            {
                if (elementDic[symbol].AtomicNumber == atomN) return elementDic[symbol];
            }

            return null;
        }

        public int FindProbableAmtValenceEl(Element e)
        {
            for(int i=0; i<valenceCnt.Count-1; i++)
            {
                if (e.AtomicNumber <= (valenceCnt[i] ))// /2 + valenceCnt[i+1]))
                {
                    return valenceCnt[i];
                }

            }return valenceCnt[valenceCnt.Count - 1];
           
        }
    }
}
