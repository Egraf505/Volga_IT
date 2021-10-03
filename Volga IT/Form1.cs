using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Volga_IT.Models;
using Volga_IT.Service;

namespace Volga_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            HtmlParser html = new HtmlParser();
            string text = html.Parser(openFileDialog1.FileName);           

            SplitIntoWords siw = new SplitIntoWords();
            List<Word> Result = siw.BreakerText(text);

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;            

            OutToText outTo = new OutToText();
            outTo.WriteText(Result, saveFileDialog1.FileName);
        }     
    }
}
