using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wex_test.Application.ViewModels;
using wex_test.Domain;

namespace wex_test.Application.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly ITransactionWexRepository _transactionWexRepository;
        private readonly IFiscalDataTreasuryService _fiscalDataTreasuryService;
        private readonly IMapper _mapper;


        public TransactionService(ITransactionWexRepository transactionWexRepository, IMapper mapper, IFiscalDataTreasuryService fiscalDataTreasuryService)
        {
            this._transactionWexRepository = transactionWexRepository;
            this._mapper = mapper;
            _fiscalDataTreasuryService = fiscalDataTreasuryService;
        }
        public async Task CreateTransaction(TransactionViewModel transactionViemodel)
        {
            var transaction = _mapper.Map<TransactionWex>(transactionViemodel);
            var fiscalDataResponse = await this._fiscalDataTreasuryService.GetDataTreasures(transactionViemodel.TransactionDate.AddMonths(-6));
            decimal exchange = 0;
            string exchange_response = "";
            string countryCurrencyDescription = "";
            if (fiscalDataResponse != null && fiscalDataResponse.Data != null)
            {
                var fiscalData = fiscalDataResponse.Data.OrderByDescending(s => s.RecordDate).ToList().FirstOrDefault(); 
                exchange = Convert.ToDecimal(fiscalData.ExchangeRate);
                countryCurrencyDescription = fiscalData.CountryCurrencyDescription;
            }
            transaction.CalculateConversion(exchange, countryCurrencyDescription);
            _transactionWexRepository.Create(transaction);
        }

        public async Task<IEnumerable<TransactionViewModel>> GetTransactions()
        {
            var transactionList = _mapper.Map<IEnumerable<TransactionViewModel>>(await _transactionWexRepository.GetTransactions());

            return transactionList;
        }
    }
}
