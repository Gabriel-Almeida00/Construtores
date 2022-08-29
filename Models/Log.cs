using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log ?log;

        public string PropriedadeLog { get; set; }

        private  Log()
        {
           PropriedadeLog = string.Empty;
        }

        public static Log GetInstance()
        {
            if (log == null)
            {
                log = new Log(); 
            }
            return log;
        }
    }
}