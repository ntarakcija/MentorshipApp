using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public interface IProductsCollection
    {
        IProductsIterator GetProductsIterator();
    }
}
