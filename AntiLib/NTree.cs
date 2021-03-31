using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiLib
{

    public class NTree
    {
        private NTree l = null;
        private NTree r = null;
        private byte[] value = null;

        private NTree() { }
        public NTree(List<byte[]> list)
        {
            for (int i = 0; i < list.Count - 2; i++)
            {
                switch (isEquil(list[i], list[i + 1]))
                {
                    case 1:
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        break;
                }
            }

            var intList = new List<int>();
            foreach(var ib in list)
            {
                if (BitConverter.IsLittleEndian) Array.Reverse(ib);
                intList.Add(BitConverter.ToInt32(ib, 0));
            }
            AllocationTree(intList, this);
        }

        private void AllocationTree(List<int> list, NTree nTree)
        {
            var avr = list.Average();
            int index = 0;
            var num = Math.Abs(list[0]-avr);

            for(int i = 0; i<list.Count;i++)
            {
                if (Math.Abs(list[i] - avr) < num)
                {
                    num = Math.Abs(list[i] - avr);
                    index = i;
                }
            }

            nTree.value = BitConverter.GetBytes(list[index]);
            if (index > 0)
            {
                nTree.l = new NTree();
                AllocationTree(list.GetRange(0, index), nTree.l);
            }
            if (index < list.Count - 1)
            {
                nTree.r = new NTree();
                AllocationTree(list.GetRange(index + 1, list.Count - index - 1), nTree.r);
            }
        }



        public NTree(byte[] value)
        {
            this.value = value;
        }
        
        public void addLeft(NTree left)
        {
            l = left;
        }
        public void addRight(NTree left)
        {
            l = left;
        }

        public bool isValue(byte[] value)
        {
            //Console.WriteLine(value[3] + " ?=? " + this.value[3]);
            switch (isEquil(value, this.value))
            {
                case -1:
                    //Console.WriteLine(value[3] + " < " + this.value[3]);
                    if (l != null) return l.isValue(value);
                    else return false;
                    break;
                case 0:
                    //Console.WriteLine(value[3] + " = " + this.value[3]);
                    return true;
                    break;
                case 1:
                    //Console.WriteLine(value[3] + " > " + this.value[3]);
                    if (r != null) return r.isValue(value);
                    else return false;
                    break;
            }
            return true;
        }

        public int isEquil(byte[] a, byte[] b)
        {
            for(int i = 0; i < a.Length; i++){
                if (a[i] > b[i]) return 1;
                if (a[i] < b[i]) return -1;
            }
            return 0;
        }
    }
}
