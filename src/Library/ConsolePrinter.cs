using System;
/*
Utilice el patron de SRP para separar las clases de imprimir con la de Recipe, 
asi cada una de las clases tiene una unica responsabilidad y una sola razón para cambiar.
*/
namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
        
    }
}