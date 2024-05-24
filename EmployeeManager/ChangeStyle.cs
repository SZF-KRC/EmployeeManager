using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace EmployeeManager
{
    internal class ChangeStyle 
    {
        private TextBox _txtNameEmployee;
        private TextBox _txtAgeEmployee;

        /// <summary>
        /// Konstruktor der Klasse, der die TextBoxen initialisiert
        /// </summary>
        /// <param name="txtNameEmployee">TextBox für den Namen des Mitarbeiters</param>
        /// <param name="txtAgeEmployee">TextBox für das Alter des Mitarbeiters</param>
        public ChangeStyle(TextBox txtNameEmployee, TextBox txtAgeEmployee)
        {
            _txtNameEmployee = txtNameEmployee;
            _txtAgeEmployee = txtAgeEmployee;
        }

        /// <summary>
        /// Methode zur Änderung der TextBox-Farbe basierend auf der Validität der Eingabe
        /// </summary>
        /// <param name="txtForm">Der Typ der TextBox ("txtName" oder "txtAge")</param>
        /// <param name="isCorrect">Der Status der Validität ("yes" oder "no")</param>
        public void ChangeColorTXT(string txtForm, string isCorrect)
        {
            switch (txtForm)
            {
                case "txtName":
                    switch (isCorrect)
                    {
                        // Wechselt die Farbe der Name-TextBox basierend auf isCorrect
                        case "no":
                            _txtNameEmployee.Background = new SolidColorBrush(Colors.Red);
                            _txtNameEmployee.Foreground = new SolidColorBrush(Colors.White);
                            break;
                        case "yes":
                            _txtNameEmployee.Background = new SolidColorBrush(Colors.White);
                            _txtNameEmployee.Foreground = new SolidColorBrush(Colors.Black);
                            break;
                    }

                    break;
                case "txtAge":
                    switch (isCorrect)
                    {
                        // Wechselt die Farbe der Name-TextBox basierend auf isCorrect
                        case "no":
                            _txtAgeEmployee.Background = new SolidColorBrush(Colors.Red);
                            _txtAgeEmployee.Foreground = new SolidColorBrush(Colors.White);
                            break;
                        case "yes":
                            _txtAgeEmployee.Background = new SolidColorBrush(Colors.White);
                            _txtAgeEmployee.Foreground = new SolidColorBrush(Colors.Black);
                            break;
                    }
                    break;
            }
        }
    }
}
