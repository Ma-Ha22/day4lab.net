//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace App
//{
//    public class Arr
//    {

//        private object[] list;
//        private int count;
//        public int Capacity
//        { get { return list.Length; } }
//        public int Count
//        {
//            get { return count; }
//        }

//        public object this[int index]
//        {
//            get { return list[index]; }
//            set { list[index] = value; }
//        }

//        public Arr(int length = 1)
//        {
//            count = 0;
//            list = new object[length];
//        }

//        public void Add(object item)
//        {
//            if (count == list.Length)
//            {
//                Array.Resize(ref list, list.Length * 2);
//            }
//            list[count++] = item;
//        }



//        public void Remove(int index)
//        {
//            for (int a = index; a < list.Length - 1; a++)
//            {
//                list[a] = list[a + 1];
//            }
//        }



//        public void Clear()
//        {
//            count = 0;
//            list = new object[count];
//        }



//        public object Get(int index)
//        {
//            if (index < 0 || index >= list.Length)

//                throw new IndexOutOfRangeException("index");
//            return list[index];
//        }


//        public IEnumerator GetEnumerator()
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return list[i];
//            }
//        }
//    }
//}
