

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

        public class hyperlinks
        {
            public string hyperlink_name { get; set; }
            public string hyperlink_link { get; set; }
        }

        List<hyperlinks> hll = new List<hyperlinks>();
        int id = 0;
        private async void handleGraph(string[] Result, bool checkAllOccur, bool BFS)
        {   
            //clear listbox and hyperlinks
            hll.Clear();
            listBox1.Items.Clear();

            // disable related buttons, trackbar, & hyperlink
            this.searchBFS.Enabled = false;
            this.searchDFS.Enabled = false;
            this.trackBar1.Enabled = false;
            this.algorithmTime.Text = "0";

            // initialize graphviewer & panel display
            graphPanel.Controls.Clear();
            graphPanel.BackColor = Color.White;

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            viewer.OutsideAreaBrush = System.Drawing.Brushes.White;
            viewer.Size = graphPanel.Size;

            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            //startpath = direktori utama
            string startPath;
            if (BFS)
            {
                startPath = Result[0];
            } else
            {
                startPath = Path.GetDirectoryName(Result[0]);
            }

            //loop hasil
            for (int i = 0; i < Result.Length; i++)
            {   
                if (BFS && i==0)
                {
                    i = i+1;
                }

                // If result[i] = ?
                if (Result[i] == "?")
                {
                    // address temuan = sebelum ?
                    string foundfile = Result[i - 1];

                    // add hyperlink inside listbox
                    hyperlinks link = new hyperlinks();
                    link.hyperlink_name = foundfile;
                    link.hyperlink_link = foundfile;
                    listBox1.Items.Add(foundfile);
                    id++;
                    hll.Add(link);

                    graph.FindNode(startPath).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                    graph.FindNode(foundfile).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                    string parent = Path.GetDirectoryName(foundfile);
                    // loop ke atas ngewarnain biru
                    while (parent != startPath)
                    {
                        graph.FindNode(parent).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
                        parent = Path.GetDirectoryName(parent);
                    }
                }

                // cuma nyari 1 aja dan udah ketemu i pertama
                if (!checkAllOccur && Result[i] == "?")
                {
                    // tampilin ke layar
                    viewer.Graph = graph;
                    graphPanel.SuspendLayout();
                    viewer.Dock = DockStyle.Fill;
                    graphPanel.Controls.Add(viewer);
                    // Keluar
                    break;
                }

                // nyari semuanya dan result[i] = 0, lanjut
                if (checkAllOccur && Result[i] == "?")
                {
                    continue;
                }

                // Bikin graph
                if (i != 0) await Task.Delay(this.trackBar1.Value);
                string file = Result[i];
                string root = Path.GetDirectoryName(file);
                graph.AddEdge(root, file); // Bikin node antara file sama rootnya
                if (graph.FindNode(file).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightBlue)
                {
                    graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                }
                graph.FindNode(file).Label.Text = new DirectoryInfo(file).Name; //ganti textnya jadi nama file
                graph.FindNode(root).Label.Text = new DirectoryInfo(root).Name; //ganti textnya jadi nama root
                if (graph.FindNode(root).Attr.FillColor != Microsoft.Msagl.Drawing.Color.LightBlue)
                {
                    graph.FindNode(root).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightSalmon;
                }

                // Munculin graph
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
                    System.Diagnostics.Process.Start("explorer.exe", link.hyperlink_link);
                }
            }
        }
    }
}