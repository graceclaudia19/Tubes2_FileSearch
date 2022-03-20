

using System.Windows.Media;
using Color = System.Drawing.Color;

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
            if (this.chosenDir.BackColor == System.Drawing.SystemColors.Info || this.inputName.BackColor == System.Drawing.SystemColors.Info)
            {
                MessageBox.Show("Make sure to set start directory and target filename", "BFS Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                createGraph();
            }
        }

        private void searchDFS_Click(object sender, EventArgs e)
        {
            if (this.chosenDir.BackColor == System.Drawing.SystemColors.Info || this.inputName.BackColor == System.Drawing.SystemColors.Info)
            {
                MessageBox.Show("Make sure to set start directory and target filename", "DFS Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                createGraph();
            }
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

        private async void createGraph()
        {
            graphPanel.Controls.Clear();

            this.algorithmtime.Text = "0";
            this.hyperlink.Visible = false;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            
            string start = this.chosenDir.Text; // starting directory
            bool check = this.checkAll.Checked; // check all occurence



            /* IMPLEMENT BFS/DFS HERE */



            // iterator (show graph creation procss)
            string[] creationPath = { "A", "B", "C", "D" }; // dummy BFS/DFS path
            for (int i = 0; i < creationPath.Length - 1; i++)
            {
                if (i != 0) await Task.Delay(this.trackBar1.Value);
                graph.AddEdge(creationPath[i], creationPath[i + 1]);
                viewer.Graph = graph;
                viewer.OutsideAreaBrush = System.Drawing.Brushes.Transparent;
                graphPanel.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                graphPanel.Controls.Add(viewer);
            }

            // recoloring nodes after graph creation
            string[] result = { "A", "B", "D" }; // dummy BFS/DFS result
            for (int i = 0; i < result.Length - 1; i ++)
            {
                Microsoft.Msagl.Drawing.Node node = graph.FindNode(result[i]);
                node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.ForestGreen;
            }
            watch.Stop();

            this.algorithmtime.Text = watch.ElapsedMilliseconds.ToString();
            this.hyperlink.Visible = true;
            graphPanel.ResumeLayout();
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

        private async void dummySearchMethod(bool checkAll, System.Windows.Forms.Panel graphPanel)
        {
            
        }
    }
}