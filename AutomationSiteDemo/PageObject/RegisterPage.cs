using AutomationSiteDemo.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationSiteDemo.PageObject
{
    class RegisterPage
    {
        public RegisterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;
        private object basicBootstrapForm;

        IWebElement Register => driver.FindElement(By.CssSelector("#header > nav > div > div.navbar-collapse.collapse.navbar-right > ul > li.active > a"));
        IWebElement FirstName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement Address => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));
        IWebElement Email => driver.FindElement(By.CssSelector("#eid > input"));
        IWebElement PhoneNuber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Gender => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[5]/div/label[1]/input"));
        IWebElement Movie => driver.FindElement(By.CssSelector("#checkbox2"));
        IWebElement Language => driver.FindElement(By.XPath("#msdd"));
        IWebElement Country => driver.FindElement(By.CssSelector("#countries"));
        IWebElement Password => driver.FindElement(By.CssSelector("#firstpassword"));
        IWebElement ConfirmPassword => driver.FindElement(By.CssSelector("#secondpassword"));
        IWebElement Submit => driver.FindElement(By.CssSelector("#submitbtn"));







        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
        }

        public void ClickOnRegisterButton()
        {
            Register.Click();
        }


        public void EnterFirstName()
        {
            FirstName.SendKeys("MAT");
        }


        public void EnterLastName()
        {
            LastName.SendKeys("OLU");
        }
     
        
        public void EnterAdress()
        {
            Address.SendKeys("1 old road");
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(100);
            Email.SendKeys("demotest" + randomInt + "@gmail.com");
            //Email.SendKeys("demodemo83@tosin.com");
        }


        public void EnterPhoneNumber()
        {
            PhoneNuber.SendKeys("7943217679");
        }

        public void ClickGende()
        {
            Gender.Click();
        }
        

        public void ClickMovie()
        {
            Movie.Click();
        }


        public void SelectLanguage()
        {
            Language.Click();
        }


        public void SelectCountry()
        {
            Country.Click();
        }


        public void EnterPassword()
        {
            Password.SendKeys("Secure@1234");
        }


        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("Secure@1234");
        }

        public void ClickSubmitButton()
        {
            Submit.Click();
        }






    }
}
