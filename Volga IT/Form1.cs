using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
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
            
            string text = new HtmlParser().Parser(openFileDialog1.FileName);           
            
            List<Word> Result = new SplitIntoWords().BreakerText(text);

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
