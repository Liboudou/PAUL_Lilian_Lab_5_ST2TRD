using System;
using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Sulfuras_test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> { new Legendary_Item() { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        var Quality = Items[0].Quality;
        Assert.AreEqual(80, Quality);

    }
        
    
}