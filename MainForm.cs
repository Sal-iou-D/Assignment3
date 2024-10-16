namespace Assignment3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeDeck();
            DealAtStart();
        }

        private List<int> deck = new List<int>();

        private int[] hand = new int[5];

        private const string FILE_PATH = @"C:\Users\Saliou Diop\source\repos\Assignment3\SaveHands\";

        private void dealButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                if (!KeptTheCard(i))
                {
                    DealCardToHand(i);
                }
            }
            UpdateHandDisplay();


        }

        private void InitializeDeck()
        {
            deck.Clear();
            for (int i = 0; i < 52; i++)
            {
                deck.Add(i);
            }
            ShuffleTheDeck();
        }

        private void ShuffleTheDeck()
        {
            Random random = new Random();
            for (int i = 0; i < deck.Count; i++)
            {
                int randomIndex = random.Next(deck.Count);
                int temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }

        private bool KeptTheCard(int index)
        {
            switch (index)
            {
                case 0: return keep1CheckBox.Checked;
                case 1: return keep2CheckBox.Checked;
                case 2: return keep3CheckBox.Checked;
                case 3: return keep4CheckBox.Checked;
                case 4: return keep5CheckBox.Checked;
                default: return false;
            }
        }

        private void DealCardToHand(int index)
        {
            if (deck.Count > 0)
            {
                hand[index] = deck[0];
                deck.RemoveAt(0);
            }
        }

        private void UpdateHandDisplay()
        {
            card1PictureBox.Image = cardImageList.Images[hand[0]];
            card2PictureBox.Image = cardImageList.Images[hand[1]];
            card3PictureBox.Image = cardImageList.Images[hand[2]];
            card4PictureBox.Image = cardImageList.Images[hand[3]];
            card5PictureBox.Image = cardImageList.Images[hand[4]];
        }

        private void DealAtStart()
        {
            for (int i = 0; i < hand.Length; i++)
            {
                DealCardToHand(i);
            }
            UpdateHandDisplay();
        }

        private void SaveHandButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = FILE_PATH,
                DefaultExt = "txt",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog.FileName, hand.Select(h => h.ToString()).ToArray());
            }
        }

        private void LoadHandButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = FILE_PATH,
                DefaultExt = "txt",    
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);
                for (int i = 0; i < hand.Length && i < lines.Length; i++)
                {
                    if (int.TryParse(lines[i], out int cardIndex) && cardIndex >= 0 && cardIndex < cardImageList.Images.Count)
                    {
                        hand[i] = cardIndex;
                    }
                    else
                    {
                        hand[i] = -1;

                    }
                }
            }
            UpdateHandDisplay();
        }

       
    }
}
