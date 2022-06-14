using firstproject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace firstproject.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver, IWebElement neweCode)
        {
            //click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span", 5);

            Console.WriteLine("click option");
            //select material from typecode dropdown list
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typecodeDropdown.Click();
            //select material option
            Thread.Sleep(1000);
            Console.WriteLine("select option");
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            materialOption.Click();
            Console.WriteLine("click material");

            //identify the code textbox
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("test");
            //identify the description textbox
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("automation");
            //identify the price textbox
            IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag.Click();
            driver.FindElement(By.Id("Price")).SendKeys("12");
            //click save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1000);
            //click to gotolastbutton
            IWebElement goToLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastpageButton.Click();
            Thread.Sleep(2000);
            //chcek the material is created
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(1000);
               // Assert.That(newCode.Text = "test", "actual code expected code do not match ");
            Thread.Sleep(1000);

            if (newCode.Text == "test")
            {
                Console.WriteLine("New  record created successfully.");
            }
            else
            {
              Console.WriteLine("Material record is not created.");
            }
            
        }
        public void EditTM(IWebDriver driver)
        {
            //click on edit button
           // Console.WriteLine("entering if condition");
           // IWebElement newcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]"));
            //if (newcode.Text == "test")
            {
                IWebElement goToLastpageButtons1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastpageButtons1.Click();
                Thread.Sleep(2000);
                //Thread.Sleep(1000);
                // driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement edit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                edit.Click();
                Console.WriteLine("edit button clicked");
                Thread.Sleep(3000);
                //click the code element to edit
                Thread.Sleep(1000);
                driver.FindElement(By.Id("Code")).Clear();
                driver.FindElement(By.Id("Code")).SendKeys("24");
                Console.WriteLine("code enter");
                //identify the description textbox
                driver.FindElement(By.Id("Description")).Clear();
                driver.FindElement(By.Id("Description")).SendKeys("this will change");
                Console.WriteLine("description enter");
                //identify the price textbox
                IWebElement priceInputTags = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                priceInputTags.Click();
                IWebElement eprice = driver.FindElement(By.Id("Price"));
                eprice.Clear();
                Thread.Sleep(1000);
                priceInputTags.Click();
                eprice.SendKeys("15");
                Console.WriteLine("price changed");
                //click save button
                driver.FindElement(By.Id("SaveButton")).Click();
                Thread.Sleep(1000);
                //click to gotolastbutton
                IWebElement goToLastpageButtons = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastpageButtons.Click();
                Thread.Sleep(2000);
                //chcek the material is edited
                Console.WriteLine("checking edit");
                //IWebElement enewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);
                //if (enewCode.Text == "24")

                //{
                  //  Console.WriteLine("New material record edited.");
                //}
                //else
                //{
                  //  Console.WriteLine("Material record hasn't been edited.");
                //}
            }
            //else
            //{
              //Console.WriteLine("not success to edit");
            //}
        }
                public void DeleteTM(IWebDriver driver)
                    {
            //delete function
            IWebElement goToLastpageButtons = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
           goToLastpageButtons.Click();
            Thread.Sleep(1000);
            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                    delete.Click();
                    Thread.Sleep(1000);
                    Console.WriteLine("delete button clicked");
                    //click ok button
                    IAlert alert = driver.SwitchTo().Alert();
                    alert.Accept();
                    Console.WriteLine("ok button clicked");
                    Thread.Sleep(1000);
                    //check the item is deleted

                    //IWebElement delElement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last]/td[5]/a[2]"));
            Thread.Sleep(2000);
            //Console.WriteLine("if condition entering");
              //      if (delElement.Text != "24")
                //    {

            //
              //          Console.WriteLine("row deleted");
                //    }
                  //  else
                    //{
                      //  Console.WriteLine("not deleted");
                    //}

                }
            }
        }
    

