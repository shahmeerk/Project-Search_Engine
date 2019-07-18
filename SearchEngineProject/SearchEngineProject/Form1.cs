using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchEngineProject
{
    public partial class Form1 : Form
    {
        public string wordRx = @"\w+";
        Search search = new Search();
        public string term = "o";
        public Form1()
        {
            search.initialize();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            term = searchQuery.Text;
            Match match = Regex.Match(term, wordRx, RegexOptions.IgnoreCase);
            List<string> searchTerms = new List<string>();
            while (match.Success)
            {
                searchTerms.Add(match.Value);
                match = match.NextMatch();
            }
            search.multiWord(searchTerms);
            
        }

        private void searchQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
