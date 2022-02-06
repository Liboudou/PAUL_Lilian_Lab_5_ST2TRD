using System;
using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Aged_Brie_test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> {new Cheese_Item() {Name = "Aged Brie", SellIn = 5, Quality = 10}};
        GildedRose app = new GildedRose(Items);
        for (int i = 0; i < 10; i++)
        {
            app.UpdateQuality();
        }
        Assert.AreEqual(25, Items[0].Quality);
    }
}