using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoLy_GC_project.src.code.page;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class CreateTask : TestBase
    {
        
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSection leftSection = new LeftSection();
        TaskSection taskSection = new TaskSection();

        [TestMethod]
        public void VerifyCRUDProject()
        {
            //login
            mainPage.loginButton.Click();
            loginSection.Login("gabriel.c@gc.com", "12345");
      
            
            //select project
            leftSection.ClickProjectName("TasksP");

            //create a task
            taskSection.createTaskButton.Click();
            taskSection.taskNameTextBox.SetText("Mojix Project");
            taskSection.addNewTask.Click();
            Thread.Sleep(3000);

            Assert.IsTrue(taskSection.TaskNameDisplayed("Mojix Project"), "Error, project was not created");




        }
    }
}

