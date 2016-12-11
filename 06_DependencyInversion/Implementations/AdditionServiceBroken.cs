using Solid._06_DependencyInversion.Interfaces;

namespace Solid._06_DependencyInversion.Implementations
{
    public class AdditionServiceBroken: IAdd
    {
        public int Add(int leftNumber, int rightNumber)
        {
            return leftNumber + rightNumber + 30;
        }
    }
}
