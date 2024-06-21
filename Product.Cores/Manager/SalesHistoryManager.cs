using Product.Cores.Model;
using System.Collections.Generic;
using System.Linq;

namespace Product.Cores.Manager
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
    }
}
