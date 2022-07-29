using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using Newtonsoft;
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

        //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class About
        {
            public string? summary { get; set; }
        }

        public class Basics
        {
            public string? name { get; set; }
            public string? email { get; set; }
            public string? phone { get; set; }
            public string? title { get; set; }
            public string? website { get; set; }
            public string? address { get; set; }
        }

        public class Education
        {
            public string? institution { get; set; }
            public string? area { get; set; }
            public string? studyType { get; set; }
            public string? startDate { get; set; }
            public string? endDate { get; set; }
        }

        public class Root
        {
            public About? about { get; set; }
            public Basics? basics { get; set; }
            public Work? work { get; set; }
            public Education? education { get; set; }
            public List<Skill>? skills { get; set; }
        }

        public class Skill
        {
            public string? name { get; set; }
            public string? level { get; set; }
            public List<string>? keywords { get; set; }
        }

        public class Work
        {
            public string? company { get; set; }
            public string? position { get; set; }
            public string? website { get; set; }
            public string? startDate { get; set; }
            public string? endDate { get; set; }
            public string? summary { get; set; }
            public List<string>? highlights { get; set; }
        }

        string? json;

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
        private void RGsaveaspdfbutton_Click(object sender, EventArgs e)
        {
            try
            {
                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Title = "Save Resume";
                saveFileDialog.Filter = "PDF Files (*.PDF) | *.PDF";
                Root Resume = JsonConvert.DeserializeObject<Root>(json);
                
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

        
        
    
