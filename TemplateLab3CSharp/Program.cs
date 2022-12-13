using System;

namespace Lab3
{
    class Date
    {
        private int day, month, year;
        public void SetDay(int newDay)
        {
            day = newDay;
        }

        public int GetDay()
        {
            return day;
        }
        public void SetMonth(int newMonth)
        {
            month = newMonth;
        }

        public int GetMonth()
        {
            return month;
        }
        public void SetYear(int newYear)
        {
            year = newYear;
        }

        public int GetYear()
        {
            return year;
        }
        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        private string getMonth()
        {
            switch (month)
            {
                case 1: return "січня";
                case 2: return "лютого";
                case 3: return "березня";
                case 4: return "квітня";
                case 5: return "травня";
                case 6: return "червня";
                case 7: return "липня";
                case 8: return "серпня";
                case 9: return "вересня";
                case 10: return "жовтня";
                case 11: return "листопада";
                case 12: return "грудня";
                default: return "помилка";
            }
        }
        
        public void PrintWithLiteral()
        {
            Console.WriteLine($"{day} {getMonth()} {year} року");
        }

        public void Print()
        {
            Console.WriteLine($"{day}.{month}.{year}");
        }
        private static bool LeapYear(int year)
        {
            return(year % 100 != 0 && year % 4 == 0) || (year % 400 == 0);
        } // end leapYear
        
        public bool Check()
        {
            bool validation = !!(year >= 1600 && year <=2100);

            if(day < 1)
                validation = false;

            switch(month)
            {
                case 2:
                    if(LeapYear(year)) // We only care about leap years in February 
                        if(day > 29)
                            validation = false;
                        else
                        if(day > 28)
                            validation = false;
                    break;
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if(day > 31)
                        validation = false;
                    break;
                case 4: case 6: case 9: case 11:
                    if(day > 30)
                        validation = false;
                    break;
                default: // the month is not between 1 and 12
                    validation = false;
                    break;
            }
            return validation;
        }
        
        // To store number of days in
        // all months from January to Dec.
        static int[] _monthDays = { 31, 28, 31,
            30, 31, 30,
            31, 31, 30,
            31, 30, 31 };
            // This function counts number of
    // leap years before the given date
    static int countLeapYears(Date d)
    {
        int years = d.year;
 
        // Check if the current year
        // needs to be considered
        // for the count of leap years or not
        if (d.month <= 2) {
            years--;
        }
 
        // An year is a leap year if it is
        // a multiple of 4, multiple of 400
        // and not a multiple of 100.
        return years / 4
               - years / 100
               + years / 400;
    }
        public static int getDifference(Date dt1, Date dt2)
        {
            
            // COUNT TOTAL NUMBER OF DAYS
            // BEFORE FIRST DATE 'dt1'
 
            // initialize count using years and day
            int n1 = dt1.year * 365 + dt1.day;
 
            // Add days for months in given date
            for (int i = 0; i < dt1.month - 1; i++)
            {
                n1 += _monthDays[i];
            }
 
            // Since every leap year is of 366 days,
            // Add a day for every leap year
            n1 += countLeapYears(dt1);
 
            // SIMILARLY, COUNT TOTAL
            // NUMBER OF DAYS BEFORE 'dt2'
            int n2 = dt2.year * 365 + dt2.day;
            for (int i = 0; i < dt2.month - 1; i++)
            {
                n2 += _monthDays[i];
            }
            n2 += countLeapYears(dt2);
 
            // return difference between two counts
            return (n2 - n1);
        }

        public int getCentury()
        {
            return year / 100;
        }
        
    }

    class Document
    {
        protected string document;

        public Document()
        {
            document = "Default document";
        }

        public void Show()
        {
            Console.WriteLine($"Document: {document}");
        }

    }

    class Nakladna : Document
    {
        private readonly double price;
        public Nakladna()
        {
            price = 5000;
            document = "Nakladna";
        }
        public new void Show()
        {
            Console.WriteLine($"Document: {document}\nPrice: {price}");
        }
    }
    
    class Ticket : Document
    {
        private readonly double price;
        public Ticket()
        {
            price = 250;
            document = "Ticket";
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {document}\nPrice: {price}");
        }
    }
    
    class Rahunok : Document
    {
        private readonly double price;
        public Rahunok()
        {
            price = 6000;
            document = "Rahunok";
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {document}\nPrice: {price}");
        }
    }

    static class Program
    {
        static void Main()
        {
            Date a = new(8,2,2021);
            Date b = new(10, 2, 2021);
            a.Print();
            a.SetYear(2022);
            b.SetYear(2022);
            b.Print();
            a.PrintWithLiteral();
            Console.WriteLine($"B century: {b.getCentury()}");
            Console.WriteLine($"A-B: {Date.getDifference(a,b)} days");

            var document = new Document();
            document.Show();
            var ticket = new Ticket();
            ticket.Show();
            var rahunok = new Rahunok();
            rahunok.Show();
            var nakladna = new Nakladna();
            nakladna.Show();

        }
    }

    
}



