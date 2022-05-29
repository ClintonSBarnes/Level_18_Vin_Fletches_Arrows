// See https://aka.ms/new-console-template for more information
using Level_18_Vin_Fletches_Arrows;

Arrows[] purchase = new Arrows[25];
string quiverFill = "Y";
int arrowCount = 1;
float totalCost = 0f;



//VERY IMPORTANT: This initializes each member of the array.
for (int i = 0; i < purchase.Length; i++)
{
    purchase[i] = new Arrows();
}


//iterates the user defined arrows for as long as the user wants until they have purchased 25 arrows.
for (int i = 0; i < 26; i++)
{

    purchase[i].SelectArrowHead();
    purchase[i].SelectArrowFletching();
    purchase[i].GetShaftLength();
    purchase[i].BuildArrow();
    totalCost += purchase[i].UpdateTotalCost();


    //offers the chance to continue purchasing arrows as long as the 25-quiver slots have not been filled.
    Console.WriteLine($"You have purchased {arrowCount}. You can purchase enough (25) to fill your quiver if you would like.");
    Console.WriteLine("\n--------------------------------------------------------------------------------------" +
        "\nWould you like to continue filling your quiver? (Y/N)" +
        "\n--------------------------------------------------------------------------------------");

    //checks the count of arrows in the quiver
    quiverFill = Console.ReadLine();
    if (quiverFill == "N" || quiverFill == "n")
    {
        Console.WriteLine("We are grateful for your buisiness." +
        "\n--------------------------------------------------------------------------------------");
        break;

    }
    else if (arrowCount == 25)
    {
        Console.WriteLine("You have purchased all the arrows your quiver will hold! We are so lucky to have you as a customer!" +
        "\n--------------------------------------------------------------------------------------");
        break;
    }


}

Console.WriteLine($"Let's see...that is {arrowCount} arrow(s), and the total comes to {totalCost}. Thank you for your buisiness, kind sir!");





Console.ReadKey();



