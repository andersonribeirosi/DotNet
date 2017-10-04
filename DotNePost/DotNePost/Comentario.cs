using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNePost
{
    public class Comentario
    {
        public int id { get; set; }
        public string comentario { get; set; }
        public string autor { get; set; }
        public DateTime data { get; set; }
        
    }
}