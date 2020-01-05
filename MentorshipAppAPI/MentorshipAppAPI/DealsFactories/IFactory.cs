using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.DealsFactories
{
    public interface IFactory
    {
        Deal GetDeal(DealCategory category);
    }
}
