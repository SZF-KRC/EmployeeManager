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

namespace EmployeeManager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WrongInput _wrongInput;
        public MainWindow()
        {
            InitializeComponent();
            _wrongInput = new WrongInput(txtNameEmployee, txtAgeEmployee);
        }

        /// <summary>
        /// Klick-Ereignis für den Enter-Button (Der Benutzer bestätigt die Eingabe)
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst ha</param>
        /// <param name="e">Ereignisdaten</param>
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(txtNameEmployee.Text.Length >0 && txtAgeEmployee.Text.Length >0) // Überprüft, ob die TextBoxen für Name und Alter nicht leer sind
            {
                if (_wrongInput.IsCorrectName(txtNameEmployee.Text)&& _wrongInput.IsNumber(txtAgeEmployee.Text))// Überprüft, ob der Name korrekt ist und ob das Alter eine gültige Zahl ist
                {
                    txtbPrint.Text = $"Herzlich Willkommen {txtNameEmployee.Text}! Ihr Alter ist {txtAgeEmployee.Text} Jahre";// Gibt eine Willkommensnachricht aus, wenn die Eingaben korrekt sind
                }                                                             
            }else { MessageBox.Show("Außerdem müssen Name und Alter angegeben werden !"); }// Zeigt eine Fehlermeldung an, wenn die TextBoxen leer sind
        }
    }
}
