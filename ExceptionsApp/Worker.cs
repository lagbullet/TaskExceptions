using System;
using System.Globalization;
using System.Linq;

namespace ExceptionsApp
{
    class Worker
    {
        private string surName;
        private string firstName;
        private string patronymic;
        private string birthdate;
        private double salary;

        public string SurName
        {
            get { return surName; }
            set {
                if (value.Any(c => char.IsDigit(c)) || string.IsNullOrEmpty(value))
                    throw new InvalidPersonalInfoException("Invalid SurName");
                else
                    surName = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Any(c => char.IsDigit(c)) || string.IsNullOrEmpty(value))
                    throw new InvalidPersonalInfoException("Invalid FirstName");
                else
                    firstName = value;
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (value.Any(c => char.IsDigit(c)) || string.IsNullOrEmpty(value))
                    throw new InvalidPersonalInfoException("Invalid Patronymic");
                else
                    patronymic = value;
            }
        }

        public string Birthdate
        {
            get { return birthdate; }
            set
            {
                if (DateTime.TryParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime result))
                    birthdate = result.ToShortDateString();
                else
                    throw new InvalidPersonalInfoException("Invalid Birthdate");

            }
        }
        public string Salary
        {
            get { return salary.ToString(); }
            set
            {
                if (double.TryParse(value, out double k))
                    salary = k;
                else
                    throw new InvalidPersonalInfoException("Invalid Salary");
            }
        }
        
        public void SetWorker()
        {
            try
            {
                Console.Write("Enter a SurName -> ");
                SurName = Console.ReadLine();
                Console.Write("Enter a FirstName -> ");
                FirstName = Console.ReadLine();
                Console.Write("Enter a Patronymic -> ");
                Patronymic = Console.ReadLine();
                Console.Write("Enter a Birthdate -> ");
                Birthdate = Console.ReadLine();
                Console.Write("Enter a Salary -> ");
                Salary =  Console.ReadLine();
            }
            catch (InvalidPersonalInfoException ex)
            {
                SurName = "Undefined";
                FirstName = "Undefined";
                Patronymic = "Undefined";
                Birthdate = "01.01.2000";
                Salary = "0";
                Console.WriteLine(ex.GetType() + " : " + ex.Message);
                Console.WriteLine($"Help link -> {ex.HelpLink}");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"SurName - {SurName}\nFirstName - {FirstName}\nPatronymic - {Patronymic}\nBirth date - {Birthdate}\nSalary - {Salary}");
        }

        public Worker()
        {
            SurName = "Undefined";
            FirstName = "Undefined";
            Patronymic = "Undefined";
            Birthdate = "01.01.2000";
            Salary = "0";
        }

        public Worker(string surname, string firstname, string patronymic, string birthdate, double salary)
        {
            try
            {
                SurName = surname;
                FirstName = firstname;
                Patronymic = patronymic;
                Birthdate = birthdate;
                Salary = salary.ToString();
            }
            catch (InvalidPersonalInfoException ex)
            {
                SurName = "Undefined";
                FirstName = "Undefined";
                Patronymic = "Undefined";
                Birthdate = "01.01.2000";
                Salary = "0";
                Console.WriteLine(ex.GetType() +" : "+ ex.Message);
            }
        }
    }
}
