using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Import
{
    internal static class ImporterFactory
    {
        private enum ImportType
        {
            TextBox = 0
        }

        public static RecipeImporter GetImporter(int selectionIndex)
        {
            switch (selectionIndex)
            {
                case (int)ImportType.TextBox:
                    return new TextBoxImporter();

                default:
                    return null;
            }
        }

    }
}
