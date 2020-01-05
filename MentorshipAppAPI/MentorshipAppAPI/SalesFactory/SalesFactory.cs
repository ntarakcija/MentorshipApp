using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.SalesFactory
{
    public class SalesFactory
    {
        private IDealsFactory _dealsFactory;
        private ISuperDealsFactory _superDealsFactory;
        // Logic for givin users super deal
        private bool goldenUser = true;

        public SalesFactory(IDealsFactory dealsFactory, ISuperDealsFactory superDealsFactory)
        {
            _dealsFactory = dealsFactory;
            _superDealsFactory = superDealsFactory;
        }

        public Deal GetDeal(DealCategory category)
        {
            if (goldenUser)
            {
                // Gets deal with 2 products for 90% price
                return _superDealsFactory.GetDeal(category);
            }
            else
            {
                // Gets deal with 4 products for 70% price
                return _dealsFactory.GetDeal(category);
            }
        }
    }
}
