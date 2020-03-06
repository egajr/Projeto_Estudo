using Coypu;

namespace Web_Automation.Pages
{
    public class CreateUSerPage
    {
        private readonly BrowserSession _browser;
        public CreateUSerPage(BrowserSession browser)
        {
            _browser = browser;
        }
        public void fillName(string nome)
        {
            _browser.FillIn("user_name").With(nome);
        }
        public void fillLastName(string ultimoNome)
        {
            _browser.FillIn("user_lastname").With(ultimoNome);
        }
        public void fillEmail(string email)
        {
            _browser.FillIn("user_email").With(email);
        }
        public void fillAddress(string address)
        {
            _browser.FillIn("user_address").With(address);
        }
        public void fillUniversity(string university)
        {
            _browser.FillIn("user_university").With(university);
        }
        public void fillProfile(string profile)
        {
            _browser.FillIn("user_profile").With(profile);
        }
        public void fillGender(string gender)
        {
            _browser.FillIn("user_gender").With(gender);
        }
        public void fillAge(string age)
        {
            _browser.FillIn("user_age").With(age);
        }
        public void clickCreate()
        {
            _browser.FindCss("input[value='Criar']").Click();
        }
        public void clickBack()
        {
            _browser.ClickButton("Voltar");
        }
    }
}