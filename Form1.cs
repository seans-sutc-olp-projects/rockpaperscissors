namespace rockpaperscissors
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        } 
     private void play_Click(object sender, EventArgs e)
        {
            int player1 = 0;
            int player2 = 0;
            // Result Validation
            if (Rock.Checked == true) { player1 = 1; };
            if (Paper.Checked == true) { player1 = 2; };
            if (Scissors.Checked == true) { player1 = 3; };
            // AI
            string result = "Result";
            player2 = new Random().Next(1, 3)+1;
            Console.WriteLine("Player2 Result" + player2.ToString());
            if (player1 == player2) { result = "DRAW!"; };
            // Compute Against Rock
            if (player1 == 1 && player2 == 2) { result = "You Lost!\n AI chose Paper"; };
            if (player1 == 1 && player2 == 3) { result = "You Won!"; };
            // Compute Against Paper
            if (player1 == 2 && player2 == 1) { result = "You Lost!\n AI chose Rock"; }; 
            if (player1 == 2 && player2 == 3) { result = "You Won!"; };
            // Compute Against Scissors
            if (player1 == 3 && player2 == 1) { result = "You Lost!\n AI chose Rock"; };
            if (player1 == 3 && player2 == 2) { result = "You Won!"; };
            // Result
            ResultBox.Text = result;
            ResultBox.Visible = true;
        }
    }
}