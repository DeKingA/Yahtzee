using System;

namespace Yahtzee
{
    public class Dice
    {
        


        public static int Die1()
        {
            Random rnd1 = new Random();
            return Prop.die1 = rnd1.Next(1, 7);
        }

        public static int Die2()
        {
            Random rnd2 = new Random();
            return Prop.die2 = rnd2.Next(1, 7);
        }

        public static int Die3()
        {
            Random rnd3 = new Random();
            return Prop.die3 = rnd3.Next(1, 7);
        }

        public static int Die4()
        {
            Random rnd4 = new Random();
            return Prop.die4 = rnd4.Next(1, 7);
        }

        public static int Die5()
        {
            Random rnd5 = new Random();
            return Prop.die5 = rnd5.Next(1, 7);
        }

       
    }
}
