using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TomatorTimer.Service.DependencyInjection;

namespace TomatorTimer.Service
{
    public abstract class ServiceBase
    {
        private NinjectFactory repositoryFactory;

        public ServiceBase()
        {
            repositoryFactory = new NinjectFactory();
        }

        protected NinjectFactory RepositoryFactory
        {
            get { return repositoryFactory; }
        }
    }
}
