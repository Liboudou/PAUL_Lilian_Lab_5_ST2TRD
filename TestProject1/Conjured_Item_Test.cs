using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Conjured_Item_Test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> {new Item {Name = "Conjured Mana Cake", SellIn = 5, Quality = 10}};
        GildedRose app = new GildedRose(Items);
        for (int i = 0 ; i < 3; i++) app.UpdateQuality();
        Assert.AreEqual(7, Items[0].Quality);
    }
}