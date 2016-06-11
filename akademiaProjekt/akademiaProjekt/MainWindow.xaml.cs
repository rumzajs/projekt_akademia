using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace akademiaProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public enum ShapesEnum
        {
            Kwadrat,
            Trojkat,
            Kolo
        }

        public ObservableCollection<Shape> shapeList = new ObservableCollection<Shape>();

        public MainWindow()
        {
            InitializeComponent();
            this.shapesListView.ItemsSource = shapeList;
            this.shapeComboBox.ItemsSource = Enum.GetValues(typeof(ShapesEnum));
            this.shapeComboBox.SelectedIndex = 0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedShape = ((ShapesEnum)Enum.Parse(typeof(ShapesEnum), this.shapeComboBox.Text)).ToString();
            //if in combobox selected is square
            if (selectedShape == "Kwadrat")
            {
                SelectedSquare();
            }
            //if in combobox selected is triangle
            else if (selectedShape == "Trojkat")
            {
                SelectedTriangle();
            }
            //if in combobox selected is circle
            else if (selectedShape == "Kolo")
            {
                SelectedCircle();
            }
        }

        private void SelectedSquare()
        {
            bool exception = false;
            Square s = new Square();
            try
            {
                s.A = Int32.Parse(firstValueTextBox.Text);
                s.B = Int32.Parse(secondValueTextBox.Text);
                if (s.A <= 0 || s.B <= 0) throw new FormatException();
            }
            catch (FormatException)
            {
                exception = true;
            }
            if (exception == false)
            {
                s.CalculateArea();
                shapeList.Add(s);
            }
        }

        private void SelectedTriangle()
        {
            bool exception = false;
            Triangle t = new Triangle();
            try
            {
                t.A = Int32.Parse(firstValueTextBox.Text);
                t.H = Int32.Parse(secondValueTextBox.Text);
                if (t.A <= 0 || t.H <= 0) throw new FormatException();
            }
            catch (FormatException)
            {
                exception = true;
            }
            if (exception == false)
            {
                t.CalculateArea();
                shapeList.Add(t);
            }
        }

        private void SelectedCircle()
        {
            bool exception = false;
            Circle c = new Circle();
            try
            {
                c.R = Int32.Parse(firstValueTextBox.Text);
                if (c.R <= 0) throw new FormatException();
            }
            catch (FormatException)
            {
                exception = true;

            }
            if (exception == false)
            {
                c.CalculateArea();
                shapeList.Add(c);
            }
        }
    }
}
