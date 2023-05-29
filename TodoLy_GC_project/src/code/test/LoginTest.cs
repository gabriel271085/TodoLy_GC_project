using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {
        
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();

        [TestMethod]
        public void VerifyLogin2()
        {
            mainPage.loginButton.Click();
            loginSection.emailtextbox.SetText("bootcamp2@mojix.com");
            loginSection.pwdtextbox.SetText("12345");
            loginSection.loginbutton.Click();

            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(), "ERROR");
        }
    }
}

