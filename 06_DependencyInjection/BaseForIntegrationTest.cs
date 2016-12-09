using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Solid._06_DependencyInjection.Bootstrap;

namespace Solid._06_DependencyInjection
{
    public class BaseForIntegrationTest
    {
        public IUnityContainer Container { get; }

        public BaseForIntegrationTest()
        {
            this.Container = new UnityContainer();
            this.Container.InitializeStub();
        }
    }
}
