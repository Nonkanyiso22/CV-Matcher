using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVMatcherApp
{
    public partial class CVMatcherForm : Form
    {
        public CVMatcherForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
       
            string cvText = txtCV.Text.ToLower();
            string jobText = txtJob.Text.ToLower();

            var cvWords = cvText.Split(' ');
            var jobWords = jobText.Split(' ');

            var matches = jobWords.Where(word => cvWords.Contains(word)).Distinct().ToList();
            var missing = jobWords.Where(word => !cvWords.Contains(word)).Distinct().ToList();

            int matchScore = (matches.Count * 100) / (jobWords.Length == 0 ? 1 : jobWords.Length);

            lblResult.Text = $"Match Score: {matchScore}%\n\n" +
                             $"Matched Skills:\n{string.Join(", ", matches.Take(10))}\n\n" +
                             $"Missing Skills:\n{string.Join(", ", missing.Take(10))}";
        }

    }
}

