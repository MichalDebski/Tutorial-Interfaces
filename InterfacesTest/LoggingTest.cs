using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterfacesTest
{
    [TestClass]
    public class LoggingTest
    {
        [TestMethod]
        public void LogPerson()
        {
            var person = new Person()
            {
                FirstName = "Michał",
                LastName = "Dębski",
                DateOfBirth = new DateTime(2017, 4, 25),
                Gender = "Male"
            };
            
            LoggingService.WriteToLog(person);
        }
    }
}