﻿using System;

namespace Products.Cores.Models
{
    public class Sale
    {
        public int SaleQuantity { get; set; }
        public DateTime SaleDateTime { get; private set; }
        public Purchase Purchase { get; }

        public Sale(int saleQuantity, DateTime saleDateTime, Purchase purchase)
        {
            if (saleQuantity > 0 && saleDateTime >= purchase.PurchaseDateTime)
            {
                SaleQuantity = saleQuantity;
                SaleDateTime = saleDateTime;
            }
            else if (saleQuantity <= 0)
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            else if (saleDateTime < purchase.PurchaseDateTime)
            {
                throw new Exception(Consts.LESS_THAN_SALEDAY_ERROR_MESSAGE);
            }
            Purchase = purchase;
        }

        public void UpdateInventory(int saleQuantity)
        {
            if (Purchase.StockQuantity >= saleQuantity)
            {
                Purchase.StockQuantity -= saleQuantity;
            }
            else
            {
                throw new Exception(Consts.INVENTORY_QUANTITY_ERROR_MESSAGE);
            }
        }

        /// <summary>
        /// 売上金額
        /// </summary>
        public int GetSalesAmount() => Purchase.SalePrice * SaleQuantity;

        /// <summary>
        /// 利益金額
        /// </summary>
        public int GetIncomeAmount() => GetSalesAmount() - Purchase.PurchasePrice * SaleQuantity;
    }
}