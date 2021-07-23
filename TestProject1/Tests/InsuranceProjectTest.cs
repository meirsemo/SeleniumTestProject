using NUnit.Framework;
using TestProject1.HelperObjects;
using TestProject1.PageObjects.InsuranceProject;
using TestProject1.PageObjects.Navigation;

namespace TestProject1.Tests
{
    class InsuranceProjectTest : BaseTest
    {
        [Test]
        public void Test()
        {
            InsuranceProjectNav insurance = new InsuranceProjectNav(driver);

            LoginInsurancePage loginInsurancePage = insurance.NavigateToInsurancePage();
            RegisterInsurancePage registerPage = loginInsurancePage.ClickRegister();
            loginInsurancePage = registerPage.RegisterProcess(RegisterObject.TestModel);

            LoggedInsurancePage loggedPage = loginInsurancePage.LoginProcess(RegisterObject.TestModel.Email, RegisterObject.TestModel.Password);
            loggedPage.ClickRequestQuotation();
        }

    }
}
