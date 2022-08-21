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
                
               //  string data = File.ReadAllText(path);
              //   Console.WriteLine(data);
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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            string path = "C:\\Users\\NITISH MEHTA\\OneDrive\\Desktop\\CsharpPracticeSection\\CsharpFile_IO\\CsharpFile_IO/My_Directory";
            string path2 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO/My_Directory2";
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            //  dir.Delete(true);
            //  dir.Create();
            //  dir.CreateSubdirectory("SubDirectory");
            //  dir.MoveTo(path2);
            Console.WriteLine("Get  files from Directory  by using (GetFiles) Method ");
            foreach (var item in dirs)
            {
                Console.WriteLine(item.GetFiles().Length);
            }
           // Console.WriteLine("Get complete path of  Directory Name by (FullName) Method ");
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item.FullName);
            //}
            //Console.WriteLine("Get main/parents Directory Name by (Parent) Method ");
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item.Parent);
            //}
            //Console.WriteLine("Getting the subdirectory ny using GetDirectories method");
            //Console.ReadLine();

        }
        public void FileStream()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO/MyFile.txt"; // @- verbatim Literal
            using (FileStream files = new FileStream(path, FileMode.Truncate,FileAccess.Write))
            {
                string data = "C# FileStream class provides a stream for file operation";
                byte[] write_data = Encoding.UTF8.GetBytes(data);
                files.Write(write_data, 0, data.Length);
                //files.WriteByte(78);
                //files.WriteByte(105);
                //files.WriteByte(116);
                //files.WriteByte(105);
                //files.WriteByte(115);
                //files.WriteByte(104);
                Console.WriteLine("Data Written Successfully");

            }

            // FileStream files = new FileStream(path, FileMode.Create);
            // Console.WriteLine("File created");
            // files.Close();
        }
        public void FileStreamWriter()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\CsharpPracticeSection\CsharpFile_IO\CsharpFile_IO/MyNewFile.txt";
            FileStream files = new FileStream(path,FileMode.Append,FileAccess.Write);
            StreamWriter Writer = new StreamWriter(files,Encoding.UTF8);

            int[] arr = {65,90,97,122,58,63 };
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (var item in arr)
            {
                Writer.Write(item + " ");
            }
            //Writer.WriteLine("StreamWriter class can be used to write text file.");
            //Writer.WriteLine("StreamWriter class in C# writes characers to a stream in a specified encoding.");
            //Writer.WriteLine("StreamWritter.Write() method is responsible for writing text to a stream");


            Console.WriteLine("Data Written Successfully");
            Console.ReadKey();
            Writer.Close();
            files.Close();
        }
    }
}
