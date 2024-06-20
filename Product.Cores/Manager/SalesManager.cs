using Product.Cores.Model;
using System.Collections.Generic;
using System.Linq;

namespace Product.Cores.Manager
{
    public class SalesManager
    {
        private List<Sale> _saleList = new List<Sale>();

        public IReadOnlyCollection<Sale> SalesList { get { return _saleList; } }

        public void Add(Sale sale) => _saleList.Add(sale);

        public Sale GetSales(int index) => _saleList[index];

        /// <summary>
        /// 売上合計金額
        /// </summary>
        public int GetTotalSalesAmount() => _saleList.Sum(sale => sale.GetSalesAmount());

        /// <summary>
        /// 利益合計金額
        /// </summary>
        public int GetTotalIncomeAmount() => _saleList.Sum(sale => sale.GetIncomeAmount());
    }
}
