namespace Shuffler
{
  public class Card
  {
    //value
    public int Value { get; set; }
    //rank
    public string Rank { get; set; }
    //suit
    public string Suit { get; set; }
    //color
    public string Color { get; set; }
    // display the card -- METHOD
    public string DisplayCard()
    {
      return $"{Rank} of {Suit}";
    }
    public int GetValue()
    {
      if (Rank == "Ace")
      {
        return 11;
      }
      else if (Rank == "Jack" || Rank == "Queen" || Rank == "King")
      {
        return 10;
      }
      else
      {
        return int.Parse(Rank);
      }
    }
  }
}