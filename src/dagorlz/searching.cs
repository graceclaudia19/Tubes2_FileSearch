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
            string[] files = Directory.GetFiles(start);
            bool found = false;
            List<string> res = new List<string>();

            foreach (string file in files)
            {
                res.Add(file);
                if (file.Contains(fileToSearch))
                {
                    res.Add("?");
                    found = true;
                }
            }
            if (found)
            {
                return res.ToArray();
            }
            else
            {
                string[] folders = Directory.GetDirectories(start);
                foreach (string folder in folders)
                {
                    res.Add(folder);
                    string[] temp = DFS(folder, fileToSearch, checkAllOccur);
                    res.AddRange(temp);
                    
                    if (!checkAllOccur){
                        return res.ToArray();
                    }
                }
                return res.ToArray();
            }
        }

        public static string[] BFS(string start, string fileToSearch, bool checkAllOccur){
            bool found = false;
            Queue<string> q = new Queue<string>();
            List<string> output = new List<string>();

            q.Enqueue(start);

            while(q.Count>0){
                string startDir = q.Dequeue();
                output.Add(startDir);

                string[] files = Directory.GetFiles(startDir);
                foreach(string file in files){
                    output.Add(file);
                    if (file.Contains(fileToSearch)){
                        found = true;
                        output.Add("?");
                    }
                }
                if (found && !checkAllOccur){
                    break;
                }
                string[] otherDir = Directory.GetDirectories(startDir);
                foreach (string dir in otherDir){
                    res.Enqueue(dir);
                }
            }
            return output.ToArray();
        }



        // for testing purpose
        public static void Main(string[] args)
        {
            // // DFS testing
            // string[] resultDFS = DFS("testFolder", "found.txt", false);
            // foreach (string res in resultDFS)
            // {
            //     Console.WriteLine(res);
            // }

            // // BFS testing
            // string[] resultBFS = BFS("testFolder", "found.txt", true);
            // foreach (string res in resultBFS)
            // {
            //     Console.WriteLine(res);
            // }
        }

    }
}