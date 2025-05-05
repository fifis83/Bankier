using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// No main method cause Top-level statements ¯\_(ツ)_/¯

IWebDriver driver = new ChromeDriver();
try
{
    // Get USD/PLN

    driver.Navigate().GoToUrl("https://www.bankier.pl/waluty/kursy-walut/forex/USDPLN");
    Console.WriteLine("Dollar Amerykański jest warty " + driver.FindElement(By.XPath("//div[@class='profilLast']")).Text + " PLN");

    //Get EUR/USD

    driver.Navigate().GoToUrl("https://www.bankier.pl/waluty/kursy-walut/forex/EURPLN");
    Console.WriteLine("Euro jest warte " + driver.FindElement(By.XPath("//div[@class='profilLast']")).Text + " PLN");

    // Get PLN/PLN

    //driver.Navigate().GoToUrl("https://www.bankier.pl/waluty/kursy-walut/forex/USDEUR");
    Console.WriteLine("Polskie złote jest warte 1 PLN");
}
catch 
{
    Console.WriteLine("Coś nie pykło");
}

driver.Quit();