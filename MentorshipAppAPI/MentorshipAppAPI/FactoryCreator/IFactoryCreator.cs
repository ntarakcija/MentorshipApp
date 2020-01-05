using MentorshipAppAPI.DealsFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public interface IFactoryCreator
    {
        IFactory GetFactory();
    }
}
