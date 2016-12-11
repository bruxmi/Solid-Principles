using Solid._06_DependencyInversion.Interfaces;

namespace Solid._06_DependencyInversion.Implementations
{
    public class SubstractionService: ISubstract
    {
        public int Substract(int leftNumber, int rightNumber)
        {
            return leftNumber - rightNumber;
        }
    }
}
