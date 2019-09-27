using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookieOrderApp
{
    public class CookieOrder
    {
        CookieOrder Order = new CookieOrder();
        public string Variety { get; set; }
        public int NumBoxes { get; set; }

        

        

        public virtual void CookieNumBoxes()
        {

        }

        //public virtual void NewCookieOrder(string variety, int numBoxes)
        //{
        //    Variety = variety;
        //    NumBoxes = numBoxes;
        //}
    }
}
