using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject1.HelperObjects;
using static TestProject1.HelperObjects.RegisterObject;

namespace TestProject1.PageObjects.InsuranceProject
{
    public class RegisterInsurancePage : Base
    {
        public IWebElement LoginBtn() => Driver.FindElement(By.LinkText("Login"));
        public IWebElement ComboTitleEl() => Driver.FindElement(By.Id("user_title"));
        public IWebElement FNameEl() => Driver.FindElement(By.Name("firstname"));
        public IWebElement LNameEl() => Driver.FindElement(By.Name("lastname"));
        public IWebElement PhoneEl() => Driver.FindElement(By.Name("phone"));
        public IWebElement ComboDateYearEl() => Driver.FindElement(By.Name("year"));
        public IWebElement ComboDateMonthEl() => Driver.FindElement(By.Name("month"));
        public IWebElement ComboDateDayEl() => Driver.FindElement(By.Name("date"));
        public IWebElement FullLicenceTypeEl() => Driver.FindElement(By.Id("licencetype_t"));
        public IWebElement ProLicenceTypeEl() => Driver.FindElement(By.Id("licencetype_f"));
        public IWebElement ComboLicencePeriodEl() => Driver.FindElement(By.Name("licenceperiod"));
        public IWebElement ComboOccupationEl() => Driver.FindElement(By.Name("occupation"));
        public IWebElement StreetEl() => Driver.FindElement(By.Name("street"));
        public IWebElement CityEl() => Driver.FindElement(By.Name("city"));
        public IWebElement CountyEl() => Driver.FindElement(By.Name("county"));
        public IWebElement PostCodeEl() => Driver.FindElement(By.Id("user_address_attributes_postcode"));
        public IWebElement EmailEl() => Driver.FindElement(By.Name("email"));
        public IWebElement PasswordEl() => Driver.FindElement(By.Name("password"));
        public IWebElement ConnfirmPassEl() => Driver.FindElement(By.Name("c_password"));
        public IWebElement CreatBtn() => Driver.FindElement(By.Name("submit"));
        public IWebElement ResetBtn() => Driver.FindElement(By.Name("resetform"));

        public RegisterInsurancePage(IWebDriver driver) : base(driver)
        {
            Assert.IsTrue(Driver.Title.Contains("Register"), "Page title doesn't match");
        }
        public LoginInsurancePage ClickLogin()
        {
            Helper.BtnClick(LoginBtn);
            return new LoginInsurancePage(Driver);
        }
        public void SelectTitle(TitleCombo select)
        {
            Helper.ComboBox(ComboTitleEl, select.ToString());
            Assert.IsTrue(ComboTitleEl().GetAttribute("value").Equals(select.ToString()));
        }
        public void InsertFirstName(string fName)
        {
            Helper.CheckTextField(FNameEl, fName);
            Assert.IsTrue(FNameEl().GetAttribute("value").Equals(fName));
        }
        public void InsertLastName(string lName)
        {
            Helper.CheckTextField(LNameEl, lName);
            Assert.IsTrue(LNameEl().GetAttribute("value").Equals(lName));
        }
        public void InsertPhone(string phone)
        {
            Helper.CheckTextField(PhoneEl, phone);
            Assert.IsTrue(PhoneEl().GetAttribute("value").Equals(phone));
        }
        public void InsertCity(string address)
        {
            Helper.CheckTextField(CityEl, address);
            Assert.IsTrue(CityEl().GetAttribute("value").Equals(address));
        }
        public void InsertCountry(string city)
        {
            Helper.CheckTextField(CountyEl, city);
            Assert.IsTrue(CountyEl().GetAttribute("value").Equals(city));
        }
        public void InsertStreet(string street)
        {
            Helper.CheckTextField(StreetEl, street);
            Assert.IsTrue(StreetEl().GetAttribute("value").Equals(street));
        }
        public void DateOfBirth(DateTime DateOfBirth)
        {
            string month = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.GetMonthName(int.Parse(DateOfBirth.Month.ToString()));
            Helper.ComboBox(ComboDateYearEl, DateOfBirth.Year.ToString());
            Helper.ComboBox(ComboDateMonthEl, month);
            Helper.ComboBox(ComboDateDayEl, DateOfBirth.Day.ToString());
            Assert.IsTrue(ComboDateYearEl().GetAttribute("value").Equals(DateOfBirth.Year.ToString()));
            Assert.IsTrue(ComboDateMonthEl().GetAttribute("value").Equals(DateOfBirth.Month.ToString()));
            Assert.IsTrue(ComboDateDayEl().GetAttribute("value").Equals(DateOfBirth.Day.ToString()));
        }
        public void ClickFullLicenceType()
        {
            Helper.BtnClick(FullLicenceTypeEl);
        }
        public void ClickProLicenceType()
        {
            Helper.BtnClick(ProLicenceTypeEl);
        }
        
        public void SelectLicencePeriod(int period)
        {
            Helper.ComboBox(ComboLicencePeriodEl, period.ToString());
            Assert.IsTrue(ComboLicencePeriodEl().GetAttribute("value").Equals(period.ToString()));
        }
        public void SelectOccupation(OccupationCombo occupation)
        {
            Helper.ComboBox(ComboOccupationEl, occupation.ToString());
            Assert.IsTrue(ComboOccupationEl().GetAttribute("value").Equals(((int)occupation).ToString()));
        }
        public void InsertPostCode(string postCode)
        {
            Helper.CheckTextField(PostCodeEl, postCode);
            Assert.IsTrue(PostCodeEl().GetAttribute("value").Equals(postCode));
        }
        public void InsertEmail(string email)
        {
            Helper.CheckTextField(EmailEl, email);
            Assert.IsTrue(EmailEl().GetAttribute("value").Equals(email));
        }
        public void InsertPassword(string password)
        {
            Helper.CheckTextField(PasswordEl, password);
            Assert.IsTrue(PasswordEl().GetAttribute("value").Equals(password));
        }
        public void InsertConfirmPassword(string conPassword)
        {
            Helper.CheckTextField(ConnfirmPassEl, conPassword);
            Assert.IsTrue(ConnfirmPassEl().GetAttribute("value").Equals(conPassword));
        }
        public LoginInsurancePage ClickCreate()
        {
            Helper.BtnClick(CreatBtn);
            return new LoginInsurancePage(Driver);
        }
        public void ClickReset()
        {
            Helper.BtnClick(ResetBtn);
        }

        public LoginInsurancePage RegisterProcess(RegisterObject register)
        {
            SelectTitle(register.Title);
            InsertFirstName(register.FirstName);
            InsertLastName(register.LastName);
            InsertPhone(register.Phone);
            DateOfBirth(register.DateOfBirth);

            if (register.FullLicence)
            {
                ClickFullLicenceType();
            }
            else
            {
                ClickProLicenceType();
            }

            SelectLicencePeriod(register.LicencePeriod);
            SelectOccupation(register.Occupation);
            InsertStreet(register.Address.Street);
            InsertCity(register.Address.City);
            InsertCountry(register.Address.County);
            InsertPostCode(register.Address.PostCode);
            InsertEmail(register.Email);
            InsertPassword(register.Password);
            InsertConfirmPassword(register.ConfirmPasword);

            return ClickCreate();
        }

    }
}
