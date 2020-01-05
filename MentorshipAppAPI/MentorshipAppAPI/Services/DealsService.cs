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
        private readonly IFactoryCreator _factoryCreator;

        public DealsService(IFactoryCreator factoryCreator)
        {
            _deals = new List<Deal>();
            _factoryCreator = factoryCreator;
        }

        public void AddDeal(DealCategory category)
        {
            _deals.Add(_factoryCreator.GetFactory().GetDeal(category));
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
