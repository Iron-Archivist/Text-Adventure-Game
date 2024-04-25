using static System.Windows.Forms.LinkLabel;
using System.Text.RegularExpressions;

namespace Text_Adventure_Game
{
    public partial class Form1 : Form
    {
        string EventName = "";
        string ScriptFile = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "GameScript.txt");
        string DisplayText = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UIButton1_Click(object sender, EventArgs e)
        {
            DisplayText = "";
            FindEvent(UIButton1.Text);
            GameDisplayText.Text = DisplayText;
        }

        private void UIButton2_Click(object sender, EventArgs e)
        {
            DisplayText = "";
            FindEvent(UIButton2.Text);
            GameDisplayText.Text = DisplayText;
        }

        private void UIButton3_Click(object sender, EventArgs e)
        {
            DisplayText = "";
            FindEvent(UIButton3.Text);
            GameDisplayText.Text = DisplayText;
        }

        private void UIButton4_Click(object sender, EventArgs e)
        {
            DisplayText = "";
            FindEvent(UIButton4.Text);
            GameDisplayText.Text = DisplayText;
        }

        private void FindEvent(string EventName)
        {
            //label2.Text = EventName;
            StreamReader reader = new StreamReader(ScriptFile);
            string line;
            bool Capturing = false;

            while  ((line = reader.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, @"\[Event: " + Regex.Escape(EventName) + @"]"))
                {
                   // MessageBox.Show(line + " :Match");
                    Capturing = true;
                    continue;
                }

                if (Regex.IsMatch(line, @"\[Event: (?!" + Regex.Escape(EventName) + @"\b)[^\]]+\]"))
                {
                    //MessageBox.Show(line + " :Not Match");
                    Capturing = false;
                }

               if (Capturing)
                {
                    if (Regex.IsMatch(line, @"/c1"))
                    { UIButton1.Text = line.Replace("/c1", "").Trim(); }
                    else if (Regex.IsMatch(line, @"/c2"))
                    { UIButton2.Text = line.Replace("/c2", "").Trim(); }
                    else if (Regex.IsMatch(line, @"/c3"))
                    { UIButton3.Text = line.Replace("/c3", "").Trim(); }
                    else if (Regex.IsMatch(line, @"/c4"))
                    { UIButton4.Text = line.Replace("/c4", "").Trim(); }
                    else
                    { DisplayText += line + "\n"; }
                }
            }
           // MessageBox.Show("End");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
