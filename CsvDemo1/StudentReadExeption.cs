using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDemo1
{
    internal class StudentReadExeption: Exception
    {
        string messaggioErrore;
        public StudentReadExeption(string messaggio)
        {
            messaggioErrore = messaggio;
        }
        public StudentReadExeption():this("Un campo è nullo o spaio vuoto")
        {
            
        }
        public override string Message
        {
            get
            {
                return messaggioErrore;
            }
        }
        public int MyProperty { get; set; }
    }
}
