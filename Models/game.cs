using System.Collections.Generic;

namespace handgame.Models
{
    public class game
    {
    public List<Choices> Choices { get; private set; } = new List<Choices>();
    public void AddChoice(Choices choice)
  {
    Choices.Add(choice);
  }
  }
  
}