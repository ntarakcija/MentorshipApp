using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Services
{
    public interface IDealsService
    {
        IEnumerable<Deal> GetDeals();
        Deal GetDeal(Guid id);
        void AddDeal(DealCategory category);
    }
}
