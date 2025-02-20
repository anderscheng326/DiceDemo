/* 
UML
Class: Dice
 Fields:
    -numSide:int
    -topSide:int
    -dice:Random

 Properties:
    +Topside:int

 Methods:
    +roll():void

 Constructor:
    Dice(){numSide:int}
*/

public class Dice 
{
    int numSide;
    int topSide;

    public int Topside()
    {
        return topSide;
    }
    public void Roll()
    {
        Random rnd = new Random();
        topSide = rnd.Next(1,numSide);
    }
    public Dice(int side)
    {
        numSide = side;
    }
}