using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMvc5Test.IOC
{
   public interface ILog
    {
        string Write(string msg);
    }
    public class Log : ILog
    {
        public string Write(string msg)
        {
            return msg +":"+DateTime.Now;
        }
    }

}

