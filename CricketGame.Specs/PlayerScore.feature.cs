﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CricketGame.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PlayerScoreFeature : Xunit.IClassFixture<PlayerScoreFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PlayerScore.feature"
#line hidden
        
        public PlayerScoreFeature(PlayerScoreFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlayerScore", "\tIn order to enjoy a game of cricket\r\n\tAs a player\r\n\tI want to be told my score", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Player1 score is set to zero when game starts")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerScore")]
        [Xunit.TraitAttribute("Description", "Player1 score is set to zero when game starts")]
        [Xunit.TraitAttribute("Category", "mytag")]
        public virtual void Player1ScoreIsSetToZeroWhenGameStarts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player1 score is set to zero when game starts", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("Player has started a new game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("Player scores a 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the player score should increase to 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player1 should be able to score runs multiple times")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerScore")]
        [Xunit.TraitAttribute("Description", "Player1 should be able to score runs multiple times")]
        public virtual void Player1ShouldBeAbleToScoreRunsMultipleTimes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player1 should be able to score runs multiple times", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("Player has started a new game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.Given("Player has scored 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("Player scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the player score should increase to 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player1 should be able to score runs third time")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerScore")]
        [Xunit.TraitAttribute("Description", "Player1 should be able to score runs third time")]
        public virtual void Player1ShouldBeAbleToScoreRunsThirdTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player1 should be able to score runs third time", ((string[])(null)));
#line 18
 this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("Player has started a new game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.Given("Player has scored 7 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("Player scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the player score should increase to 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player1 should be able to score runs fourth time")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerScore")]
        [Xunit.TraitAttribute("Description", "Player1 should be able to score runs fourth time")]
        public virtual void Player1ShouldBeAbleToScoreRunsFourthTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player1 should be able to score runs fourth time", ((string[])(null)));
#line 24
 this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("Player has started a new game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.Given("Player has scored 10 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.When("Player scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the player score should increase to 13", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player1 should be able to score runs fifth time")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerScore")]
        [Xunit.TraitAttribute("Description", "Player1 should be able to score runs fifth time")]
        public virtual void Player1ShouldBeAbleToScoreRunsFifthTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player1 should be able to score runs fifth time", ((string[])(null)));
#line 30
 this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("Player has started a new game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.Given("Player has scored 13 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("Player scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the player score should increase to 16", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PlayerScoreFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PlayerScoreFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion