using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDemo1
{
    public class Studente
    {
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Indirizzo { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Nome = {Nome}, Cognome = {Cognome}, Indirizzo = {Indirizzo}";
        }
    }
}
