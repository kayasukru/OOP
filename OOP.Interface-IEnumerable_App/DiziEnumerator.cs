using System.Collections;

namespace OOP.Interface_IEnumerable_App
{
    internal class DiziEnumerator : IEnumerator
    {

        private int[] InnerList;
        private int index;
        public DiziEnumerator(int[] arr)
        {
            InnerList = arr;
            //index = -1;
            index = InnerList.Length;
        }
        public object Current => InnerList[index];

        public bool MoveNext()
        {
            if (index == InnerList.Length)
            {
                index--;
                return true;
            }
            if (index > 0)
            {
                index--;
                return true;
            }
            else
            {
                index = InnerList.Length;
                return false;
            }
        }

        public void Reset()
        {
            //index = -1;
            index = InnerList.Length;
        }
    }
}