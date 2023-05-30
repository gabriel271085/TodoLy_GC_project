using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLy_GC_project.src.code.page
{
    public class TaskSection
    {
        public Button createTaskButton = new Button(By.Id("NewItemContentInput"));
        public TextBox taskNameTextBox = new TextBox(By.Id("NewItemContentInput"));
        public Button addNewTask = new Button(By.Id("NewItemAddButton"));

        public Button existingTaskButton = new Button(By.XPath("//div[@style=\"color: rgb(0, 0, 0);\"]"));
        public TextBox updateTaskTextBox = new TextBox(By.Id("ItemEditTextbox"));

        public Button setDueDateButton = new Button(By.XPath("//div[contains(@style,\"block\")]//div[text()='Set Due Date']"));
        public TextBox setDateTextBox = new TextBox(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/div/div/div[4]/div[3]/div[2]/div[2]/div[1]/input"));
        public Button saveDateButton = new Button(By.XPath("//div[2]/div[2]/div[2]/input[@type=\"button\"]"));


        public Boolean TaskNameDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//div[@class=\"ItemContentDiv\"][text()='" + nameValue + "'])[last()]"));
            return nameProject.IsControlDisplayed();
        }
    }
}
