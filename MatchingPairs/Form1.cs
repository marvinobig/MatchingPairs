using System.Windows.Forms;

namespace MatchingPairs
{
    public partial class Form1 : Form
    {
        Label? firstClicked = null;
        Label? secondClicked = null;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquare();
        }

        private void AssignIconsToSquare()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label? iconLabel = control as Label;

                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) return;
            
            Label? iconLabel = sender as Label;

            if (iconLabel != null)
            {
                if (firstClicked == null)
                {
                    firstClicked = iconLabel;
                    iconLabel.ForeColor = Color.Black;
                }
                else if (secondClicked == null)
                {
                    secondClicked = iconLabel;
                    iconLabel.ForeColor = Color.Black;

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;

                        return;
                    }

                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;   
        }
    }
}
