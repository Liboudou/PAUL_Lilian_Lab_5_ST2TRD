using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Concert_ticket_Sellin_Test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10}};
        GildedRose app = new GildedRose(Items);
        for(int i =0; i<11; i++){  app.UpdateQuality();}
        Assert.AreEqual(0, Items[0].Quality);
    }
}