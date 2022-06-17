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
    public void CreateTM(IWebDriver driver)
    {
        Thread.Sleep(1500);
        //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span", 5);
        //click create new button
        driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


        Console.WriteLine("click option");
        //select material from typecode dropdown list
        IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
        typecodeDropdown.Click();
        Thread.Sleep(1000);
        //select material option
        //WaitHelpers.WaitToBeClickable(driver, "Id", "Code", 5);
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
        //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);
        Thread.Sleep(1000);
        //click to gotolastbutton
        IWebElement goToLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
        goToLastpageButton.Click();
        Thread.Sleep(1000);
        //WaitHelpers.WaitIsVisible(driver, "XPath", "//tbody/tr[last()]/td[1]", 5);
        Thread.Sleep(2000);
        //chcek the material is created
        IWebElement Createcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
        Thread.Sleep(1000);
        //Assert.That(Createcode.Text == "test", "actual code expected code do not match ");
        Thread.Sleep(1000);

    }
    public String GetnewCode(IWebDriver driver)
    {
        IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
        return newCode.Text;
    }
    public String GetnewTypeCode(IWebDriver driver)
    {
        IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
        return newTypeCode.Text;
    }
    public string GetnewDescription(IWebDriver driver)
    {
        IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
        return newDescription.Text;

    }
    //public String GetnewPrice(IWebDriver driver)
    //{
    //  IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
    //return newPrice.Text;
    //}
    public void EditTM(IWebDriver driver, String description, String code, String price)

    {
        Thread.Sleep(1000);
        IWebElement goToLastpageButtons1 = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));
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
        driver.FindElement(By.Id("Code")).SendKeys(code);
        Console.WriteLine("code enter");
        //identify the description textbox
        driver.FindElement(By.Id("Description")).Clear();
        driver.FindElement(By.Id("Description")).SendKeys(description);
        Console.WriteLine("description enter");
        //identify the price textbox
        IWebElement priceInputTags = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
        priceInputTags.Click();
        IWebElement eprice = driver.FindElement(By.Id("Price"));
        eprice.Clear();
        Thread.Sleep(1000);
        priceInputTags.Click();
        Thread.Sleep(1000);
        eprice.SendKeys(price);
        Thread.Sleep(1000);
        Console.WriteLine("price changed");
            //click save button
            IWebElement savebutton1 = driver.FindElement(By.Id("SaveButton"));
            savebutton1.Click();
        Thread.Sleep(2000);
        //click to gotolastbutton
        IWebElement goToLastpageButtons = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
        goToLastpageButtons.Click();
        Thread.Sleep(2000);
        //chcek the material is edited
        // Console.WriteLine("checking edit");
        Thread.Sleep(2000);

    }
    public String getEditcodeTM(IWebDriver driver)
    {
        IWebElement enewCode = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
        return enewCode.Text;
       // Thread.Sleep(1000);
    }
    public String geteditDescriptionTM(IWebDriver driver)
    {
        IWebElement editnewDescription = driver.FindElement(By.XPath("//tbody/tr[last()]/td[3]"));
        return editnewDescription.Text;
        //Thread.Sleep(1000);
    }
    public String getEditedPriceTM(IWebDriver driver)
    {
        IWebElement editnewPrice = driver.FindElement(By.XPath("//tbody/tr[last()]/td[4]"));
        return editnewPrice.Text;
        //Thread.Sleep(1000);
    }

    public void DeleteTM(IWebDriver driver)
    {
        //delete function
        IWebElement goToLastpageButtons = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
        goToLastpageButtons.Click();
        Thread.Sleep(2000);
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

        // driver.FindElement(By.Id("code")).SendKeys(code);

        Thread.Sleep(2000);
    }

    public void CodeDeleteAssertion(IWebDriver driver)

    {
        Thread.Sleep(2000);
        IWebElement DeletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
        Assert.That(DeletedCode.Text != "Portal", "Record has not been deleted");
    }

    public void DescriptionDeleteAssertion(IWebDriver driver)
    {
        Thread.Sleep(2000);
        IWebElement DeletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
        Assert.That(DeletedDescription.Text != "EditedRecord", "Record has not been deleted");
    }
    public void PriceDeleteAssertion(IWebDriver driver)
    {
        Thread.Sleep(2000);
        IWebElement DeletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
        Assert.That(DeletedPrice.Text != "$49.00", "Record has not been deleted");
    }

}
}
    

