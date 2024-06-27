using Products.Cores.Models;
using System.Collections.Generic;
using System.Linq;

namespace Products.Cores.Managers
{
    public class SalesHistoryManager
    {
        private List<Sale> _historyList = new List<Sale>();

        public IReadOnlyCollection<Sale> HistoryList { get { return _historyList; } }

        public void Add(Sale sale) => _historyList.Add(sale);

        public Sale GetSale(int index) => _historyList[index];

        /// <summary>
        /// 売上合計金額
        /// </summary>
        public int GetTotalSalesAmount() => _historyList.Sum(sale => sale.GetSalesAmount());

        /// <summary>
        /// 利益合計金額
        /// </summary>
        public int GetTotalIncomeAmount() => _historyList.Sum(sale => sale.GetIncomeAmount());

        public IEnumerable<Sale> SalesColumSort(int index, bool descendingButtonEnabled)
        {
            IEnumerable<Sale> sortList = null;

            switch (index)
            {
                case Consts.PRODUCT_NAME_COLUMN:
                    sortList = descendingButtonEnabled ? _historyList.OrderBy(x => x.Purchase.Product.Name)
                                                       : _historyList.OrderByDescending(x => x.Purchase.Product.Name);
                    break;
                case Consts.SALE_PRICE_COLUMN:
                    sortList = descendingButtonEnabled ? _historyList.OrderBy(x => x.Purchase.SalePrice)
                                                       : _historyList.OrderByDescending(x => x.Purchase.SalePrice);
                    break;
                case Consts.PURCHASE_DAY_COLUMN:
                    sortList = descendingButtonEnabled ? _historyList.OrderBy(x => x.Purchase.PurchaseDateTime)
                                                       : _historyList.OrderByDescending(x => x.Purchase.PurchaseDateTime);
                    break;
                case Consts.SALE_DAY_COLUMN:
                    sortList = descendingButtonEnabled ? _historyList.OrderBy(x => x.SaleDateTime)
                                                       : _historyList.OrderByDescending(x => x.SaleDateTime);
                    break;
                case Consts.SALE_QUANTITY_COLUMN:
                    sortList = descendingButtonEnabled ? _historyList.OrderBy(x => x.SaleQuantity)
                                                       : _historyList.OrderByDescending(x => x.SaleQuantity);
                    break;
                case Consts.SALE_AMOUNT_COLUMN:
                    sortList = descendingButtonEnabled ? _historyList.OrderBy(x => x.GetSalesAmount())
                                                       : _historyList.OrderByDescending(x => x.GetSalesAmount());
                    break;
                default: break;
            }
            return sortList;
        }
    }
}