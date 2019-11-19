using NUnit.Framework;
using w3schoollAutomation.Pages.CSS;

namespace w3schoollTests
{
    [TestFixture]
    public class CSSTutorailTests : BaseUITest
    {

        private CSSTutorialPage page = new CSSTutorialPage();

        public override void InitTestPage()
        {
            page.Init();
        }

        [Test]
        public void verifyTitleWhenOpenCSSTutorialPage()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - verify title correct and pageHeader correct
            */
            Assert.True(page.isAt, "CSS Tutorial");

        }

        [Test]
        public void verifyUserCanClickNextFromCSS()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - verify title correct and pageHeader correct
            */
            page.ClickNext();
            //Verify title correct
            Assert.AreEqual("CSS Introduction", page.GetTitle());
            Assert.AreEqual("CSS Introduction", page.GetPageHeader());
        }

        [Test]
        public void verifyUserCanClickHomeFromCSS()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Home button
            - verify title correct and pageHeader correct
            */
            page.ClickHome();
            //Verify title correct
            Assert.AreEqual("W3Schools Online Web Tutorials", page.GetTitle());
        }


        [Test]
        public void verifyUserCanClickNextButtonSecondTime()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - click Next button
            - verify title correct and pageHeader correct
            */
            page.ClickNext();
            Assert.AreEqual("CSS Introduction", page.GetTitle());
            page.ClickNext();
            Assert.AreEqual("CSS Syntax", page.GetTitle());
            Assert.AreEqual("CSS Syntax", page.GetPageHeader());
        }

        [Test]
        public void verifyUserCanClickPreviousButton()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - click ❮ Previous  button 
            - verify title correct and pageHeader correct
            */
            page.ClickNext();
            Assert.AreEqual("CSS Introduction", page.GetTitle());
            page.ClikPrevious();
            Assert.AreEqual("CSS Tutorial", page.GetTitle());
            Assert.AreEqual("CSS Tutorial", page.GetPageHeader());
        }
    }
}
