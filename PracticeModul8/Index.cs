using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModul8
{
    public class Index
    {
        public int _constantaA;
        public Index() { }
        
        public int [] array;
        public Index(int constantaA, int constantaB)
        {
            SetConstA(constantaA);
            int constantaC = constantaB - constantaA;
            array = new int[constantaC];
        }
        public void SetConstA(int constantaA) { _constantaA = constantaA; }
        

        public int this[int index]
        {
            get { index = _constantaA; return array[index]; }
            set { index = _constantaA; array[index] = value; }
        }

    }
}
