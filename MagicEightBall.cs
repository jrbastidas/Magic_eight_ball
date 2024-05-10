using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class MagicEightBall : Form
    {
        Random random = new Random();
        List<String> answers = new List<String>();
        public MagicEightBall()
        {
            InitializeComponent();
            answers.Add("It is decidely so");
            answers.Add("Better not tell you now");
            answers.Add("Concentrate and ask again");
            answers.Add("Outlook not so good");
            answers.Add("You may rely on it");
            answers.Add("Yes definitely");
            answers.Add("Cannot predict now");
            answers.Add("Very doubtful");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);
            answerLabel.Text = answers[index];
        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }
    }
}
