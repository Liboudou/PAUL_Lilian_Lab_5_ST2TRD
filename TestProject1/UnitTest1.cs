using System;
using csharp;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        try
        {
            Item test = new Item{ Name = "foo", SellIn = 0, Quality = 0 };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Assert.Fail();
            throw;
        }
        
        Assert.Pass();
    }
}