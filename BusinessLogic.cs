using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger; // a dummy logger
            _dataAccess = dataAccess; // a dummy dataAccess 

        }
        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            _logger.Log($"Starting the processing of data.");
            Console.WriteLine($"Processing the data.");

            //load some data
            _dataAccess.LoadData();

            //save the data
            _dataAccess.SaveData($"ProcessedInfo");
            _logger.Log($"Finished processing of the data");
        }
    }
}
