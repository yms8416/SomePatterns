using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.SomePatterns.Builder.Models
{
    class Player
    {
        public Player()
        {
            History = new History();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public Team Team { get; set; }
        public History History { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
