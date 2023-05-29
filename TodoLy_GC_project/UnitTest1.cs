using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestInitialize]
        public void OpenBrowser() {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + "/driver/chromedriver.exe");
            driver.Navigate().GoToUrl("https://todo.ly/");
        }
        [TestCleanup]
        public void CloseBrowser() { 
        driver.Quit();
        }
        [TestMethod]
        public void VerifyLogin()
        {

            //click login button
            driver.FindElement(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]")).Click();

            //fill email textbox
            driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail")).SendKeys("bootcamp2@mojix.com");

            //fill password textbox
            driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword")).SendKeys("12345");
            //click login button
            driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin")).Click();


            //assert logout button

            Assert.IsTrue(driver.FindElement(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout")).Displayed,
                "Error login test was not successfully");


            //create new project

            //driver.FindElement(By.ClassName("ProjItemContent")).Click();
            //driver.FindElement(By.ClassName("InputTextAddProj")).SendKeys("Gabriel");
            





        }
    }   
}