using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace ParsingTXT
{
    public partial class Form1 : Form
    {
        private Parsing _parsing;

        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            _parsing = new Parsing();
        }

        // відкриваємо файл
        void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // отримуємо вибраний файл
            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);

            _parsing.SetText(fileText);

            //textBox1.Text = fileText;
            MessageBox.Show("File opened");
            // -------------------------

            //string s = ".Amnesty fuckInternational has fuck condemned the Iranianfuck authorities. for publicly flogging a fuckman who was. convicted of consuming alcohol when he was 14 or 15. fuckLocal media fuckpublished.photographs of the man -identified.only fuckas M R - being given 80 lashes in a.square in tfuckhe eastern city offuck Kashmar on fuckTuesday.";
            //s = s.Replace( ".", ".." );
            //Regex regex = new Regex(@"((\.)[\n 0-9A-Za-z-]+(\.))");
            //MatchCollection matches = regex.Matches(s);
            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //        Console.WriteLine(match.Value);
            //}
            //else
            //{
            //    Console.WriteLine("match not found");
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var sentences = new List<string>();
            sentences = _parsing.ParseText(textBox1.Text);
            textBox2.Text = "";
            foreach (var sentence in sentences)
            {
                textBox2.Text += sentence;
            }
        }
    }
}
