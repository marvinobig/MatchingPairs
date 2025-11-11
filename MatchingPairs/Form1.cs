using System.Windows.Forms;

namespace MatchingPairs
{
    public partial class Form1 : Form
    {
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
            Label? iconLabel = sender as Label;

            if (iconLabel != null)
            {
                if (iconLabel.ForeColor != Color.Black)
                {
                    iconLabel.ForeColor = Color.Black;
                }
            }
        }
    }
}
