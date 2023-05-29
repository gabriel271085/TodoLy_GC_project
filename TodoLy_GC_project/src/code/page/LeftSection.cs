using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LeftSection
    {
        //creacion
        public Button addNewProjectButton = new Button(By.XPath("//td[text()='Add New Project']"));
        public TextBox projectNameTextBox = new TextBox(By.Id("NewProjNameInput"));
        public Button addButton = new Button(By.Id("NewProjNameButton"));

        //edicion
        public Button subMenuIcon = new Button(By.XPath("//div[contains(@style,\"block\")]/img"));
        public Button editButton = new Button(By.XPath("//ul[contains(@style,\"block\")]//a[text()='Edit']"));
        public TextBox projectNameEditTextBox = new TextBox(By.XPath("//td/div/input[@id=\"ItemEditTextbox\"]"));
        public Button saveChangesButton = new Button(By.XPath("//td/div/img[@id=\"ItemEditSubmit\"]\r\n"));

        //eliminacion

        public Button deleteButton = new Button(By.XPath("//ul[contains(@style,\"block\")]//a[text()='Delete']"));


        public Boolean ProjectNameDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='"+ nameValue +"'])[last()]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }

    }
}
