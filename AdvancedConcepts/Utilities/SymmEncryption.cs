using AdvancedConcepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Utilities
{
    public class SymmEncryption: ISymmEncryption
    {

        public string EncryptString(string inputText, string privateKey)
        {
            return "djldkdlldld";

        }

        public string DecryptString(string inputText, string privateKey)
        {
            return "plain text";
        }
    }
}
