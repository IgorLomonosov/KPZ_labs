using System;
using ClassLibraryTask5;
namespace task5
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            editor.LoadDocument("Hello, World!");

            editor.Save();
            editor.PrintDocument();

            editor.LoadDocument("This is a new document.");
            editor.PrintDocument();

            editor.Undo();
            editor.PrintDocument();

            editor.Undo();
        }
    }
}