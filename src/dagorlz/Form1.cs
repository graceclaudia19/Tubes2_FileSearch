

using System.Windows.Media;
using Color = System.Drawing.Color;
using System.IO;

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
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                graphPanel_Paint.Items.Clear();

            }

            chosenDir.Text = folderBrowserDialog.SelectedPath.ToString();
            chosenDir.BackColor = System.Drawing.SystemColors.Control;
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchBFS_Click(object sender, EventArgs e)
        {
            searchBFS.Text = "OK";
            createGraph();
        }

        private void searchDFS_Click(object sender, EventArgs e)
        {
            searchDFS.Text = "OK";
            createGraph();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            if (inputName.Text != "")
            {
                inputName.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                inputName.BackColor = System.Drawing.SystemColors.Info;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            createGraph();
        }
        private async void createGraph()
        {
            graphPanel.Controls.Clear();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            string[] temp = { "A", "B", "C", "D" };
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (i != 0) await Task.Delay(800);
                graph.AddEdge(temp[i], temp[i+1]);
                viewer.Graph = graph;
                //viewer.OutsideAreaBrush = Brushes.White;
                graphPanel.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                graphPanel.Controls.Add(viewer);
            }
            graphPanel.ResumeLayout();
            // graph.AddEdge("A", "B");
            // graph.AddEdge("B", "C");
            // graph.AddEdge("B", "D");
            // graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            // graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            // graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            // Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            // c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            // c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            // //bind the graph to the viewer 
            // viewer.Graph = graph;
            // viewer.OutsideAreaBrush = Brushes.White;
            // //associate the viewer with the form
            // graphPanel.SuspendLayout();
            // viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            // graphPanel.Controls.Add(viewer);
            // graphPanel.ResumeLayout();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(219, 228, 216);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}