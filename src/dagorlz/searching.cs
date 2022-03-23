using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace dagorlz
{
    public class Searching
    {
        public static string[] DFS(string start, string fileToSearch, bool checkAllOccur)
        {
            // Initialize parameter found, stack, dan list
            bool found = false;
            Stack<string> s = new Stack<string>();
            List<string> output = new List<string>();

            // Push main dir as the first stack element
            s.Push(start);

            // loop until stack is empty
            while (s.Count > 0)
            {
                // Initialize starting directory
                string startDir = s.Pop();
                output.Add(startDir);

                // Find file
                string[] files = Directory.GetFiles(startDir);
                foreach (string file in files)
                {
                    if (file.Contains(fileToSearch) && fileToSearch == new DirectoryInfo(file).Name)
                    {
                        output.Add(file);
                        found = true;
                        output.Add("?");
                    }
                }

                // File found and x all occur
                if (found && !checkAllOccur)
                {   
                    // Add unvisited stack to the output list
                    int count = s.Count;
                    for (int i = 0; i < count; i++)
                    { 
                        output.Add(s.Pop());
                    }
                    break;
                }

                // Push all directories inside starting directory
                string[] otherDir = Directory.GetDirectories(startDir);
                foreach (string dir in otherDir)
                {
                    s.Push(dir);
                }

            }

            return output.ToArray();
        }

        public static string[] BFS(string start, string fileToSearch, bool checkAllOccur){
            // Initialize parameter found, queue, dan list
            bool found = false;
            Queue<string> q = new Queue<string>();
            List<string> output = new List<string>();

            // Enqueue main dir as the first stack element
            q.Enqueue(start);

            // loop until queue is empty
            while (q.Count>0){
                // Initialize starting directory
                string startDir = q.Dequeue();
                output.Add(startDir);

                // find file
                string[] files = Directory.GetFiles(startDir);
                foreach(string file in files){
                    if (file.Contains(fileToSearch) && fileToSearch == new DirectoryInfo(file).Name){
                        output.Add(file);
                        found = true;
                        output.Add("?");
                    }
                }

                // File found and x all occur
                if (found && !checkAllOccur)
                {
                    // Add unvisited queue to the output list
                    int count = q.Count();
                    for (int i = 0; i < count; i++)
                    {
                        output.Add(q.Dequeue());
                    }
                    break;
                }

                // Enqueue all directories inside starting directory
                string[] otherDir = Directory.GetDirectories(startDir);
                foreach (string dir in otherDir){
                    q.Enqueue(dir);
                }
            }

            return output.ToArray();
        }

        //for testing purpose
        //public static void Main(string[] args)
        //{
            // DFS testing
            // string[] resultDFS = DFS("2", "found.txt", false);
            // foreach (string res in resultDFS)
            // {
            //    Console.WriteLine(res);
            // }

            // // BFS testing
            // string[] resultBFS = BFS("testFolder", "found.txt", true);
            // foreach (string res in resultBFS)
            // {
            //     Console.WriteLine(res);
            // }
        //}

    }
}