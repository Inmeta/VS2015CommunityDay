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

        int answer = 42;
        string FirstName { get; } = "Douglas";
        const string LastName = "Adams";

        TheBook Book = new TheBook();

        public string WhatIsTheMessage { get; }
        public string AndWhen { get; }

        public StringLiterals()
        {
            WhatIsTheMessage = "The answer to it all is \{answer}, coined by \{FirstName} \{LastName} in his book \{Book.Title}";
            AndWhen = "Said the \{DateTime.Now : dd}st of the month \{DateTime.Now : MMMM} ";
        }
    }
}
