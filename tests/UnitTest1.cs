using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Almostengr.Lightshowwebsite.Tests
{
    public class Tests
    {
        IWebDriver driver = null;
        string WebsiteUrl { get; set; }

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            // options.AddArgument("--headless");

            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            WebsiteUrl = "http://192.168.57.117:8080";
        }

        [Test]
        public void RobotsTxtAccessible()
        {
            // arrange
            string sitemapLine = "Sitemap: https://lightshow.thealmostengineer.com/sitemap.xml";

            // act
            driver.Navigate().GoToUrl(string.Concat(WebsiteUrl, "/robots.txt"));

            // assert
            Assert.That(driver.PageSource.Contains(sitemapLine));
        }

        [Test]
        public void SitemapAccessible()
        {
            // arrange
            string schemaUrl = "http://www.sitemaps.org/schemas/sitemap/0.9";
            string techUrlLine = $"<loc>{WebsiteUrl}/other-information/technology/</loc>";
            string previousChristmasLine = $"<loc>{WebsiteUrl}/previous-shows/2019christmas/</loc>";

            // act
            driver.Navigate().GoToUrl(string.Concat(WebsiteUrl, "/sitemap.xml"));

            // assert
            Assert.That(driver.PageSource.Contains(schemaUrl));
            Assert.That(driver.PageSource.Contains(techUrlLine));
            Assert.That(driver.PageSource.Contains(previousChristmasLine));
        }

        [Test]
        public void CheckCopyrightYear()
        {
            // arrange
            string currentYear = DateTime.Now.Year.ToString();

            // act
            driver.Navigate().GoToUrl(WebsiteUrl);
            string footerText = driver.FindElement(By.TagName("footer")).Text;

            // assert
            Assert.That(footerText.Contains("Kenny Robinson"));
            Assert.That(footerText.Contains(currentYear));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}