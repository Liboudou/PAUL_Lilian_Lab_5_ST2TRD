
using System.Data;
using System.Xml.Serialization;
using csharp;
using System;
using System.Collections.Generic;
namespace Test
{
    using System;
    using System.Collections.Generic;

    public class Test_item_creation
    {
        
        //Arrange : prepare required data
        private Item item1 = new Item{ Name = "foo", SellIn = 0, Quality = 0 };

        private string expected_name = "foo";
        // Act : test
        

        public bool run()
        {
             string current_name = item1.Name;
             if (current_name == expected_name)
             {
                 return true;
             } 
             return false;
             
        }
        

        // Assert- check if returned result equals expected result





    }
}