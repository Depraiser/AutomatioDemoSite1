using AutomationSiteDemo.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AutomationSiteDemo.StepDefination
{
    [Binding]
    public class RegisterSteps
    {
        RegisterPage registerPage;

        public RegisterSteps()
        {
            registerPage = new RegisterPage();
        }


       



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registerPage.NavigateToWebsite();
        }
        
        [Given(@"Click on register button")]
        public void GivenClickOnRegisterButton()
        {
            registerPage.ClickOnRegisterButton();
        }
        

        [Given(@"I enter my first name")]
        public void GivenIEnterMyFirstName()
        {
            registerPage.EnterFirstName();
        }
        

        [Given(@"I enter my last name")]
        public void GivenIEnterMyLastName()
        {
            registerPage.EnterLastName();
        }
        
        [Given(@"I enter my address")]
        public void GivenIEnterMyAddress()
        {
            registerPage.EnterAdress();
        }
        
        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            registerPage.EnterEmail();
        }
        
        [Given(@"I enter my phone number")]
        public void GivenIEnterMyPhoneNumber()
        {
            registerPage.EnterPhoneNumber();
        }
        
        [Given(@"I click on gender")]
        public void GivenIClickOnGender()
        {
            registerPage.ClickGende();
        }
        
        [Given(@"I click on hobbies")]
        public void GivenIClickOnHobbies()
        {
            registerPage.ClickMovie();
        }
        
        [Given(@"I click on languages")]
        public void GivenIClickOnLanguages()
        {
            registerPage.SelectLanguage();
        }
        
        [Given(@"I select language")]
        public void GivenISelectLanguage()
        {
            registerPage.SelectLanguage();
        }
        
        [Given(@"I click on country")]
        public void GivenIClickOnCountry()
        {
           registerPage.SelectCountry();
        }
        
        [Given(@"I select country")]
        public void GivenISelectCountry()
        {
            registerPage.SelectCountry();
        }
        
        [Given(@"I click on yaer")]
        public void GivenIClickOnYaer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select year")]
        public void GivenISelectYear()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on month")]
        public void GivenIClickOnMonth()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select month")]
        public void GivenISelectMonth()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on day")]
        public void GivenIClickOnDay()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select day")]
        public void GivenISelectDay()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registerPage.EnterPassword();
        }
        
        [Given(@"I enter confirm password")]
        public void GivenIEnterConfirmPassword()
        {
            registerPage.EnterConfirmPassword();
        }
        
        [When(@"I click on submit")]
        public void WhenIClickOnSubmit()
        {
            registerPage.ClickSubmitButton();
        }
        
        [Then(@"I should be able to register succefully")]
        public void ThenIShouldBeAbleToRegisterSuccefully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
