
// See https://aka.ms/new-console-template for more information


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
//open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
//identify login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();
Thread.Sleep(1000);
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
//check the username and password is correct
if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("login sucessfully");
}
else
{
    Console.WriteLine("login failed");
}
//check to click admin drop button
IWebElement adminbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminbutton.Click();
Thread.Sleep(1000);
//select time and material option from dropdown list
IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();
Thread.Sleep(1000);
//click create new button
driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

//select material from typecode dropdown list
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
typecodeDropdown.Click();
//select material option
Thread.Sleep(1000);
IWebElement  materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
materialOption.Click();

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
Thread.Sleep(1500);
//click to gotolastbutton
IWebElement goToLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goToLastpageButton.Click();
Thread.Sleep(2000);
//chcek the material is created
IWebElement neweCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (neweCode.Text == "test")
{
    Console.WriteLine("New  record created successfully.");
}
else
{
    Console.WriteLine("Material record is not created.");
}
Thread.Sleep(1000);
//click on edit button
Console.WriteLine("entering if condition");
//IWebElement newEcode=driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]"));
if (neweCode.Text == "test")
    {
    Thread.Sleep(1000);
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
    Thread.Sleep(2000);
    priceInputTags.Click();      
    eprice.SendKeys("15");
    Console.WriteLine("price changed");
    //click save button
    driver.FindElement(By.Id("SaveButton")).Click();
    Thread.Sleep(1500);
    //click to gotolastbutton
     IWebElement goToLastpageButtons = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
    goToLastpageButtons.Click();
    Thread.Sleep(2000);
    //chcek the material is edited
    Console.WriteLine("checking edit");
    IWebElement enewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

    if (enewCode.Text == "24")

    {
      Console.WriteLine("New material record edited.");
    }
    else
    {
      Console.WriteLine("Material record hasn't been edited.");
    }
}
else
{
    Console.WriteLine("not success to edit");
}
//delete function
IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
delete.Click();
Thread.Sleep(2000);
Console.WriteLine("delete button clicked");
//click ok button
IAlert alert = driver.SwitchTo().Alert();
alert.Accept();
Console.WriteLine("ok button clicked");
Thread.Sleep(1500);
//check the item is deleted

IWebElement delElement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
Console.WriteLine("if condition entering");
if (delElement.Text !="24")
{
  
    
    Console.WriteLine("row deleted");
}
else
{
    Console.WriteLine("not deleted");
}
//click on hi hari
IWebElement logouthelloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
logouthelloHari.Click();
//select logout button
IWebElement logout = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/ul/li[2]/a"));
logout.Click();
//goto login page
driver.Manage().Window.Maximize();

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Console.WriteLine("logout successful");

