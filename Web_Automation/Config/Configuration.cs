using Coypu;
using Coypu.Drivers.Selenium;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;

namespace Web_Automation.Config
{
    public class Configuration
    {
        //Criando instancia do tipo BrowserSession
        protected BrowserSession Browser;

        [SetUp] //Executa sempre antes de cada caso de teste
        public void Setup()
        {
            var inicializer = new SessionConfiguration //Configurando o ambiente a ser testado
            {
                AppHost = "https://automacaocombatista.herokuapp.com",
                SSL = true,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome
            };
            Browser = new BrowserSession(inicializer);
            Browser.MaximiseWindow();
            //Inicializa o Browser sempre maximizado com a configuração acima            
        }

        [TearDown] //Executa sempre após de cada caso de teste
        public void finish()
        {
            Browser.Dispose(); //Fecha o Browser
        }
    }
}