using Microsoft.Practices.Unity;
using Solid._06_DependencyInjection.Implementations;
using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection.Bootstrap
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
