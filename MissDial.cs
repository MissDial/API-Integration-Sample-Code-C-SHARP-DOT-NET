using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MissDial
{
    public class MissDial
    {
        //Declare number of caller
        private string number;
        //Declare datetime of caller
        private string Datetime;
        //Declare the area from where caller called
        private string Circle;
        //shows the caller operator
        private string Mob_Operator;
        //Define that number is dnd or not
        private string Dnd;
        //Define the country code
        private string Prefix;

        //constructor  gives value of variable
        public MissDial(string num, string dtTime = "", string circles = "", string mobOperator = "", string Dnds = "", string prefixs = "")
        {
            number = num;
            Datetime = dtTime;
            Circle = circles;
            Mob_Operator = mobOperator;
            Dnd = Dnds;
            Prefix = prefixs;
        }

        public string getNumber
        {
            get { return number; }
            set { number = value; }
        }

        public string getDateTime
        {
            get { return Datetime; }
            set { Datetime = value; }
        }

        public string getCircle
        {
            get { return Circle; }
            set { Circle = value; }
        }

        public string getMobOperator
        {
            get { return Mob_Operator; }
            set { Mob_Operator = value; }
        }

        public string getDnd
        {
            get { return Dnd; }
            set { Dnd = value; }
        }

        public string getPrefix
        {
            get { return Prefix; }
            set { Prefix = value; }
        }

    }
}