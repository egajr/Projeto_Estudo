using NUnit.Framework;
using Web_Automation.Config;
using Web_Automation.Pages;

namespace Web_Automation.Tests
{
    public class CreateUserTests : Configuration
    {
        private MenuPage _menu;
        private CreateUSerPage _create;

        [SetUp]
        public void SetUp()
        {
            _menu = new MenuPage(Browser);
            _create = new CreateUSerPage(Browser);           
        }

        [Test]
        [Category("New")]
        public void createNewUser()
        {
            _menu.abrirTreinamentoWeb();
            _menu.formularioCreateUser();
            _create.fillName("AAAAAAAA");
            _create.fillLastName("AAAAAAAA");
            _create.fillEmail("aaa.bbb01@teste.com.br");
            _create.fillAddress("Rua A1, nº01, Areial, Cataguases, MG");
            _create.fillUniversity("Universo");
            _create.fillProfile("Analista Infra");
            _create.fillGender("Masculino");
            _create.fillAge("23");
            _create.clickCreate(); 
            Assert.AreEqual("Usuário Criado com sucesso", Browser.FindCss("#notice").Text);           
        }
    }
}