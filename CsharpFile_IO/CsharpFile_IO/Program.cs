using CsharpFile_IO;

Console.WriteLine("Hello, World!");

FileExistsOrNot file = new FileExistsOrNot();
file.check();
file.ReadAllText();
file.StreamReader();

// Copy the from one to another file by using Copy Method
file.CopyData();

//"""""""""""""""""""""""""""DirectoryInfo"""""""""""""""""""""""""""""""""""""""""""""""""""
file.DirectoryInfo();

//"""""""""""""""""""""""""""FileStream"""""""""""""""""""""""""""""""""""""""""""""""""""

file.FileStream();

//"""""""""""""""""""""""""""FileStreamWriter"""""""""""""""""""""""""""""""""""""""""""""""""""

file.FileStreamWriter();

