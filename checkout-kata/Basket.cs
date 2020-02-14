using System;
using System.Collections.Generic;

namespace checkout_kata
{
    public class Basket
    {
        private static Dictionary<Stock.Item, int> BasketDictionary = new Dictionary<Stock.Item, int>();
        // private static List<Stock.Item> StockList = Stock.CurrentProducts();
        

        public static void Scan(Stock.Item produce)
        {
            if (BasketDictionary.ContainsKey(produce) == false)
            {
                BasketDictionary.Add(produce, 1);
            }
            else
            {
                BasketDictionary[produce]+=1;
            }
        }

        public static float Total()
        {
            float total = 0;
            if (BasketDictionary.Count == 0)
            {
                return 0;
            }

            foreach (KeyValuePair<Stock.Item, int> produce in BasketDictionary)
            {
                if(produce.Value >= 0)
                {
                    for (int i=1; i<=produce.Value; i++)
                    {
                        total += produce.Key.UnitPrice;
                        if (produce.Key.SpecialOfferNumOfItems > 0 && i == produce.Key.SpecialOfferNumOfItems)
                        {
                            total -= (produce.Key.UnitPrice*produce.Key.SpecialOfferNumOfItems)-produce.Key.SpecialOfferPrice;
                        }
                        
                    }
                    
                }

            }

            BasketDictionary = new Dictionary<Stock.Item, int>();
            return total;
        }

        private static float SpecialOfferCheck()
        {
            if (BasketDictionary[Stock.Apple] == Stock.Apple.SpecialOfferNumOfItems)
            {
                return Stock.Apple.SpecialOfferPrice;
            }
        
            if (BasketDictionary[Stock.Banana] == Stock.Banana.SpecialOfferNumOfItems)
            {
                return Stock.Banana.SpecialOfferPrice;
            }
            else return 0;
        }


      
    }


}
