

using System.Windows.Media;
using Color = System.Drawing.Color;
using System.IO;
using System;
using System.Diagnostics;
using System.Threading;

namespace dagorlz
{
    public partial class dagorlz : Form
    {
        public dagorlz()
        {
            InitializeComponent();
        }

        private void Dagorlz_Load(object sender, EventArgs e)
        {

        }

        private void selectDir_Click(object sender, EventArgs e)
        {
            // Mengganti warna & teks pada textbox chosen directory
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                chosenDir.Text = folderBrowserDialog.SelectedPath.ToString();
                chosenDir.BackColor = System.Drawing.SystemColors.Control;
            }

        }

         private void checkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchBFS_Click(object sender, EventArgs e)
        {
            // Special case (directory/file empty)
            if (this.chosenDir.BackColor == SystemColors.Info || this.inputName.BackColor == SystemColors.Info)
            {
                MessageBox.Show("Make sure to set start directory and target filename", "BFS Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                searchBFS.BackColor = SystemColors.ControlLight;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string[] resultBFS = Searching.BFS(folderBrowserDialog.SelectedPath.ToString(), inputName.Text, checkAll.Checked);
                stopwatch.Stop();
                handleGraph(resultBFS, checkAll.Checked, true);
                algorithmTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
        }

        private void searchDFS_Click(object sender, EventArgs e)
        {
            // Special case (directory/file empty)
            if (this.chosenDir.BackColor == SystemColors.Info || this.inputName.BackColor == SystemColors.Info)
            {
                MessageBox.Show("Make sure to set start directory and target filename", "DFS Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                searchDFS.BackColor = SystemColors.ControlLight;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string[] resultDFS = Searching.DFS(folderBrowserDialog.SelectedPath.ToString(), inputName.Text, checkAll.Checked);
                stopwatch.Stop();
                handleGraph(resultDFS, checkAll.Checked, false);
                algorithmTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            if (inputName.Text != "")
            {
                inputName.BackColor = SystemColors.Control;
            }
            else
            {
                inputName.BackColor = SystemColors.Info;
            }
        }

        // Class for hyperlinks
        public class hyperlinks
        {
            public string hyperlink_name { get; set; }
            public string hyperlink_link { get; set; }
        }

        // Create list of hyperlinks
        List<hyperlinks> hll = new List<hyperlinks>();
        private async void handleGraph(string[] Result, bool checkAllOccur, bool BFS)
        {   
            //clear listbox and hyperlinks
            hll.Clear();
            listBox1.Items.Clear();

            // disable related buttons, trackbar, & hyperlink
            this.searchBFS.Enabled = false;
            this.searchDFS.Enabled = false;
            this.trackBar1.Enabled = false;
            this.listBox1.Visible = true;
            this.listBox1.Enabled = true;
            this.algorithmTime.Text = "0";

            // initialize graphviewer & panel display
            graphPanel.Controls.Clear();
            graphPanel.BackColor = Color.White;

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            viewer.OutsideAreaBrush = System.Drawing.Brushes.White;
            viewer.Size = graphPanel.Size;

            // create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // startpath = main directory
            string startPath = Result[0];

            // loop
            for (int i = 1; i < Result.Length; i++)
            {   

                // if result[i] = ?
                if (Result[i] == "?")
                {
                    // path = before ?
                    string foundfile = Result[i - 1];

                    // add hyperlink inside listbox
                    hyperlinks link = new hyperlinks();
                    link.hyperlink_name = foundfile;
                    link.hyperlink_link = foundfile;
                    listBox1.Items.Add(foundfile);
                    hll.Add(link);

                    // change path color
                    graph.FindNode(startPath).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                    graph.FindNode(foundfile).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                    graph.FindNode(foundfile).Attr.LineWidth = 2;
                    string parent = Path.GetDirectoryName(foundfile);
                    // loop to the main directory
                    while (parent != startPath)
                    {
                        graph.FindNode(parent).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                        parent = Path.GetDirectoryName(parent);
                    }
                }

                // not all occur and file has been found
                if (!checkAllOccur && Result[i] == "?")
                {   
                    // print unvisited directory
                    for (int j = i+1; j < Result.Length; j++)
                    {
                        string folderuv = Result[j];
                        string rootuv = Path.GetDirectoryName(folderuv);
                        graph.AddEdge(rootuv, folderuv); // Create node
                        if (graph.FindNode(folderuv).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightBlue && graph.FindNode(folderuv).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightSalmon)
                        {
                            graph.FindNode(folderuv).Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
                        }
                        graph.FindNode(folderuv).Label.Text = new DirectoryInfo(folderuv).Name; // Change node name to folder name
                        graph.FindNode(rootuv).Label.Text = new DirectoryInfo(rootuv).Name; // Change node name to root name
                        if (graph.FindNode(rootuv).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightBlue && graph.FindNode(rootuv).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightSalmon)
                        {
                            graph.FindNode(rootuv).Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
                        }
                    }

                    // show
                    viewer.Graph = graph;
                    graphPanel.SuspendLayout();
                    viewer.Dock = DockStyle.Fill;
                    graphPanel.Controls.Add(viewer);
                    // quit
                    break;
                }

                // find all occur and result[i] = ?, lanjut
                if (checkAllOccur && Result[i] == "?")
                {
                    continue;
                }

                // create new edge
                if (i != 0) await Task.Delay(this.trackBar1.Value);
                string folder = Result[i];
                string root = Path.GetDirectoryName(folder);
                graph.AddEdge(root, folder); // Create node
                if (graph.FindNode(folder).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightBlue)
                {
                    graph.FindNode(folder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                }
                graph.FindNode(folder).Label.Text = new DirectoryInfo(folder).Name; // Change node name to folder name
                graph.FindNode(root).Label.Text = new DirectoryInfo(root).Name; // Change node name to root name
                if (graph.FindNode(root).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightBlue)
                {
                    graph.FindNode(root).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                }

                // show
                viewer.Graph = graph;
                graphPanel.SuspendLayout();
                viewer.Dock = DockStyle.Fill;
                graphPanel.Controls.Add(viewer);
            }
            graphPanel.ResumeLayout();

            // reset view
            this.trackBar1.Enabled = true;
            this.searchBFS.Enabled = true;
            this.searchDFS.Enabled = true;
            this.searchDFS.BackColor = Color.Transparent;
            this.searchBFS.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelDetail2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar1.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chosenDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {
        
        }

        private void algorithmTime_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(219, 228, 216);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (hyperlinks link in hll)
            {
                if (listBox1.SelectedItem.ToString() == link.hyperlink_link.ToString())
                {
                    string parent = Path.GetDirectoryName(link.hyperlink_link.ToString());
                    System.Diagnostics.Process.Start("explorer.exe", parent);
                }
            }
        }
    }
}