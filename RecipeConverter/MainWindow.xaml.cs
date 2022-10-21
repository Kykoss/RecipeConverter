using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipeConverter.Units;
using RecipeConverter.Import;

namespace RecipeConverter
{
    public partial class MainWindow : Window
    {
        private enum ImportType
        {
            TextBox = 0
        }

        private Recipe Recipe { get;  set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, RoutedEventArgs e)
        {
            RecipeImporter importer;

            try
            {
                //Importer gemäß Cmb setzen
                importer = new TextBoxImporter();
            }
            catch (Exception)
            {

                throw;
            }

            result.Text = UnitConverter.ConvertLine("");

            this.Recipe = new Recipe(importer.GetIngredients());

        }
    }
}
