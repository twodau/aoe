using System;
using System.Collections.Generic;
using System.Text;

namespace Aoe3
{
    public  class Font
    {
         int size { get; set; }

         string familt { get; set; }

          string style { get; set; }

        public Font(int s,string f,string st)
        {
            this.size = s;
            this.familt = f;
            this.style = st;
        }

           
    }
}
