using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //file Reading from the current diretory.(Staying in the c# bin folder)
            var filetext = File.ReadAllText("files/myText.txt");
            Console.WriteLine(filetext);
            string[] lines = File.ReadAllLines("files/myText.txt");//just reading the file line by line and using array is mandatory
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            File.Encrypt("files/myText.txt");
            File.Decrypt("files/myText.txt");


            var content = "We are working with Files";
            File.WriteAllText("files/newFiles.txt", content);
            File.Delete("files/Delete.txt");
            #region AppendAllTexts

            string aPath = @"files/AppendFile.txt";

            // This text is added only once to the file.
            if (!File.Exists(aPath))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(aPath, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(aPath, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(aPath);
            Console.WriteLine(readText);

            #endregion
            #region appendalllines
            string filePath = "files/myText.txt";

            List<string> names = new List<string>();
            names.Add("mridul");
            names.Add("upama");
            names.Add("bijoy");
            names.Add("muba");
            names.Add("sultan");

            File.AppendAllLines(filePath, names);

            var fileText = File.ReadAllText(filePath);
            Console.WriteLine(fileText);

            #endregion
            //File.AppendAllLINES();
            #region CopyFile

            var pathC = @"files/CopyFile.txt";
            var pathCd = @"files/CopiedFile.txt";
            //File.Copy(pathC, pathCd);

            #endregion
            #region FileMovingOPeration
            var pathS = @"files/Source.txt";//tgis file already created from the beginning
            var pathD = @"files/Desti.txt";//This file will create after the program will run
            //File.Move(pathS, pathD);
            #endregion
            #region justCreateAppendAndReadaFile

            string path = "files/newfile.txt";
            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(path))
            {
                //byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                byte[] info = Encoding.Unicode.GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            using (FileStream fs = File.Open(path, FileMode.Append))
            {
                byte[] info = Encoding.Unicode.GetBytes("\nThis is the second text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }


            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            #endregion
            var openFile = File.Open(pathC, FileMode.Open);
            //Console.WriteLine(openFile);
            #region File.OpenRead

            string pathO = @"files/newFiles.txt";

            if (!File.Exists(pathO))
            {
                // Create the file.
                using (FileStream fs = File.Create(pathO))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            // Open the stream and read it back.
            using (FileStream fs2 = File.OpenRead(pathO))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs2.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
               


            }
            #endregion
            */
            var files = Directory.GetFiles("files/");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Directory.CreateDirectory("files/test");
            Directory.Delete("files/test");
            var CD=Directory.GetCurrentDirectory();
            Console.WriteLine(CD);

            string sourceDirectory = @"files\source";
            string destinationDirectory = @"files\destination";
            //Directory.Move(sourceDirectory, destinationDirectory);
            Console.WriteLine(Directory.GetParent("files"));
            Console.WriteLine(Directory.GetDirectoryRoot("files"));
        }
    }
}
