using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Layer
    {
        int selectedItemIndex;//new integer that will select index of files and directories
        public FileSystemInfo[] Items//new array with methods
        {
            get;
            set;
        }
        public int SelectedItemIndex//new parameter
        {
            get
            {
                return selectedItemIndex;
            }
            set
            {
                if (value >= Items.Length)//if value more than array's length
                {
                    selectedItemIndex = 0;
                }
                else if (value < 0)
                {
                    selectedItemIndex = Items.Length - 1;
                }
                else
                {
                    selectedItemIndex = value;
                }
            }
        }
        public Layer(FileSystemInfo[] items)//new method with parameters
        {
            selectedItemIndex = 0;
            this.Items = items;
        }
        public void Draw()//new function draw that will draw background, foreground of files and directories
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            int i = 0;
            foreach (var t in Items)//foreach elements
            {
                if (t is DirectoryInfo)//if element is directory
                {
                    Console.ForegroundColor = ConsoleColor.White;//foreground is white
                    if (i == selectedItemIndex)//if it is selected
                    {
                        Console.BackgroundColor = ConsoleColor.Red;//background is red
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;//background is black
                    }
                    Console.WriteLine(i + 1 + ". " + t.Name);//writes indexes with names
                    i++;
                }
            }
            foreach (var t in Items)
            {
                if (t is FileInfo)//if element is file
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//foreground is yellow
                    if (i == selectedItemIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(i + 1 + ". " + t.Name);
                    i++;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\users\Aruzhan\desktop\cpp\");//new directory with path
            Stack<Layer> history = new Stack<Layer>();//layers will be stack
            history.Push(new Layer(dir.GetFileSystemInfos()));//pushes to the stack all the layers in the directory
            bool quit = false;
            while (!quit)//while true
            {
                history.Peek().Draw();//selected item index is 0 and was drawn
                ConsoleKeyInfo pressedKey = Console.ReadKey();//pushing button on the keyboard
                if (pressedKey.Key == ConsoleKey.UpArrow)//if uparrow
                {
                    history.Peek().SelectedItemIndex--;//index will decrease
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)//if downarrow
                {
                    history.Peek().SelectedItemIndex++;//index will increase
                }
                else if (pressedKey.Key == ConsoleKey.Enter)//if enter new layer will open
                {
                    int x = history.Peek().SelectedItemIndex;
                    if (history.Peek().Items[x] is DirectoryInfo)//if selected element is directory
                    {
                        DirectoryInfo y = history.Peek().Items[x] as DirectoryInfo;
                        history.Push(new Layer(y.GetFileSystemInfos()));//opens a new layer
                    }
                    else
                    {
                        FileInfo fi = history.Peek().Items[x] as FileInfo;//if selected element is file
                        string fn = history.Peek().Items[x].FullName;
                        StreamReader sr = fi.OpenText();//reads that text file
                        string file = sr.ReadToEnd();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.Write(file);//writes that file
                        Console.ReadKey();//to not to close console
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Backspace)//if backspace
                {
                    history.Pop();//pops that layer
                }
                else if (pressedKey.Key == ConsoleKey.Escape)//if escape
                {
                    quit = true;//quits
                }
                else if (pressedKey.Key == ConsoleKey.Delete)//if delete
                {
                    int si = history.Peek().SelectedItemIndex;
                    FileSystemInfo fsi = history.Peek().Items[si];
                    fsi.Delete();
                    history.Peek().SelectedItemIndex--;

                }
            }
            Console.ReadKey();
        }
    }
}
