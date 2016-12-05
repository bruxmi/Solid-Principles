using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection.Implementations
{
    public class AdditionServiceBroken: IAdd
    {
        public int Add(int leftNumber, int rightNumber)
        {
            return leftNumber + rightNumber + 30;
        }
    }
}
