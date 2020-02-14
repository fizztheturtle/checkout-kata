using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace checkout_kata
{
    public class Stock
    {
        public static readonly Item Apple = new Stock.Item
        {
            Sku = "A99",
            UnitPrice = 50,
            SpecialOfferNumOfItems = 3,
            SpecialOfferPrice = 130,
        };

        public static readonly Item Banana = new Stock.Item
        {
            Sku = "B15",
            UnitPrice = 30,
            SpecialOfferNumOfItems = 2,
            SpecialOfferPrice = 45,
        };

        public static readonly Item Crackers = new Stock.Item
        {
            Sku = "C40",
            UnitPrice = 60,
            SpecialOfferNumOfItems = 0,
            SpecialOfferPrice = 0,
        };

        public static readonly Item TidePod = new Stock.Item
        {
            Sku = "T34",
            UnitPrice = 99,
            SpecialOfferNumOfItems = 0,
            SpecialOfferPrice = 0,
        };
        public struct Item
        {
            public Item(string sku, float unitPrice, int specialOfferNumOfItems, float specialOfferPrice)
            {
                Sku = sku;
                UnitPrice = unitPrice;
                SpecialOfferNumOfItems = specialOfferNumOfItems;
                SpecialOfferPrice = specialOfferPrice;
            }
            public Item(string sku, float unitPrice)
            {
                Sku = sku;
                UnitPrice = unitPrice;
                SpecialOfferNumOfItems = 0;
                SpecialOfferPrice = 0;
            }

            public string Sku { get; set; }
            public float UnitPrice { get; set; }
            public int SpecialOfferNumOfItems { get; set; }
            public float SpecialOfferPrice { get; set; }
        }
        public static List<Item> CurrentProducts()
        {
            var currentStock = new List<Item>
            {
                Apple,
                Banana,
                Crackers,
                TidePod
            };
            return currentStock;
        }

    }
}
