using DGrok.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DGrok.Playground {
    class Program {
        public static Encoding GetFileEncoding(string srcFile) {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];
            FileStream file = new FileStream(srcFile, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;
            else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                // 1201 unicodeFFFE Unicode (Big-Endian)
                enc = Encoding.GetEncoding(1201);
            else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                // 1200 utf-16 Unicode
                enc = Encoding.GetEncoding(1200);


            return enc;
        }

        static void ParseFile(string filePath) {
            var fileLoader = new FileLoader();
            var content = File.ReadAllText(filePath, GetFileEncoding(filePath));
            var parser = Parser.FromText(content, filePath, CompilerDefines.CreateStandard(), fileLoader);
            var parseTree = parser.ParseRule(RuleType.Goal);
        }

        static void Main(string[] args) {
            ParseFile(@"H:\Work\VK60EditObjekte.pas");


            var matches = new List<string>();
            var fileLoader = new FileLoader();
            
            var path = @"D:\DelphiXE\FW";
            foreach (var filePath in Directory.EnumerateFiles(path, "*.pas", SearchOption.TopDirectoryOnly)) {
                if (Path.GetFileName(filePath).StartsWith("frx") || Path.GetFileName(filePath).StartsWith("frEngine")) {
                    continue;
                }

                try {
                    var content = File.ReadAllText(filePath, GetFileEncoding(filePath));
                    var parser = Parser.FromText(content, filePath, CompilerDefines.CreateStandard(), fileLoader);
                    var parseTree = parser.ParseRule(RuleType.Goal);
                } catch(Exception ex) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error in " + filePath);
                    Console.ResetColor();
                    Directory.CreateDirectory("Errors");
                    File.WriteAllText(Path.Combine("Errors", Path.GetFileNameWithoutExtension(filePath) + " " + DateTime.UtcNow.ToString("HHmmssffff") + ".txt"), ex.ToString());
                }
            }

                    
                    
            //var filePath = @"D:\ParseTest.pas";
            //filePath = @"D:\DelphiXE\FW\VK60EditObjekte.pas";
            //var content = File.ReadAllText(filePath);
            //var parser = Parser.FromText(content, filePath, CompilerDefines.CreateStandard(), new FileLoader());
            //var parseTree = parser.ParseRule(RuleType.Goal);

        }
    }
}
