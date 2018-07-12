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

            OpenFileButton.Click += OpenFileButton_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            _parsing = new Parsing();
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

            //textBox1.Text = fileText;
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
    }
}
