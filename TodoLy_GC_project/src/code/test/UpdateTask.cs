using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoLy_GC_project.src.code.page;

namespace TodoLy_GC_project.src.code.test
{
    [TestClass]
    public class UpdateTask : TestBase
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
           
            taskSection.existingTaskButton.Click(); 
            taskSection.updateTaskTextBox.SetText("Mojix Project Update");
            taskSection.addNewTask.Click();

            //assert

            Assert.IsTrue(taskSection.TaskNameDisplayed("Mojix Project Update"), "Error, project was not created");

        }
    }
}