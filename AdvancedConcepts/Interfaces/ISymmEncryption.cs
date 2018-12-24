using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Interfaces
{
    public interface ISymmEncryption
    {

        string EncryptString(string inputText, string privateKey);
        string DecryptString(string inputText, string privateKey);

    }
}
