﻿
// See https://aka.ms/new-console-template for more information


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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



