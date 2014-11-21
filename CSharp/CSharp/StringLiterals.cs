using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharp
{

    public class TheBook
    {
        public string Title { get;}

        public TheBook()
        {
            Title = "Hitchhikers guide to the galaxy";
        }
    }

    public class StringLiterals
    {

        const int Answer = 42;
        const string FirstName = "Douglas";
        const string LastName = "Adams";

        TheBook Book = new TheBook();

        public string WhatIsTheMessage { get; }
        public string AndWhen { get; }

        public string RepeatIt(string message)
        {
            return message;
        }

        public StringLiterals()
        {
            string OldWay = string.Format("The answer to it all is {0}, coined by {1} {2} in his book {3}", Answer, FirstName, LastName, Book.Title);

            WhatIsTheMessage = "The answer to it all is \{Answer}, coined by \{FirstName} \{LastName} in his book \{Book.Title}";


            AndWhen = "Said the \{DateTime.Now : dd}st of the month \{DateTime.Now : MMMM} ";
            string repeated = RepeatIt("So it was \{FirstName}");
            AndWhen += repeated;
        }

        public string CultureStuff()
        {

            return INV("Så dette er {FirstName}");

        }

        /// <summary>
        /// Returning in Invariant Culture
        /// </summary>
        public static string INV(IFormattable formattable)
        {
            return formattable.ToString(null, System.Globalization.CultureInfo.InvariantCulture);
        }

    }
}
