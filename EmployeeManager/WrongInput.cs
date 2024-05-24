using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EmployeeManager
{
    internal class WrongInput 
    {
        private TextBox _txtNameEmployee;
        private TextBox _txtAgeEmployee;
        private ChangeStyle _changeStyle;

        /// <summary>
        /// Konstruktor der Klasse, der die TextBoxen und ChangeStyle initialisiert
        /// </summary>
        /// <param name="txtNameEmployee">TextBox für den Namen des Mitarbeiters</param>
        /// <param name="txtAgeEmployee">TextBox für das Alter des Mitarbeiters</param>
        public WrongInput(TextBox txtNameEmployee, TextBox txtAgeEmployee) 
        {
            _txtNameEmployee = txtNameEmployee;
            _txtAgeEmployee = txtAgeEmployee;
            _changeStyle = new ChangeStyle(txtNameEmployee, txtAgeEmployee);// Initialisiert die ChangeStyle-Instanz
        }

        /// <summary>
        /// Überprüfung der Richtigkeit des eingegebenen Namens. Der Name darf keine 
        /// Zahlen enthalten und die Größe des Namens muss mehr als 5 Buchstaben betragen
        /// </summary>
        /// <param name="entry">Der eingegebene Name</param>
        /// <returns>True, wenn der Name korrekt ist, andernfalls False</returns>
        public bool IsCorrectName(string entry)
        {
            if (entry.Any(char.IsDigit))// Überprüft, ob der Name Zahlen enthält
            {
                _changeStyle.ChangeColorTXT("txtName", "no");// Ändert die Farbe der TextBox zu rot
                MessageBox.Show("Ungültige Eingabe. Schreiben Sie nur Alphabete für Name");// Zeigt eine Fehlermeldung an
                _txtNameEmployee.Clear();// Löscht den Inhalt der TextBox
                return false;
            }
            else if (entry.Length < 5)
            {
                _changeStyle.ChangeColorTXT("txtName", "no");// Ändert die Farbe der TextBox zu rot
                MessageBox.Show("Der Name ist zu kurz, bitte geben Sie den vollständigen Namen ein");
                _txtNameEmployee.Clear();// Löscht den Inhalt der TextBox
                return false;
            }
            _changeStyle.ChangeColorTXT("txtName", "yes");// Ändert die Farbe der TextBox zu weiß
            return true;
        }

        /// <summary>
        /// Überprüfung, ob die Eingabe eine gültige Zahl für das Alter ist.
        /// Das Alter muss zwischen 18 und 99 Jahren liegen.
        /// </summary>
        /// <param name="entry">Die eingegebene Zahl</param>
        /// <returns>True, wenn die Zahl korrekt ist, andernfalls False</returns>
        public bool IsNumber(string entry)
        {
            try
            {
                int number = Convert.ToInt32(entry);// Konvertiert den Eingabewert in eine Ganzzahl
                if (number < 18 || number > 99) // Überprüft, ob das Alter zwischen 18 und 99 Jahren liegt
                {
                    _changeStyle.ChangeColorTXT("txtAge", "no");// Ändert die Farbe der TextBox zu rot
                    MessageBox.Show("Das Alter kann zwischen 18 und 99 Jahren liegen !");
                    _txtAgeEmployee.Clear();// Löscht den Inhalt der TextBox
                    return false;
                }
                _changeStyle.ChangeColorTXT("txtAge", "yes");
                return true;
            }
            catch (Exception)
            {
                _changeStyle.ChangeColorTXT("txtAge", "no");
                MessageBox.Show("Das Alter kann nur eine Zahl sein !");
                _txtAgeEmployee.Clear();
                return false;
            }
        }
    }
}
