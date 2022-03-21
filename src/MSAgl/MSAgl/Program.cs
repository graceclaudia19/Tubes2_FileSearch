using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    class ViewerSample
    {
        // Untuk cek directory empty atau ga
        //public bool IsDirectoryEmpty(string path)
        //{
        //    return !Directory.EnumerateFileSystemEntries(path).Any();
        //}
        public int unique = 0;
        public static string[] DFS(string folderpath, string start, string fileToSearch, bool checkAllOccur, Microsoft.Msagl.Drawing.Graph graph)
        {
            string[] files = Directory.GetFiles(start);
            bool found = false;
            List<string> res = new List<string>();

            foreach (string file in files)
            {
                res.Add(file);
                // Bikin graph
                graph.AddEdge(start, file);
                graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                graph.FindNode(file).Label.Text = new DirectoryInfo(file).Name;
                graph.FindNode(start).Label.Text = new DirectoryInfo(start).Name;
                graph.FindNode(start).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;

                if (file.Contains(fileToSearch))
                {
                    res.Add("?");
                    found = true;
                    // Warnain biru
                    string root = Path.GetDirectoryName(file);
                    graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                    graph.FindNode(folderpath).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                    while (root != folderpath)
                    {
                        graph.FindNode(root).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                        root = Path.GetDirectoryName(root);
                    }
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
                    
                    // Bikin graph
                    graph.AddEdge(start, folder);
                    graph.FindNode(folder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                    graph.FindNode(folder).Label.Text = new DirectoryInfo(folder).Name;
                    graph.FindNode(start).Label.Text = new DirectoryInfo(start).Name;
                    graph.FindNode(start).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                    
                    string[] temp = DFS(folderpath, folder, fileToSearch, checkAllOccur, graph);
                    res.AddRange(temp);

                    if (!checkAllOccur)
                    {
                        return res.ToArray();
                    }
                }
                return res.ToArray();
            }
        }

        public static string[] BFS(string start, string fileToSearch, bool checkAllOccur, Microsoft.Msagl.Drawing.Graph graph)
        {
            bool found = false;
            Queue<string> q = new Queue<string>();
            List<string> output = new List<string>();

            q.Enqueue(start);

            while (q.Count > 0)
            {
                string startDir = q.Dequeue();
                output.Add(startDir);

                string[] files = Directory.GetFiles(startDir);
                foreach (string file in files)
                {
                    output.Add(file);
                    // Bikin graph
                    graph.AddEdge(startDir, file);
                    graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                    graph.FindNode(file).Label.Text = new DirectoryInfo(file).Name;
                    graph.FindNode(startDir).Label.Text = new DirectoryInfo(startDir).Name;
                    graph.FindNode(startDir).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                    
                    if (file.Contains(fileToSearch))
                    {
                        found = true;
                        output.Add("?");
                        // Warnain biru
                        string root = Path.GetDirectoryName(file);
                        graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                        graph.FindNode(start).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                        while (root != start)
                        {
                            graph.FindNode(root).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                            root = Path.GetDirectoryName(root);
                        }
                    }
                }
                if (found && !checkAllOccur)
                {
                    break;
                }
                string[] otherDir = Directory.GetDirectories(startDir);
                foreach (string dir in otherDir)
                {
                    // Bikin graph
                    graph.AddEdge(startDir, dir);
                    graph.FindNode(dir).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                    graph.FindNode(dir).Label.Text = new DirectoryInfo(dir).Name;
                    graph.FindNode(startDir).Label.Text = new DirectoryInfo(startDir).Name;
                    graph.FindNode(startDir).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;

                    q.Enqueue(dir);
                }
            }
            return output.ToArray();
        }



        // for testing purpose
        public static void handleGraph(string folderPath, Microsoft.Msagl.Drawing.Graph graph)
        {
            string[] files = Directory.GetFiles(folderPath);
            string parent = new DirectoryInfo(folderPath).Name;
            string[] dirs = Directory.GetDirectories(folderPath);
            //System.IO.DirectoryInfo[] subDirs = null;

            foreach (string dir in dirs)
            {
                string folder = new DirectoryInfo(dir).Name;
                graph.AddEdge(parent, folder);
                Console.WriteLine(folder);
            }
            foreach (string file in files)
            {
                //Console.WriteLine(file);
                // Dapetin nama file
                string filename = new DirectoryInfo(file).Name;
                Console.WriteLine(filename);
                // Dapetin nama folder
                string folderName = new DirectoryInfo(System.IO.Path.GetDirectoryName(file)).Name;
                Console.WriteLine(folderName);
                graph.AddEdge(parent, filename);
            }
        }

        public static void makeGraph(Microsoft.Msagl.Drawing.Graph graph)
        {
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
        }
        public static void Main()
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //makeGraph(graph);
            //handleGraph(@"C:\Users\Rania\Desktop\SEMESTER 4\Stima\Tubes2_FileSearch\src\MSAgl\Test", graph);
            //string[] resultDFS = DFS(@"C:\Users\Rania\Desktop\SEMESTER 4\Stima\Tubes2_FileSearch\src\MSAgl\testFolder", @"C:\Users\Rania\Desktop\SEMESTER 4\Stima\Tubes2_FileSearch\src\MSAgl\testFolder", "found1.txt", false, graph);
            string[] resultBFS = BFS(@"C:\Users\Rania\Desktop\SEMESTER 4\Stima\Tubes2_FileSearch\src\MSAgl\testFolder", "found1.txt", true, graph);
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();

            // DFS testing
            //string[] resultDFS = DFS(@"C:\Users\Rania\Desktop\SEMESTER 4\Stima\Tubes2_FileSearch\src\MSAgl\testFolder", "found.txt", false, graph);
            //foreach (string res in resultDFS)
            //{
            //    Console.WriteLine(res);
            //}

            // // BFS testing
            // string[] resultBFS = BFS("testFolder", "found.txt", true);
            // foreach (string res in resultBFS)
            // {
            //     Console.WriteLine(res);
            // }
        }
    }
}