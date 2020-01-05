using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Services
{
    public class DealsService : IDealsService
    {
        private List<Deal> _deals;
        private readonly IDealsFactory _dealsFactory;

        public DealsService(IDealsFactory dealsFactory)
        {
            _deals = new List<Deal>();
            _dealsFactory = dealsFactory;
        }

        public void AddDeal(DealCategory category)
        {
            _deals.Add(_dealsFactory.GetDeal(category));
        }

        public Deal GetDeal(Guid id)
        {
            return _deals.Find(item => item.Id == id);
        }

        public IEnumerable<Deal> GetDeals()
        {
            return _deals;
        }
    }
}
