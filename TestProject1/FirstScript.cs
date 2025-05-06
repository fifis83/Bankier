using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// No main method cause Top-level statements ¯\_(ツ)_/¯

IWebDriver driver = new ChromeDriver();

String textToWrite = "Failed to get prices";
try
{
    // Get USD/PLN

    driver.Navigate().GoToUrl("https://www.bankier.pl/waluty/kursy-walut/forex/USDPLN");
    textToWrite = "Dollar Amerykański jest warty " + driver.FindElement(By.XPath("//div[@class='profilLast']")).Text + " PLN\n";

    //Get EUR/USD

    driver.Navigate().GoToUrl("https://www.bankier.pl/waluty/kursy-walut/forex/EURPLN");
    textToWrite += "Euro jest warte " + driver.FindElement(By.XPath("//div[@class='profilLast']")).Text + " PLN";

}
catch 
{
    Console.WriteLine("połączenie nie wyszło ups");
}

// Write prices to file 
try
{
    File.WriteAllText("Kursy.txt", textToWrite);
}
catch
{
    Console.WriteLine("Nie udało się zapisać pliku");
}

driver.Quit();