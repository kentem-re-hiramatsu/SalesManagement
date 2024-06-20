using Product.Cores.Model;
using System.Collections.Generic;

namespace Product.Cores.Manager
{
    public class HistoryManager
    {
        private List<Sale> _historyList = new List<Sale>();

        public IReadOnlyCollection<Sale> HistoryList { get { return _historyList; } }

        public void Add(Sale sale) => _historyList.Add(sale);

        public Sale GetSale(int index) => _historyList[index];
    }
}
