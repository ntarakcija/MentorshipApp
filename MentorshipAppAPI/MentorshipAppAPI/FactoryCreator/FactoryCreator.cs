using MentorshipAppAPI.DealsFactories;

namespace MentorshipAppAPI
{
    public class FactoryCreator : IFactoryCreator
    {
        // Logic for givin users super deal
        private bool goldenUser = true;
        private IDealsFactory _dealsFactory;
        private ISuperDealsFactory _superDealsFactory;

        public FactoryCreator(IDealsFactory dealsFactory, ISuperDealsFactory superDealsFactory)
        {
            _dealsFactory = dealsFactory;
            _superDealsFactory = superDealsFactory;
        }

        public IFactory GetFactory()
        {
            if (goldenUser)
            {
                return _superDealsFactory;
            }
            else
            {
                return _dealsFactory;
            }
        }
    }
}
