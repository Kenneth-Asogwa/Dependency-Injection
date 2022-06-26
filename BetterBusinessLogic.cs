using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
      {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        //    ILogger _logger;
        //    IDataAccess _dataAccess;

        //this constructor will recieve two argument for the dependencies that we will inject to it
        //this is the design pattern of dependency injection
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger; // a dummy logger
            _dataAccess = dataAccess; // a dummy dataAccess 

        }
        public void ProcessData()
        {
            //the dependencies are injected into this class
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            _logger.Log($"Starting the processing of data.");
            Console.WriteLine();
            Console.WriteLine($"Processing the data.");

            //load some data
            _dataAccess.LoadData();

            //save the data
            _dataAccess.SaveData($"ProcessedInfo");
            Console.WriteLine();
            _logger.Log($"Finished processing of the data");
            Console.WriteLine();
        }
    }
}
