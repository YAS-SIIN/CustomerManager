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
namespace Mc2.CrudTest.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UpdateCustomer")]
    public partial class UpdateCustomerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "UpdateCustomer.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UpdateCustomer", "A short summary of the feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Update customer successfully when data is valid")]
        [NUnit.Framework.CategoryAttribute("UpdateSuccesfully")]
        [NUnit.Framework.TestCaseAttribute("1", "Yasin", "Asadnezhad", "1991-02-02", "+989306030638", "yasin@ggmail.com", "6280231377560890", null)]
        public virtual void UpdateCustomerSuccessfullyWhenDataIsValid(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UpdateSuccesfully"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer successfully when data is valid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When("Update validation is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then("Update result should be succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update customer when first name is small")]
        [NUnit.Framework.TestCaseAttribute("1", "Ya", "Asadnezhad", "1991-02-02", "+989306030638", "yasin@ggmail.com", "6280231377560890", null)]
        public virtual void UpdateCustomerWhenFirstNameIsSmall(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer when first name is small", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 16
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
#line 17
  testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
  testRunner.Then("Update validation should be false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update customer when last name is small")]
        [NUnit.Framework.TestCaseAttribute("1", "Yasin", "As", "1991-02-02", "+989306030638", "yasin@ggmail.com", "6280231377560890", null)]
        public virtual void UpdateCustomerWhenLastNameIsSmall(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer when last name is small", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
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
#line 26
  testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
  testRunner.Then("Update validation should be false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update customer when email is invalid")]
        [NUnit.Framework.TestCaseAttribute("1", "Yasin", "Asadnezhad", "1991-02-02", "+989306030638", "yasin", "6280231377560890", null)]
        public virtual void UpdateCustomerWhenEmailIsInvalid(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer when email is invalid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
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
#line 35
  testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 36
  testRunner.Then("Update validation should be false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update customer with invalid phone number")]
        [NUnit.Framework.TestCaseAttribute("1", "Yasin", "Asadnezhad", "1991-02-02", "+98930", "yasin@ggmail.com", "6280231377560890", null)]
        public virtual void UpdateCustomerWithInvalidPhoneNumber(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer with invalid phone number", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
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
#line 43
  testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
  testRunner.Then("Update validation should be false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update customer with invalid bank account number")]
        [NUnit.Framework.TestCaseAttribute("1", "Yasin", "Asadnezhad", "1991-02-02", "+989306030638", "yasin@ggmail.com", "6280", null)]
        public virtual void UpdateCustomerWithInvalidBankAccountNumber(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer with invalid bank account number", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 51
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
#line 52
  testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
  testRunner.Then("Update validation should be false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update customer when email is repeated")]
        [NUnit.Framework.TestCaseAttribute("1", "Mahdi", "Asadnezhad", "1991-02-02", "+989306030638", "s@y.com", "6280231377560890", null)]
        public virtual void UpdateCustomerWhenEmailIsRepeated(string id, string firstName, string lastname, string dateOfBirth, string phoneNumber, string email, string bankAccountNumber, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Id", id);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("BankAccountNumber", bankAccountNumber);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update customer when email is repeated", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 60
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
#line 61
  testRunner.Given(string.Format("Update customer information ({0},{1},{2},{3},{4},{5},{6})", id, firstName, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 62
  testRunner.When("Update validation is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
  testRunner.Then("Update result should be failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
