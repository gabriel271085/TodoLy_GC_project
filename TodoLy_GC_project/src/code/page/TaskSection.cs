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
    }
}
