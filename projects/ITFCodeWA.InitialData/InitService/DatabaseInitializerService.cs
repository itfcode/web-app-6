using ITFCodeWA.InitialData.Data.Common.References;
using ITFCodeWA.InitialData.Data.Finance.References;
using ITFCodeWA.InitialData.Health;
using ITFCodeWA.InitialData.InitService.Interfaces;
using ITFCodeWA.Models.Documents;
using ITFCodeWA.Services.DataServices.Documents.Interfaces;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ITFCodeWA.InitialData.InitService
{
    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        #region Private & Protected Fields

        private readonly ILogger<DatabaseInitializerService> _logger;

        private readonly IContractDataService _contractDataService;
        private readonly IContractorDataService _contractorDataService;
        private readonly ICurrencyDataService _currencyDataService;
        private readonly IFoodDataService _foodDataService;
        private readonly IPersonDataService _personDataService;
        private readonly IWeightRegistratorDataService _weightRegistratorDataService;

        #endregion

        #region Constructors 

        public DatabaseInitializerService(ILogger<DatabaseInitializerService> logger,
            IContractDataService contractDataService,
            IContractorDataService contractorDataService,
            ICurrencyDataService currencyDataService,
            IFoodDataService foodDataService,
            IPersonDataService personDataService,
            IWeightRegistratorDataService weightRegistratorDataService
            )
        {
            _logger = logger;
            _contractDataService = contractDataService;
            _contractorDataService = contractorDataService;
            _currencyDataService = currencyDataService;
            _foodDataService = foodDataService;
            _personDataService = personDataService;
            _weightRegistratorDataService = weightRegistratorDataService;
        }

        #endregion

        #region IDatabaseInitializerService Implementation

        public void InitializeData()
        {
            InitializePersons();
            InitializeWeights();
            InitializeFoods();
            InitializeCurrencies();
            InitializeContractors();
        }

        #endregion

        #region Priavte & Protected Methods 

        private void InitializePersons()
        {
            foreach (var person in PersonList.All)
            {
                var entity = _personDataService.GetByUtrAsync(person.Utr).Result;

                if (entity is null)
                {
                    _personDataService.CreateAsync(person).Wait();
                }
            }
        }

        private void InitializeWeights()
        {
            var filePath = @"C:\projects\personal\net6\itfcode.web-app-6\projects\ITFCodeWA.InitialData\Data\Health\Weight\WeightRegistration.json";

            var registrators = JsonConvert.DeserializeObject<List<WeightRegistratorModel>>(File.ReadAllText(filePath));
            foreach (var registrator in registrators)
            {
                var entity = _weightRegistratorDataService.GetByIdAsync(registrator.Id).Result;
                if (entity is null)
                    _weightRegistratorDataService.CreateAsync(registrator).Wait();
            }
        }

        private void InitializeFoods()
        {
            foreach (var food in FoodList.Foods)
            {
                var entity = _foodDataService.GetByNameAsync(food.Name).Result;
                if (entity is null)
                    _foodDataService.CreateAsync(food).Wait();
            }
        }

        private void InitializeCurrencies()
        {
            foreach (var currency in CurrencyList.All)
            {
                var entity = _currencyDataService.GetByCodeAsync(currency.Code).Result;
                if (entity is null)
                    _currencyDataService.CreateAsync(currency).Wait();
            }
        }

        private void InitializeContractors() 
        {
            foreach (var contractor in ContractorList.All)
            {
                var entity = _contractorDataService.GetByNameAsync(contractor.Name).Result;
                if (entity is null)
                    _contractorDataService.CreateAsync(contractor).Wait();
            }
        }

        private void InitializeContracts() 
        {
            //foreach (var contractor in ContractorList.All)
            //{
            //    var entity = _contractorDataService.GetByNameAsync(contractor.Name).Result;
            //    if (entity is null)
            //        _contractorDataService.CreateAsync(entity).Wait();
            //}
        }

        #endregion
    }
}