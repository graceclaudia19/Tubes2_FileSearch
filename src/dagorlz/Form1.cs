

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
            folderBrowserDialog.ShowDialog();

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
                inputName.BackColor = System.Drawing.SystemColors.Desktop;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            createGraph();
        }
        private void createGraph()
        {
            graphPanel.Controls.Clear();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
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
            viewer.Graph = graph;
            viewer.OutsideAreaBrush = Brushes.White;
            //associate the viewer with the form
            graphPanel.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            graphPanel.Controls.Add(viewer);
            graphPanel.ResumeLayout();
        }
    }
}