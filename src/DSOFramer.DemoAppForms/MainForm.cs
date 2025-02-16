// MainForm.cs

namespace DSOFramer.DemoAppForms
{
    using System.Windows.Forms;
    using AxDSOFramer;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }
        
        private AxFramerControl _axFramerControl;

        private void MyInitializeComponent()
        {
            _axFramerControl = new AxFramerControl
            {
                Dock = DockStyle.Fill
            };

            this.splitContainer1.Panel1.Controls.Add(_axFramerControl);

            this.splitContainer1.FixedPanel = FixedPanel.Panel2;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            var documentFilter =
                @"Microsoft Office Files|*.xls?;*.ppt?;*.pps?;*.doc?|Microsoft Excel Files|*.xls?|Microsoft PowerPoint Files|*.ppt?;*.pps?|Microsoft Word Files|*.doc?|All Files|*.*";

            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            openFileDialog.Filter = documentFilter;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this._axFramerControl.Open(openFileDialog.FileName);
            }
        }
    }
}
