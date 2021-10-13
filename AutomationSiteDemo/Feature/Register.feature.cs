﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomationSiteDemo.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register")]
    public partial class RegisterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Register.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "Register", "\tIn order to have assess to all the benefits on the website \r\n\tI will need to reg" +
                    "ister first", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Vaild registration")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void VaildRegistration()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Vaild registration", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("I navigate to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("Click on register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("I enter my first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("I enter my last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("I enter my address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("I enter my email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("I enter my phone number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("I click on gender", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("I click on hobbies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("I enter password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("I enter confirm password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.When("I click on submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
