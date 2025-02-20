public class Test
{
    public static void Main(string[] args)
     {
        Dice dice1 = new Dice(6);
        Dice dice2 = new Dice(6);
        int d1score = 0;
        int d2score = 0;
        while (d1score < 5 && d2score < 5)
        {
            dice1.Roll();
            dice2.Roll();
            Console.WriteLine($"Dice 1: {dice1.Topside()} - Dice 2: {dice2.Topside()}");
            if(dice1.Topside()>dice2.Topside())
            {
                d1score++;
            }
            if(dice2.Topside()>dice1.Topside())
            {
                d2score++;
            }
        }
     }
}