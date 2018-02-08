using NUnit.Framework;

namespace TestingEf2.Tests1
{
    [SetUpFixture]
    public class MainSetup
    {
        [OneTimeSetUp]
        public void Setup()
        {   
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }
    }
}
