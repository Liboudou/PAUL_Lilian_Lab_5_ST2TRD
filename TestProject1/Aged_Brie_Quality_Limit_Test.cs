using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Aged_Brie_Quality_Limit_Test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> {new Cheese_Item() {Name = "Aged Brie", SellIn = 5, Quality = 10}};
        GildedRose app = new GildedRose(Items);
        for (int i = 0; i < 30; i++)
        {
            app.UpdateQuality();
        }
        Assert.AreEqual(50, Items[0].Quality);
    }
}