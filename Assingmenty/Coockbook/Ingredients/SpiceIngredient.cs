namespace Coockbook.Ingredients;

public abstract class SpiceIngredient : Ingredient
{
    public override string InstructionsOfPreparing => $"Take half a teaspoon. {base.InstructionsOfPreparing}";
}
