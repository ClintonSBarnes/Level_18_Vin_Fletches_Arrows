using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_18_Vin_Fletches_Arrows
{
    public class Arrows
    {
        //establishes variables
        public string _arrowhead = "1";
        public float _shaft = 0.00f;
        public string _fletching = "2";
        private string userInput = "3";
        public float _arrowCost = 0.00f;

        //allows user to select the arrowhead material, adds to the cost of the arrow, and validates user input
        public float SelectArrowHead()
        {
            Console.WriteLine(

            $"\n--------------------------------------------------------------------------------------" +
            $"\nWe have several arrow heads you can select from. Please choose one:\n " +
            $"\n{ArrowHeads.Wood} for {(int)ArrowHeads.Wood} gold\n{ArrowHeads.Steel} for {(int)ArrowHeads.Steel} gold\n" +
            $"{ArrowHeads.Obsidian} for {(int)ArrowHeads.Obsidian} gold " +
            $"\n--------------------------------------------------------------------------------------");
            userInput = Console.ReadLine();

            while (_arrowhead != userInput)
            {
                if (userInput == "wood" || userInput == "Wood")
                {
                    _arrowhead = userInput;
                    _arrowCost += 3;
                    break;

                }
                else if (userInput == "steel" || userInput == "Steel")
                {
                    _arrowhead = userInput;
                    _arrowCost += 10;
                    break;
                }
                else if (userInput == "obsidian" || userInput == "Obsidian")
                {
                    _arrowhead = userInput;
                    _arrowCost += 5;
                    break;
                }
                else
                    Console.WriteLine("You have made an invalid choice. Please select again.");
                userInput = Console.ReadLine();

            }

            return _arrowCost;

        }

        //allows user to select the Flethching material, adds to the cost of the arrow, and validates user input

        public float SelectArrowFletching()
        {
            Console.WriteLine($"\n--------------------------------------------------------------------------------------\n" +
                $"We have several arrow heads you can select from. Please choose one:" +
            $"\n{Fletching.Plastic} for {(int)Fletching.Plastic} gold, turkey feathers for {(int)Fletching.turkeyFeathers} gold, " +
            $"or goose feathers for {(int)Fletching.gooseFeathers} gold" +
            $"\n--------------------------------------------------------------------------------------");
            userInput = Console.ReadLine();

            while (_fletching != userInput)
            {
                if (userInput == "plastic" || userInput == "Plastic")
                {
                    _fletching = userInput;
                    _arrowCost += 10;
                    break;

                }
                else if (userInput == "Turkey Feathers" || userInput == "turkey feathers" || userInput == "Turkey feathers" || userInput == "turkey Feathers")
                {
                    _fletching = userInput;
                    _arrowCost += 5;
                    break;
                }
                else if (userInput == "Goose Feathers" || userInput == "goose feathers" || userInput == "Goose feathers" || userInput == "goose Feathers")
                {
                    _fletching = userInput;
                    _arrowCost += 3;
                    break;
                }
                else
                    Console.WriteLine("You have made an invalid choice. Please select again.");
                userInput = Console.ReadLine();

            }
            return _arrowCost;
        }

        //allows user to select the length of the arrow and adds to the cost of the arrow

        public float GetShaftLength()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------" +
                "\nHow long would you like the shaft of the arrow to be? The cost is 0.05 gold per centimeter." +
                "\n--------------------------------------------------------------------------------------");
            _shaft = Convert.ToSingle(Console.ReadLine());
            _arrowCost += _shaft * .05f;
            return _arrowCost;


        }
    }
}

enum ArrowHeads
{
    Steel = 10,
    Wood = 3,
    Obsidian = 5
}

enum Fletching
{
    Plastic = 10,
    turkeyFeathers = 5,
    gooseFeathers = 3
}