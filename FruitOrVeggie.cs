using System;

class FruitOrVeggie
{
    static void Main(string[] args)
    {
        string thing = Console.ReadLine();
        string type = "";

        switch (thing)
        {
            case "banana":
            case "apple":
            case "kiwi":
            case "cherry":
            case "lemon":
            case "grapes":
                type = "fruit";
                break;

            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot":
                type = "vegetable";
                break;

            default:
                type = "unknown";
                break;
        }

        Console.WriteLine(type);
    }
}