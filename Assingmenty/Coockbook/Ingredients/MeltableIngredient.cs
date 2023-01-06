namespace Coockbook.Ingredients;

public abstract class MeltableIngredient : Ingredient
{
    public override string InstructionsOfPreparing => $"Melt on low heat. {base.InstructionsOfPreparing}";
}
