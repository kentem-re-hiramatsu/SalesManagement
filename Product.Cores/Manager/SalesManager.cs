using Product.Cores.Model;
using System.Collections.Generic;

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

        public int GetTotalSalesAmount()
        {
            var totalSalesAmount = 0;

            foreach (Sales sales in _salesList)
            {
                totalSalesAmount += sales.GetSalesAmount();
            }

            return totalSalesAmount;
        }

        public int GetTotalIncomeAmount()
        {
            var totalIncomeAmount = 0;

            foreach (Sales sales in _salesList)
            {
                totalIncomeAmount += sales.GetIncomeAmount();
            }

            return totalIncomeAmount;
        }
    }
}
