using Coypu;
using Web_Automation.Config;

namespace Web_Automation.Pages
{
    public class MenuPage : Configuration
    {
        private readonly BrowserSession _browser;

        public MenuPage(BrowserSession browser)
        {
            _browser = browser;
        }

        public void abrirTreinamentoWeb()
        {
            _browser.Visit("/treinamento/home");
        }

        public void formularioCreateUser()
        {
            _browser.FindXPath("//a[contains(text(),'Formulário')]").Click();
            _browser.FindCss("a[href='/users/new']").Click();
        }

        public void formularioListUser()
        {
            _browser.FindXPath("//a[contains(text(),'Formulário')]").Click();
            _browser.FindCss("a[href='/new']").Click();
        }

        public void findElementLink()
        {
            _browser.FindXPath("//a[contains(text(),'Busca de elementos')]").Click();
            _browser.FindLink("a[href='/buscaelementos/links']").Click();
        }


    }
}