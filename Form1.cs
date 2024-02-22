using static System.Windows.Forms.LinkLabel;
using System.Text.RegularExpressions;

namespace Text_Adventure_Game
{
    public partial class Form1 : Form
    {
        //string EventName = "";
        string PlayerName = "";
        string ScriptFile = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "GameScript.txt");
        string ChoiceFile = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "GameChoices.txt");
        string GameScript = "";
        string DisplayText = "";
        const int CHOICES = 4;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
            {
                GameScript = File.ReadAllText(ScriptFile);
            }

        private void button1_Click(object sender, EventArgs e)
            {
                DisplayText = "";
                FindEvent("WorldIntro");
                FindEventOptions("WorldIntro");
                GameDisplayText.Text = DisplayText;
            }
        private void FindEvent(string EventName)
        {
            StreamReader reader = new StreamReader(ScriptFile);
            string line;
            bool Capturing = false;
            while ((line = reader.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, @"\[Event: " + Regex.Escape(EventName) + @"]"))
                {
                    Capturing = true;
                    continue;
                }
                else if (Regex.IsMatch(line, @"\[Event: (?!" + Regex.Escape(EventName) + @")\w+\]"))
                {
                    Capturing = false;
                }
                if (Capturing)
                {
                    if (Regex.IsMatch(line, @"/c1"))
                    { UIButton1.Text = line.Replace("/c1", "");}
                    else if (Regex.IsMatch(line, @"/c2"))
                    { UIButton2.Text = line.Replace("/c2", ""); }
                    else if (Regex.IsMatch(line, @"/c3"))
                    { UIButton3.Text = line.Replace("/c3", ""); }
                    else if (Regex.IsMatch(line, @"/c4"))
                    { UIButton4.Text = line.Replace("/c4","");}
                    else
                    {DisplayText += line + "\n";}
                }
            }

        }
        private void FindEventOptions(string EventName)
        {
            StreamReader reader = new StreamReader(ScriptFile);
            string Line;
            bool Capturing = false;
            string[] ChoiceArray = new string[CHOICES];
            while ((Line = reader.ReadLine()) != null)
            {
                if (Regex.IsMatch(Line, @"\[Event: " + Regex.Escape(EventName) + @"]"))
                {
                    Capturing = true;
                    continue;
                }
                else if (Regex.IsMatch(Line, @"\[Event: (?!" + Regex.Escape(EventName) + @")\w+\]"))
                {
                    Capturing = false;
                }
                if (Capturing)
                {
                }
            }

        }
    }
}
