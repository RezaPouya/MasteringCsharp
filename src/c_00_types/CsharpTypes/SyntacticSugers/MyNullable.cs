using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTypes.SyntacticSugers
{
    // for making null , we just zero the bytes - use default constructor
    internal struct MyNullable<T> where T : struct
    {
        public T Value { get; private set; }
        public bool HasValue { get; private set; } // default : false 

        public MyNullable(T value)
        {
            Value = value;
            HasValue = true;
        }

        // to string always return legimate string 
        public override string ToString()
        {
            return HasValue ? Value.ToString() : null;
        }
    }
}
