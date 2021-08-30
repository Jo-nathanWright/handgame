namespace handgame.Models
{
    public class Choices
    {
        public string Name { get; set; }
        public string Wins { get; set; }

        public Choices(string n, string wins)
        {
      Name = n;
      Wins = wins;
    }
  }
}