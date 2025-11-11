namespace MatchingPairs
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<char> icons = new List<char>()
        {
            '!', '!', 'N', 'N', ',', ',', 'k', 'k',
            'b', 'b', 'v', 'v', 'w', 'w', 'z', 'z'
        };
        public Form1()
        {
            InitializeComponent();
        }
    }
}
