using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_ffmpeg_mp3_converter;

namespace cs_ffmpeg_mp3_converter_samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Path.Combine(IOUtils.AssemblyDirectory, "..", "..", "..", "blues.00000.au");


            string mp3file = "converted.mp3";
            Console.WriteLine("Converting {0}", file);
            FFMpeg.Convert2Mp3(file, mp3file);
            if (!File.Exists(mp3file))
            {
                Console.WriteLine("Failed to convert to {0}", mp3file);
            }
        }
    }
}
