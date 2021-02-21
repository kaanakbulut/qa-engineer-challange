using AmazonAutomation.Specs.Constant;
using AmazonAutomation.Specs.Driver;
using AmazonAutomation.Specs.Page;

namespace AmazonAutomation.Specs.Test
{
    public class StepsBase
    {
        protected WebDriver _driver = new WebDriver();

        public StepsBase()
        {
            _driver.Run();
            ConstantsBase.Init(_driver.Driver);
            PageBase.Init(_driver.Driver);

        }

    }
}
