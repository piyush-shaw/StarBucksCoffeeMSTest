using System;
namespace CoffeeMakerDemo
{
	public interface IMakeACoffee
	{
        bool CheckIngredientAvailability();
        string CoffeeMaking(int sugerPerSpoon, int CoffeePack);
    }
}

