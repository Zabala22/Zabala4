using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading;


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
            //Personal Information
            RGFullname.Text = "";
            RGContactnumber.Text = "";
            RGEmail.Text = "";
            RGAddress.Text = "";
            RGIntroduction.Text = "";

            //Education
            RGCollagename.Text = "";
            RGCollegeaddress.Text = "";
            RGShsname.Text = "";
            RGShsaddress.Text = "";

            //Seminars and Trainings
            RGSeminar1.Text = "";
            RGSeminar2.Text = "";
            RGSeminar3.Text = "";
            RGSeminar4.Text = "";

            //Skills
            RGSkill1.Text = "";
            RGSkill2.Text = "";
            RGSkill3.Text = "";
            RGSkill4.Text = "";
            RGSkill5.Text = "";
            RGSkill6.Text = "";
            RGSkill7.Text = "";
            RGSkill8.Text = "";

            //Experience
            RGWorknumber1.Text = "";
            RGWorkaddress1.Text = "";
            RGWork1Skill1.Text = "";
            RGWork1Skill2.Text = "";
            RGWork1Skill3.Text = "";

            RGWorknumber2.Text = "";
            RGWorkaddress2.Text = "";
            RGWork2Skill1.Text = "";
            RGWork2Skill2.Text = "";
            RGWork2Skill3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}