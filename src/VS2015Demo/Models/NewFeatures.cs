using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VS2015Demo.Models
{
    //Some C#6 feature...
    public class NewFeatures
    {
        //Auto property init
        public string FirstName { get; set; } = "Test1";
        public string LastName { get; set; } = "Test2";
        public string Address { get; set; } = "Test3";

        public Descendant D { get; set; }
        public string GetDetail()
        {
            //Dictionary init
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                ["USA"] = "Washington DC",
                ["England"] = "London",
                ["India"] = "New Delhi"
            };

            //Null-Conditional Operator
            if (D?.A > 0)
                return string.Empty;

            return $"Logged in {FirstName} , {LastName}";
        }


        public override string ToString() => string.Format($" {FirstName}, {LastName}");

    }



    public class Descendant
    {
        public int A { get; set; }
        public int B { get; set; }

    }
}
