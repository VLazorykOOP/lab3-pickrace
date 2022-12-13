using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Animal
    {
        public string Name;
        private int Weight;
        protected int Type;
        public Animal(int W, int T, string N)
        {
            Weight = W;
            Type = T;
            Name = N;
        }
        public Animal()
        {
            Weight = 0;
            Type = 0;
            Name = "NoName";
        }
        public int WWeight
        {
         set { Weight = value; }
        get { return Weight; }

        }
        public int TType
    {
        set { Type = value; }
        get { return Type; }
    }

        public override string ToString()
        {
            return base.ToString() + " : " + Name + "," + Type + ", "+ Weight ;
        }

    }

