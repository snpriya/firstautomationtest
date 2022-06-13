using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject.Pages
{
    public class Homepage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            //check to click admin drop button
            IWebElement adminbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbutton.Click();
            Thread.Sleep(1000);
            //select time and material option from dropdown list
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
            Thread.Sleep(1000);
        }
    }
}
