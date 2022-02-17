
bool playing = true;

while (playing)
{
  Console.WriteLine("would you like to pay? y/n");
  char userinput = Console.ReadKey().KeyChar;
  Console.Clear();
  if (userinput == 'n')
  {
    playing = false;
    Console.WriteLine("goodbye");
    break;
  }

  int score = 0;
  Random rnd = new Random();
  for (int i = 0; i < 3; i++)
  {
    int roll1 = rnd.Next(1, 7);
    int roll2 = rnd.Next(1, 7);
    score += roll1 + roll2;
    Console.WriteLine(roll1 + ", " + roll2);
    Thread.Sleep(1000);
    if (roll1 == roll2)
    {
      score = 0;
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("break");
      break;
    }
  }
  Console.WriteLine("SCORE:" + score);
  Thread.Sleep(2000);
  Console.Clear();
}