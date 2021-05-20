﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace iCollections.BDDTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("HomePage")]
    public partial class HomePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "HomePage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "HomePage", @"	This is going to test the route functions, that take in a collection id, and return a list of rending photos That will be passed through the DOM. Yes.

	Derek Russell
	User Story ID: 177878958, Sprint 5, 2 Points.
		The Original Acceptance Criteria:
			* When the user is on the homepage, there is a nice, semi-professional landing page photo of a laptop viewing an iCollection.
			* If the user clicks on the gallery environment sample button, they will be brought to a gallery environment collection with sample photos.
			* If the user clicks on the ocean environment sample button, they will be brought to a ocean environment collection with sample photos.
	
	Then continuing with: 
	Derek Russell
	User Story ID: 178035014, Sprint 6, 4 Points.
			The Original Form of Acceptance Criteria that is being sought after in BDD testing:
			* As a user of this site, that clicks any link to another user's published iCollection, I would like to see the collections title on the same page as the rendered environment.
			* As a user of this site, that clicks any link to another user's published iCollection, I would like to see the collections description on the same page as the rendered environment.
			* As a user of this site, that clicks any link to another user's published iCollection, I would like to see the collections keywords on the same page as the rendered environment.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 20
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Visibility",
                        "UserId",
                        "Route"});
            table10.AddRow(new string[] {
                        "10",
                        "First Collection Fish",
                        "1",
                        "8",
                        "Ocean_environment"});
            table10.AddRow(new string[] {
                        "13",
                        "Second Collection Dogs",
                        "1",
                        "64",
                        "gallery_environment"});
            table10.AddRow(new string[] {
                        "16",
                        "Third Collection Shoes",
                        "1",
                        "3",
                        "Ocean_environment"});
            table10.AddRow(new string[] {
                        "45",
                        "Forth Collection Puzzels",
                        "1",
                        "3",
                        "gallery_environment"});
#line 23
 testRunner.Given("the following collections exist", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Visibility",
                        "UserId",
                        "Route"});
            table11.AddRow(new string[] {
                        "0",
                        "Bad Collection 1",
                        "1",
                        "8",
                        "Ocean_environment"});
            table11.AddRow(new string[] {
                        "11",
                        "Worse Collection 2",
                        "1",
                        "0",
                        "gallery_environment"});
            table11.AddRow(new string[] {
                        "15",
                        "HORRIBLE Collection 3",
                        "1",
                        "3",
                        "IMLOST!"});
            table11.AddRow(new string[] {
                        "$0",
                        "DICKSDICKSDIC Collection 4",
                        "9001",
                        "666",
                        "WTFisHAPPENING!!!1!"});
#line 31
 testRunner.And("the following collections do not exist", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Data",
                        "UserId",
                        "PhotoGuid"});
            table12.AddRow(new string[] {
                        "40",
                        "First Photo Fish",
                        "new byte[] {1,2,3}",
                        "8",
                        "new Guid()"});
            table12.AddRow(new string[] {
                        "41",
                        "Second Photo Fish",
                        "new byte[] {1,2,3}",
                        "8",
                        "new Guid()"});
            table12.AddRow(new string[] {
                        "45",
                        "Third Photo Shoes",
                        "new byte[] {1,2,3}",
                        "3",
                        "new Guid()"});
            table12.AddRow(new string[] {
                        "48",
                        "Fourth Photo Dogs",
                        "new byte[] {1,2,3}",
                        "64",
                        "new Guid()"});
#line 39
 testRunner.Given("the following photos exist", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Data",
                        "UserId",
                        "PhotoGuid"});
            table13.AddRow(new string[] {
                        "0",
                        "First Photo Bad",
                        "new byte[] {1,2,3}",
                        "4",
                        "new Guid()"});
            table13.AddRow(new string[] {
                        "-1",
                        "Second Photo Bad",
                        "new byte[] {1,2,3}",
                        "8",
                        "new Guid()"});
            table13.AddRow(new string[] {
                        "16",
                        "Third Photo Bad",
                        "new byte[] {1,2,3}",
                        "0",
                        "new Guid()"});
            table13.AddRow(new string[] {
                        "45",
                        "Fourth Photo Bad",
                        "9001",
                        "64",
                        "new Guid()"});
