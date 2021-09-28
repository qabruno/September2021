using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace September2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on "Create New" button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select Time from "Type Code" dropdown list
            IWebElement typeCodeDropdwon = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdwon.Click();

            IWebElement selectTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            selectTime.Click();

            // Indentify "Code" textbox and input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("September2021");

            // Indetify "Description" textbox and input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("September2021");

            // Identify "Price per unit" textbox and input price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            pricePerUnitTextbox.SendKeys("12");

            // Click on "Save" button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            // Assert that Time record has been created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement timeRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (timeRecord.Text == "September2021")
            {
                Console.WriteLine("Time record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            // Click on "Create New" button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select Time from "Type Code" dropdown list
            IWebElement typeCodeDropdwon = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdwon.Click();

            IWebElement selectTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            selectTime.Click();

            // Indentify "Code" textbox and input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("September2021");

            // Indetify "Description" textbox and input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("September2021");

            // Identify "Price per unit" textbox and input price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            pricePerUnitTextbox.SendKeys("12");

            // Click on "Save" button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            // Assert that Time record has been created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement timeRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (timeRecord.Text == "September2021")
            {
                Console.WriteLine("Time record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
        }

        public void DeleteTM(IWebDriver driver)
        {
            // Click on the Delete Button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();

            // Assert that Time record has been deleted.
            IWebElement goToLastPageBtn2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn2.Click();

            IWebElement timeRecord2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));

            if (timeRecord2.Text != "")
            {
                Console.WriteLine("The Test is passed successfully and delete successfully.");
            }
            else
            {
                Console.WriteLine("The Test is failed.");
            }
        }
    }
}
