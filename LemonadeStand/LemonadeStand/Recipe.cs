using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        private int cupQty;
        private int lemonQty;
        private int sugarQty;
        private int iceCubesQty;

        public int CupQty
        {
            get { return cupQty; }
            set { cupQty = value; }
        }

        public int LemonQty
        {
            get { return lemonQty; }
            set { lemonQty = value; }
        }

        public int SugarQty
        {
            get { return sugarQty; }
            set { sugarQty = value; }
        }

        public int IceCubesQty
        {
            get { return iceCubesQty; }
            set { iceCubesQty = value; }
        }

        public Recipe(int cupQty, int lemonQty, int sugarQty, int iceCubesQty)
        {
            this.cupQty = cupQty;
            this.lemonQty = lemonQty;
            this.sugarQty = sugarQty;
            this.iceCubesQty = iceCubesQty;
        }

    }
}
