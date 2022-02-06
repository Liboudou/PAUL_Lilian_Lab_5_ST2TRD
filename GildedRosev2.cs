using System.Collections.Generic;
using System.Reflection;

namespace csharp
{
    public class GildedRosev2
    {
        IList<Item> Items;

        public GildedRosev2(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {

                if (Items[i].GetType() == typeof(Classic_Item))
                {
                    if (Items[i].Quality > 0 & Items[i].SellIn < 1)
                    {
                        Items[i].Quality = Items[i].Quality - 2;
                    }
                    else if (Items[i].Quality > 0)
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }

                    Items[i].SellIn = Items[i].SellIn - 1;
                }
                else if (Items[i].GetType() == typeof(Cheese_Item))
                {
                    if (Items[i].Quality < 50 & Items[i].SellIn <= 0) // le = check
                    {
                        Items[i].Quality +=1;
                        if (50 -Items[i].Quality >=2)
                        {
                            Items[i].Quality +=1;
                        }
                    }
                    else if (Items[i].Quality < 50)
                    {
                        Items[i].Quality +=1;
                    }

                    Items[i].SellIn -=1;
                }
                else if (Items[i].GetType() == typeof(Legendary_Item))
                {

                }
                else if (Items[i].GetType() == typeof(Concert_Item))
                {
                    int diff = 50 - Items[i].Quality;

                    if (Items[i].Quality < 50 & Items[i].SellIn > 0) // le = check
                    {
                        int up = 1;
                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].SellIn < 6)
                            {
                                up = 3;
                            }
                            else
                            {
                                up = 2;
                            }
                        }

                        for (int j = 0; j < up; j++)
                        {
                            if (diff > 1)
                            {
                                Items[i].Quality +=1;
                            }

                            diff -= 1;
                        }
                    }
                    else if (Items[i].SellIn < 1)
                    {
                        Items[i].Quality = 0;
                    }
                    Items[i].SellIn -=1;
                }
                else if (Items[i].GetType() == typeof(Conjured_Item))
                {
                    
                    if (Items[i].Quality > 0 & Items[i].SellIn < 1)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (Items[i].Quality > 0)
                            {
                                Items[i].Quality -=1;
                            }
                        }
                    }
                    else if (Items[i].Quality > 0)
                    {
                        if (Items[i].Quality > 2)
                        {
                            Items[i].Quality -=2;
                        }
                        else
                        {
                            Items[i].Quality -=1;
                        }
                    }

                    Items[i].SellIn = Items[i].SellIn - 1;
                }
            }
        }
    }
}