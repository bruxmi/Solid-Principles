using Microsoft.Practices.Unity;
using Solid._06_DependencyInversion.Interfaces;
using Solid._06_DependencyInversion.Implementations;

namespace Solid._06_DependencyInversion.Bootstrap
{
    public static class Bootstrapper
    {
        public static void InitializeProd(this IUnityContainer container)
        {
            container.RegisterType<IAdd, AdditionServiceBroken>();
            container.RegisterType<ISubstract, SubstractionService>();
            container.RegisterType<ICalculate, CalculationService>();
        }

        public static void InitializeStub(this IUnityContainer container)
        {
            container.RegisterType<IAdd, AdditionServiceCorrect>();
            container.RegisterType<ISubstract, SubstractionService>();
            container.RegisterType<ICalculate, CalculationService>();
        }
    }
}
