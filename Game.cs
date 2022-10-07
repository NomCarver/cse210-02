class Game
{
    static void Main(string[] args){
        DisplayWelcomeMessage();
        Deck deck = new Deck();
        Card startCard = deck.DrawRandomCard();
        Console.WriteLine(startCard);
        // int startCard = deck.DrawRandomCard();

    }
    static void DisplayWelcomeMessage(){

    }
}