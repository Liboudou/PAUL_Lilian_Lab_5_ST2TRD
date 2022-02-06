using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Classic_Item_decrementation_Test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> {new Classic_Item() {Name = "foo", SellIn = 5, Quality = 10}};
        GildedRose app = new GildedRose(Items);
        for(int i =0; i<6; i++){  app.UpdateQuality();}
        Assert.AreEqual(3, Items[0].Quality);
    }
}