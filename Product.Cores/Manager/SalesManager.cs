using Product.Cores.Model;
using System.Collections.Generic;
using System.Linq;

namespace Product.Cores.Manager
{
    public class SalesManager
    {
        private List<Sales> _salesList = new List<Sales>();

        public IReadOnlyCollection<Sales> SalesList { get { return _salesList; } }

        public void Add(Sales sales)
        {
            _salesList.Add(sales);
        }

        public Sales GetSales(int index)
        {
            return _salesList[index];
        }

        /// <summary>
        /// 売上合計金額
        /// </summary>
        public int GetTotalSalesAmount()
        {
            return _salesList.Sum(sales => sales.GetSalesAmount());
        }

        /// <summary>
        /// 利益合計金額
        /// </summary>
        public int GetTotalIncomeAmount()
        {
            return _salesList.Sum(sales => sales.GetIncomeAmount());
        }
    }
}
