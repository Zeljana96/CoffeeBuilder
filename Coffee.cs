using System;
using System.Collections.Generic;

namespace Task3
{
    public class Coffee
    {
        private string _coffeeType;
        private Dictionary<string,string> _parts = new Dictionary<string,string>();

        public Coffee(string coffeeType)
        {
            this._coffeeType = coffeeType;
        }

        public void Add(string part)
        {
            _parts.Add(part, part);
        }

        public override string ToString()
        {
            return String.Join(", ", _parts.Values);
        }
    }
}