using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This Namespace is used for performing operations with files

namespace CsharpFile_IO
{
    public class FileExistsOrNot
    {
        public void check()
        {
            string path = "C:\\Users\\NITISH MEHTA\\OneDrive\\Desktop\\CsharpPracticeSection\\CsharpFile_IO\\CsharpFile_IO\\File_IO.txt";
            // .Exists -- method is used to check that a particular file exists or not.
            if (File.Exists(path))  // checking that files path which has given it is exists or not.
            {
                Console.WriteLine("Yes, the file exists");
                
               //    ReadAllText(String) is used for Opens a text file, reads all the text in the file,
               //    and then closes the file.
                
               // string data = File.ReadAllText(path);
              //  Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
         public void ReadAllText()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO\FileExistsOrNot.cs";
            // .Exists -- method is used to check that a particular file exists or not.
            if (File.Exists(path))  // checking that files path which has given it is exists or not.
            {
                Console.WriteLine("Yes, the file exists");


                // ReadAllText(String) is used for Opens a text file, reads all the text in the file,
                // and then closes the file.
               // Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public void StreamReader()
        {
            FileStream f = new FileStream("C:\\Users\\NITISH MEHTA\\OneDrive\\Desktop\\CsharpPracticeSection\\CsharpFile_IO\\CsharpFile_IO\\File_IO.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            // ReadLine() methods to read data from the stream.
            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
        }
        public void CopyData()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO\File_IO.txt";
            // path to path2 Copy the data in the same folder
            string path2 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO\CopyFile\CopydataFile_IO.txt";
            // path to path3 Copy the data in the in new (CopyFile) folder
            string path3 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO\CopyFile\CopydataFile_IO.txt";
            
            File.Copy(path, path3,true);
        }
        public void DirectoryInfo()
        {
            string path = "C:\\Users\\NITISH MEHTA\\OneDrive\\Desktop\\CsharpPracticeSection\\CsharpFile_IO\\CsharpFile_IO/My_Directory";
            DirectoryInfo dir = new DirectoryInfo(path);
            //  dir.Create();
            dir.CreateSubdirectory("SubDirectory");
            Console.WriteLine("New Directory Created");
            Console.ReadLine();

        }
    }
}
