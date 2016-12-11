using Solid._06_DependencyInversion.Interfaces;

namespace Solid._06_DependencyInversion.Implementations
{
    public class CalculationService: ICalculate
    {
        //private readonly IAdd _addidtionService;
        //private readonly ISubstract _substractionService;

        //public CalculationService(IAdd addidtionService, ISubstract substractionService)
        //{
        //    _addidtionService = addidtionService;
        //    _substractionService = substractionService;
        //}

        //public int AddTenAndSubstractTwenty(int number)
        //{
        //    var result = this._addidtionService.Add(number, 10);
        //    result = this._substractionService.Substract(result, 20);
        //    return result;
        //}

        public int AddTenAndSubstractTwenty(int number)
        {
            var additionService = new AdditionServiceBroken();
            var substractionService = new SubstractionService();

            var result = additionService.Add(number, 10);
            result = substractionService.Substract(result, 20);
            return result;
        }
    }
}
