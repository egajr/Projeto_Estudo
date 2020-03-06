using NUnit.Framework;
using Web_Automation.Config;
using Web_Automation.Pages;

namespace Web_Automation.Tests
{
    public class ListUserTests : Configuration
    {
        private MenuPage _menu;
        //private ListUSerPage _list;

        [SetUp]
        public void SetUp()
        {
            _menu = new MenuPage(Browser);
            //_list = new ListUSerPage(Browser);           
        }

        [Test]
        [Category("List")]
        public void listUser()
        {
            _menu.abrirTreinamentoWeb();
            _menu.formularioListUser();            
            Assert.That(Browser.FindCss(".highlight tbody tr:first-child").HasContent("aaa.bbb01@teste.com.br"));
        }
    }
}