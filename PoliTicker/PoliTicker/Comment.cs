using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliTicker
{
    public class Comment
    {
        public string message { get; set; }
        public int value { get; set; }

        public Comment(string msg, int value)
        {
            this.message = msg;
            this.value = value;
        }
    }
}
