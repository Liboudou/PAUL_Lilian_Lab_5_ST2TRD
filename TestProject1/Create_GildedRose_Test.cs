using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class Create_GildedRose_Test
{
    [Test]
    public void Test1()
    {
        IList<Item> Items = new List<Item> {new Classic_Item() {Name = "foo", SellIn = 0, Quality = 0}};
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.AreEqual("foo", Items[0].Name);
    }
}