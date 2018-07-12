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
        private Connection _connection;

        public Form1()
        {
            InitializeComponent();

            OpenFileButton.Click += OpenFileButton_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            _parsing = new Parsing();
            _connection = new Connection();

            GetPreviousSentences();
            ShowInstructions();
        }

        private void ShowInstructions()
        {
            var message = "1 - open file \n 2 - write word for search \n 3 - save the found sentences";
            MessageBox.Show(message);
        }

        // відкриваємо файл
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // отримуємо вибраний файл
            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);

            _parsing.SetText(fileText);
            
            MessageBox.Show("File opened");
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var sentences = _parsing.ParseText(SearchTextBox.Text);
            SearchedResultTextBox.Text = "";
            foreach (var sentence in sentences)
            {
                SearchedResultTextBox.Text += sentence + Environment.NewLine; // \n не працює?
            }
        }

        private void SaveSentencesButton_Click(object sender, EventArgs e)
        {
            var sentences = _parsing.ParseSentences(SearchTextBox.Text);
            _connection.Post(sentences);
            GetPreviousSentences();
        }

        public void GetPreviousSentences()
        {
            PastResultsTextBox.Text = "";
            var sentences = _connection.Get();
            var partion = "- - - - - - - - - - - -";
            foreach (var sentence in sentences)
            {
                PastResultsTextBox.Text += sentence + Environment.NewLine + partion + Environment.NewLine;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
