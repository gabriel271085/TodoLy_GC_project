using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LoginSection
    {
        public TextBox emailtextbox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
        public TextBox pwdtextbox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
        public Button loginbutton = new Button(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));

        public void Login(String user, String password) 
        {
            emailtextbox.SetText(user);
            pwdtextbox.SetText(password);
            loginbutton.Click();
        }
    }
}