#line 47
 testRunner.And("the following photos do not exist", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CollectId",
                        "PhotoId",
                        "PhotoRank",
                        "Title",
                        "Description"});
            table14.AddRow(new string[] {
                        "80",
                        "10",
                        "40",
                        "2",
                        "Second Photo Fish",
                        "Description1"});
            table14.AddRow(new string[] {
                        "81",
                        "10",
                        "41",
                        "1",
                        "First Photo Fish",
                        "Description2"});
            table14.AddRow(new string[] {
                        "82",
                        "13",
                        "45",
                        "1",
                        "Third Photo Shoes",
                        "Description3"});
            table14.AddRow(new string[] {
                        "83",
                        "16",
                        "48",
                        "1",
                        "Fourth Photo Dogs",
                        "Description4"});
#line 55
 testRunner.Given("the following collectionPhotos exist", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CollectId",
                        "PhotoId",
                        "PhotoRank",
                        "Title",
                        "Description"});
            table15.AddRow(new string[] {
                        "80",
                        "10",
                        "40",
                        "2",
                        "Second Photo Fish",
                        "Description1"});
            table15.AddRow(new string[] {
                        "81",
                        "10",
                        "41",
                        "1",
                        "First Photo Fish",
                        "Description2"});
            table15.AddRow(new string[] {
                        "82",
                        "13",
                        "45",
                        "1",
                        "Third Photo Shoes",
                        "Description3"});
            table15.AddRow(new string[] {
                        "83",
                        "16",
                        "48",
                        "1",
                        "Fourth Photo Dogs",
                        "Description4"});
#line 63
 testRunner.And("the following collectionPhotos do not exist", ((string)(null)), table15, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking on the Preview Button for the Ocean Environment on the HomePage will red" +
            "irect to the sample ocean environment page.")]
        [NUnit.Framework.TestCaseAttribute("ocean_environment_preview", "ocean_environment", null)]
        [NUnit.Framework.TestCaseAttribute("gallery_environment_preview", "gallery_environment", null)]
        public virtual void ClickingOnThePreviewButtonForTheOceanEnvironmentOnTheHomePageWillRedirectToTheSampleOceanEnvironmentPage_(string selectedButton, string page, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("SelectedButton", selectedButton);
            argumentsOfScenario.Add("Page", page);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking on the Preview Button for the Ocean Environment on the HomePage will red" +
                    "irect to the sample ocean environment page.", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 72
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
#line 20
this.FeatureBackground();
#line hidden
#line 73
 testRunner.Given("I am on the Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 74
 testRunner.When(string.Format("I Click the \'{0}\' button", selectedButton), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then(string.Format("I am redirected to the \'{0}\' page", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking on the Preview Button for the Gallery Environment on the HomePage will r" +
            "edirect to the sample gallery environment page.")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        [NUnit.Framework.TestCaseAttribute("gallery_environment", null)]
        public virtual void ClickingOnThePreviewButtonForTheGalleryEnvironmentOnTheHomePageWillRedirectToTheSampleGalleryEnvironmentPage_(string page, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Page", page);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking on the Preview Button for the Gallery Environment on the HomePage will r" +
                    "edirect to the sample gallery environment page.", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 84
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
#line 20
this.FeatureBackground();
#line hidden
#line 85
 testRunner.Given("I am on the Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 86
 testRunner.When("I Click Preview Gallery Environment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then(string.Format("I am redirected to the \'{0}\' page", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
   testRunner.And("I can see the gallery environment preview with its title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
