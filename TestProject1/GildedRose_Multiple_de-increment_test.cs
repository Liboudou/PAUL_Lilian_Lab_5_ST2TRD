using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class GildedRose_Multiple_increment_test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item>
        {
            new Item {Name = "foo", SellIn = 5, Quality = 2},
            new Item {Name = "Aged Brie", SellIn = 5, Quality = 2}
        };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.AreEqual(2, Items.Count);
        Assert.AreEqual(1,Items[0].Quality);
        Assert.AreEqual(3,Items[1].Quality);
    }
}