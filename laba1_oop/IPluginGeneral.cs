using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_OOP
{
    public interface IPluginGeneral
    { 
        Task CompressAsync(string sourceFile1, string compressedFile1);

        Task DecompressAsync(string compressedFile, string targetFile);
    }

}
