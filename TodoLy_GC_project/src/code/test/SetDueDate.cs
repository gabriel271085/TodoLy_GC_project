using OpenQA.Selenium.Interactions;
using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TodoLy_GC_project.src.code.page;

namespace TodoLy_GC_project.src.code.test

{ 
    [TestClass]
    public class SetDueDate : TestBase
{

    MainPage mainPage = new MainPage();
    LoginSection loginSection = new LoginSection();
    LeftSection leftSection = new LeftSection();
    TaskSection taskSection = new TaskSection();

    [TestMethod]
    public void UpdateTaskTest()
    {
        //login
        mainPage.loginButton.Click();
        loginSection.Login("gabriel.c@gc.com", "12345");


        //select project
        leftSection.ClickProjectName("TasksP");

            //update an existing task

            Actions actions = new Actions(driver);
            actions.MoveToElement(elemento).Perform();

            taskSection.setDueDateButton.Click();
        taskSection.setDateTextBox.SetText("31 May, 08:00 AM");
        taskSection.saveDateButton.Click();



      

    }
}
}
