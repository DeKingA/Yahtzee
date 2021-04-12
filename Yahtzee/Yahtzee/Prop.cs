using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Prop
    {
        public static int die1 { get; set; }
        public static int die2 { get; set; }
        public static int die3 { get; set; }
        public static int die4 { get; set; }
        public static int die5 { get; set; }

        public bool die1Hold { get; set; }
        public bool die2Hold { get; set; }
        public bool die3Hold { get; set; }
        public bool die4Hold { get; set; }
        public bool die5Hold { get; set; }
    }
}
