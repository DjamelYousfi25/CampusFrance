
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;

namespace CumpusFranceProject
{

    //----
    [TestFixture]
    public class Register
    {

        public IWebDriver driver;
        IJavaScriptExecutor js;
        string url="https://www.campusfrance.org/en/user/register";
        WebDriverWait w;

        [Test]
        public void FillFormHomme()

        {
            Console.WriteLine("ddddddddddddddddd");
            js = (IJavaScriptExecutor)driver;
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("tarteaucitronPersonalize2")).Click();
            driver.FindElement(By.XPath("//form/div[2]/div/div[1]/input")).SendKeys("dfdfdf");
            driver.FindElement(By.Id("edit-pass-pass1")).SendKeys("CoCo12358@");
            driver.FindElement(By.Id("edit-pass-pass2")).SendKeys("CoCo12358@");
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//form/div[3]/h2")));
            driver.FindElement(By.XPath("//form/div[3]/div[1]/fieldset/div/div/div[1]/label")).Click();
            driver.FindElement(By.Id("edit-field-nom-0-value")).SendKeys("naommme");
            driver.FindElement(By.Id("edit-field-prenom-0-value")).SendKeys("naommme");

            driver.FindElement(By.XPath("//form/div[3]/div[4]/div/div/div[1]")).Click();
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//form/div[3]/div[4]/div/div/div[2]/div/div[@data-value='190']")));
            driver.FindElement(By.XPath("//form/div[3]/div[4]/div/div/div[2]/div/div[@data-value='190']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"edit-field-nationalite-0-target-id\"]")).SendKeys("Algeria (75)");
            driver.FindElement(By.Id("edit-field-code-postal-0-value")).SendKeys("75001");
            driver.FindElement(By.Id("edit-field-ville-0-value")).SendKeys("Paris");
            driver.FindElement(By.Id("edit-field-telephone-0-value")).SendKeys("01121212");
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//*[@id=\"user-form\"]/div[4]/h2")));
            //select strudent
            driver.FindElement(By.XPath("//*[@id=\"edit-field-publics-cibles\"]/div[1]/label")).Click();
            //clique syr la liste
            driver.FindElement(By.XPath("//form/div[4]/div[2]/div[1]/div/div")).Click();
            //selectionner Agronomy
            driver.FindElement(By.XPath("//form/div[4]/div[2]/div[1]/div/div/div[2]/div/div[@data-value='319']")).Click();
            //cliquer sur le niveau d'étude
            driver.FindElement(By.XPath("//*[@id=\"edit-field-niveaux-etude-wrapper\"]/div/div")).Click();
            //selectionner le niveau 
            driver.FindElement(By.XPath("//*[@id=\"edit-field-niveaux-etude-wrapper\"]/div/div/div[2]/div/div[@data-value='69']")).Click();
            driver.FindElement(By.XPath("//form/div[4]/div[4]/div/label")).Click();

        }
        [Test]
        public void FillFormFemme()

        {

            js = (IJavaScriptExecutor)driver;
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("tarteaucitronPersonalize2")).Click();
            driver.FindElement(By.XPath("//form/div[2]/div/div[1]/input")).SendKeys("dfdfdf");
            driver.FindElement(By.Id("edit-pass-pass1")).SendKeys("CoCo12358@");
            driver.FindElement(By.Id("edit-pass-pass2")).SendKeys("CoCo12358@");
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//form/div[3]/h2")));
            driver.FindElement(By.XPath("//form/div[3]/div[1]/fieldset/div/div/div[1]/label")).Click();
            driver.FindElement(By.Id("edit-field-nom-0-value")).SendKeys("naommme");
            driver.FindElement(By.Id("edit-field-prenom-0-value")).SendKeys("naommme");
            driver.FindElement(By.XPath("//form/div[3]/div[4]/div/div/div[1]")).Click();
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//form/div[3]/div[4]/div/div/div[2]/div/div[@data-value='190']")));
            driver.FindElement(By.XPath("//form/div[3]/div[4]/div/div/div[2]/div/div[@data-value='190']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"edit-field-nationalite-0-target-id\"]")).SendKeys("Algeria (75)");
            driver.FindElement(By.Id("edit-field-code-postal-0-value")).SendKeys("75001");
            driver.FindElement(By.Id("edit-field-ville-0-value")).SendKeys("Paris");
            driver.FindElement(By.Id("edit-field-telephone-0-value")).SendKeys("01121212");
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//*[@id=\"user-form\"]/div[4]/h2")));
            //select strudent
            driver.FindElement(By.XPath("//*[@id=\"edit-field-publics-cibles\"]/div[1]/label")).Click();
            //clique syr la liste
            driver.FindElement(By.XPath("//form/div[4]/div[2]/div[1]/div/div")).Click();
            //selectionner Agronomy
            driver.FindElement(By.XPath("//form/div[4]/div[2]/div[1]/div/div/div[2]/div/div[@data-value='319']")).Click();
            //cliquer sur le niveau d'étude
            driver.FindElement(By.XPath("//*[@id=\"edit-field-niveaux-etude-wrapper\"]/div/div")).Click();
            //selectionner le niveau 
            driver.FindElement(By.XPath("//*[@id=\"edit-field-niveaux-etude-wrapper\"]/div/div/div[2]/div/div[@data-value='69']")).Click();
            driver.FindElement(By.XPath("//form/div[4]/div[4]/div/label")).Click();

        }

        [TearDown]
        public void Fin()
        {
          
            driver.Quit();


        }
        [SetUp]
        public void Debut()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("c:\\selenium\\geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);

        }

    }
}
