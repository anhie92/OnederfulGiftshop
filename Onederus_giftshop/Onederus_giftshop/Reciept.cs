﻿using System;
namespace Onederus_giftshop
{
    public class Receipt
    {
        public void DisplayRecieptItems(List<GiftProduct> orderedItems)
        {
            foreach (GiftProduct item in orderedItems)
            {
                Console.WriteLine($"{product.Name}, {product.Price:c}");
            }
            Console.WriteLine(GetTotalCost);

        }

        // these are overloads of the same method to handle different transactions

        // display check receipt
        public void DisplayReceipt(Check check)
        {
            Console.WriteLine($"Total paid by check with check #{check.CheckNumber}\n");
        }

        // display cash receipt
        public void DisplayReceipt(Cash cash)
        {
            Console.WriteLine("Total paid by cash. Your change was {0:C}\n", Math.Round(cash.Change, 2));
        }

        // display credit card receipt
        public void DisplayReceipt(CreditCard cc)
        {
            var lastFour = cc.CreditCardNumber.Substring(8, 4);
            Console.WriteLine($"Total paid by credit card with credit card #xxxx-xxxx-xxxx-{lastFour}\n");
        }
    }
}

