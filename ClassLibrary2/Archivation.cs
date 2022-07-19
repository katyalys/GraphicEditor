using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using laba1_OOP;

namespace ClassLibrary2
{
    public class Archivation: IPluginGeneral
    {
        public string Name
        {
            get
            {
                return "ArchivationPlugin.dll";
            }
        }


        public async Task CompressAsync(string sourceFile1, string compressedFile1)
        {
            // поток для чтения исходного файла
            FileStream sourceStream = new FileStream(sourceFile1, FileMode.OpenOrCreate);
            // поток для записи сжатого файла
            FileStream targetStream = File.Create(compressedFile1);

            // поток архивации
            using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                await sourceStream.CopyToAsync(compressionStream); // копируем байты из одного потока в другой

            sourceStream.Close();
            targetStream.Close();
        }

        public async Task DecompressAsync(string compressedFile, string targetFile)
        {
            // поток для чтения из сжатого файла
            FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate);
            // поток для записи восстановленного файла
            FileStream targetStream = File.Create(targetFile);
            // поток разархивации
            using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                await decompressionStream.CopyToAsync(targetStream);

            sourceStream.Close();
            targetStream.Close();
        }
    }
}
