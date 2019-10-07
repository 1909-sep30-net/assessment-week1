using System;
using System.Collections.Generic;
using System.Text;

namespace ispalendrome
{
    class PalendromeChecker: IPalendromeTester
    {
        public string checkMe{ get; set; }

        public PalendromeChecker(string checkThis)
        {
            checkMe = checkThis;
        }

        public bool isPalendrome()
        {
            //check for input that is silly.
            if (checkMe == null || checkMe == "")
            {
                return false;
            }

            else if (checkMe.Length == 1)
            {
                // a single letter or number is a palendrome for now.
                return true;
            }
            
            //do the real check
            for(int i = 0; i < checkMe.Length/2; i++)
            {
                if(checkMe[i] != checkMe[checkMe.Length - i - 1])
                { 
                    return false;
                }
            }
            return true;
        }

    }
}
