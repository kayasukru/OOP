using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface_IEnumerable_App
{
    public class Dizi:IEnumerable
    {
        private int[] InnerList { get; set; }
        private int index = 0;

        public Dizi(int size = 16)
        {
            InnerList = new int[size];
        }

        public Dizi(params int[] initial)
        {
            InnerList = new int[initial.Length];
            foreach (var item in initial)
            {
                InnerList[index] = item;
                index++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new DiziEnumerator(InnerList);
            //return InnerList.Take(index).GetEnumerator();
        }
    }
}
