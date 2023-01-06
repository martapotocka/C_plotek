using Coockbook.Ingredients;

var wheatFlour = new WheatFlour();
var coconutFlour = new CoconutFlour();
var butter = new Butter();
var chocolate = new Chocolate();
var sugar = new Sugar();
var cardamon = new Cardamon();
var cinnamon = new Cinnamon();
var cocoaPowder = new CocoaPowder();

var ingredients = new List<Ingredient>() { wheatFlour, coconutFlour, butter, chocolate, sugar, cardamon, cinnamon, cocoaPowder };

var printer = new IngredientsPrinter();
printer.PrintIngredients(ingredients);

Console.ReadKey();

public class IngredientsPrinter
{
    public void PrintIngredients(List<Ingredient> listOfIngredients)
    {
        foreach (Ingredient ingredient in listOfIngredients)
        {
            Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
        }
    }
}

 


