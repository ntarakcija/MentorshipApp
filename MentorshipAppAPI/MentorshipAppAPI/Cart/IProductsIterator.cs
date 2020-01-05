using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public interface IProductsIterator
    {
        Product Next();
        bool HasNext();
    }
}
