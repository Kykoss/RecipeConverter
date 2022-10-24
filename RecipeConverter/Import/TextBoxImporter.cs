using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Import
{
    internal class TextBoxImporter: RecipeImporter
    {
        private void CreateIngredient()
        {

        }
        
        public override Ingredient[] GetIngredients()
        {
            string[] recipeLine;

            string rawText = textBox.Text;

            foreach (string item in rawText.Split("\n"))
            {
                Console.WriteLine(item);
            }

            return null;
        } 
    }
}
