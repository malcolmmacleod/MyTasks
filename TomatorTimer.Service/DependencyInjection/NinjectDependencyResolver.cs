using Ninject;
using System.Threading;
using TomatoTimer.Domain.Repository;
using TomatoTimer.Data;

namespace TomatorTimer.Service.DependencyInjection
{
    public class NinjectFactory
    {
        #region Fields

        private IKernel ninjectKernel;
        private string baseAddress;


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NinjectControllerFactory"/> class.
        /// </summary>
        public NinjectFactory()
        {
            ninjectKernel = new StandardKernel(new NinjectSettings() { UseReflectionBasedInjection = true });

            AddBindings();
        }

        #endregion

        #region Properties

        public ITaskRepository TaskRepository
        {
            get
            {
                return ninjectKernel.Get<ITaskRepository>();
            }
        }

        

        #endregion

        #region Methods



        /// <summary>
        /// Adds the bindings.
        /// </summary>
        private void AddBindings()
        {
            ninjectKernel.Bind<ITaskRepository>().To(typeof(TaskRepository));
        }

        #endregion

    }
}