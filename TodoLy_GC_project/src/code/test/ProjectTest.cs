using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {
        
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSection leftSection = new LeftSection();

        [TestMethod]
        public void VerifyCRUDProject()
        {
            //login
            mainPage.loginButton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");
      
            //crear nuevo proyecto
            leftSection.addNewProjectButton.Click();
            leftSection.projectNameTextBox.SetText("CRUDop");
            leftSection.addButton.Click();

            //assert del nuevo proyecto
            Assert.IsTrue(leftSection.ProjectNameDisplayed("CRUDop"), "Error, project was not created");


            //actualizacion
            leftSection.ClickProjectName("crudop");
            leftSection.submenuicon.click();    
            //leftsection.editbutton.click();
            //leftsection.projectnameedittextbox.settext("crudopupdate");
            //leftsection.savechangesbutton.click();

            ////assert de la modificacion
            //assert.istrue(leftsection.projectnamedisplayed("crudopupdate"), "error, project was not updated");


            ////delete

            //leftsection.clickprojectname("crudopupdate");
            //leftsection.submenuicon.click();
            //leftsection.deletebutton.click();

            ////para el popup (alerta de delete)

            //thread.sleep(1000);
            //session.session.instance().getbrowser().switchto().alert().accept();
            //thread.sleep(1000);
            ////assert de la eliminacion
            //assert.isfalse(leftsection.projectnamedisplayed("crudopupdate"), "error, project was not deleted");




        }
    }
}

