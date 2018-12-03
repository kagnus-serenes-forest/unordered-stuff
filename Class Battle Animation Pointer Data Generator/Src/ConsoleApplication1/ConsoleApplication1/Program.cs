using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BMPPaletteImporter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 2) {
                Bitmap  img = new Bitmap(args[0]),
                        pal = new Bitmap(args[1]);

                img.Palette = pal.Palette;
                
                String outputFile = args[0];

                if (args.Length > 2) {
                    outputFile = args[2];
                }

                img.Save(outputFile);
            }
        }
    }
}
