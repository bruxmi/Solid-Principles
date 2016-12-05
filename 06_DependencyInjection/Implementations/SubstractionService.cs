using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection.Implementations
{
    public class SubstractionService: ISubstract
    {
        public int Substract(int leftNumber, int rightNumber)
        {
            return leftNumber - rightNumber;
        }
    }
}
