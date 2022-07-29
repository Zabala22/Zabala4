using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using Newtonsoft;
using System.Globalization;
using System.Threading.Tasks;
using iText;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
{

}


namespace Resume_Generator_Program
{





    public partial class Resumegenerator : Form
    {

        public Resumegenerator()
        {
            InitializeComponent();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RGjsonviewer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void Resumegenerator_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RGsaveaspdfbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Root Resume = JsonConvert.DeserializeObject<Root>(json);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Title = "Save Resume";
                saveFileDialog.Filter = "PDF Files (*.PDF) | *.PDF";
            }
            catch
            {

            }

            
            
        }

        private void RGopenjsonbutton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\";
                ofd.Title = "Open JSON File.";
                ofd.Filter = "JSON Files(*.JSON*) | *.JSON";
                DialogResult dialogResult = ofd.ShowDialog();
                json = File.ReadAllText(ofd.FileName);
                RGjsonviewer.Text = json;
                RGopenjsonbutton.Enabled = false;
                

            }
            catch
            {
                RGjsonviewer.Clear();
                RGopenjsonbutton.Enabled = true;
            }
        }
    }
}