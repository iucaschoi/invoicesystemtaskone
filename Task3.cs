//arrays
int[] tileID = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] tileName = new string[] { "small black granite", "small grey marble", "small powder blue", "medium sunset blue", "medium berry red", "medium glitter purple", "large oak wood effect", "large black granite", "large bamboo effect", "extra large white marble" };
double[] tilePrice = new double[] { 19.50, 25.95, 35.75, 12.50, 11.00, 52.95, 65.00, 58.98, 85.00, 62.75 };

for (int i = 0; i < tileID.Length; i++)
{
    Console.WriteLine(tileID[i] + " " + tileName[i] + " " + tilePrice[i]);
}

string chosenTileName = "";
double chosenTilePrice = 0;
bool validTileChosen = false;

double totalWallArea = 0;
double totalBoxNeeded = 0;
double totalPrice = 0;

Console.Write("How many walls would you like to tile?: ");
int numberOfWalls = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a wastage amount percentage (from 0-100): ");
int wastage = Convert.ToInt32(Console.ReadLine());

while (wastage < 0 && wastage > 100) 
{
    Console.Write("Enter a valid wastage amount percentage (from 0-100): ");
    wastage = Convert.ToInt32(Console.ReadLine());
}

wastage = wastage / 100;

for (int i = 0; i < numberOfWalls; i++)
{
    while (validTileChosen == false)
    {
        Console.Write("What tile would you like to use? Answer using the ID number: ");
        int chosenTileID = Convert.ToInt32(Console.ReadLine());

        switch (chosenTileID)
        {
            case 1:
                chosenTileName = "small black granite";
                chosenTilePrice = 19.50;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 2:
                chosenTileName = "small grey marble";
                chosenTilePrice = 25.95;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 3:
                chosenTileName = "small powder blue";
                chosenTilePrice = 35.75;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 4:
                chosenTileName = "medium sunset yellow";
                chosenTilePrice = 12.50;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 5:
                chosenTileName = "medium berry red";
                chosenTilePrice = 11.00;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 6:
                chosenTileName = "medium glitter purple";
                chosenTilePrice = 52.95;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 7:
                chosenTileName = "large oak wood effect";
                chosenTilePrice = 65.00;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 8:
                chosenTileName = "large black granite";
                chosenTilePrice = 58.98;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 9:
                chosenTileName = "large bamboo effect";
                chosenTilePrice = 85.00;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            case 10:
                chosenTileName = "extra large white marble";
                chosenTilePrice = 62.75;
                Console.WriteLine(chosenTileName + " was chosen");
                validTileChosen = true;
                break;
            default:
                Console.WriteLine("Please enter a valid ID number.");
                break;
        }
    }

    validTileChosen = false;

    Console.Write("What is the height of your wall? Answer in metres: ");
    double wallHeight = Convert.ToDouble(Console.ReadLine());
    Console.Write("What is the width of your wall? Answer in metres: ");
    double wallWidth = Convert.ToDouble(Console.ReadLine());

    double wallArea = wallHeight * wallWidth;

    wallArea = wallArea - (wallArea * wastage);

    double boxNeeded = Math.Ceiling(wallArea);
    double price = boxNeeded * chosenTilePrice;

    totalWallArea += wallArea;
    totalBoxNeeded += boxNeeded;
    totalPrice += price;
}

Console.WriteLine("The total area of your walls are " + totalWallArea);
Console.WriteLine("The total amount of tile boxes you need is " + totalBoxNeeded);
Console.WriteLine("The total cost for the boxes of tiles is $" + totalPrice.ToString("00.00"));
