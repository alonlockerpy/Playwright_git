using Microsoft.Playwright;
using PlaywrightDemo.Pages;

namespace PlaywrightDemo;

public class PlaywriteTests
{

    [Test]
    //public async Task Test1()
    //{
    //    //playwrite driver
    //    using var playwright = await Playwright.CreateAsync();
    //    //Browser
    //    await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
    //    {
    //      Headless  = false
    //    });
    //    //page
    //    var page = await browser.NewPageAsync();
    //    await page.GotoAsync(url: "http://www.eaapp.somee.com");
    //    await page.ClickAsync(selector: "text=Login");
    //    await page.FillAsync("#UserName", "admin");
    //    await page.FillAsync("#Password", "password");
    //    await page.ClickAsync("text=Log in");

    //    var isExsit = await page.Locator("text='Employee Details'").IsVisibleAsync();
    //    await page.ScreenshotAsync(new PageScreenshotOptions
    //    {
    //        Path = "EmployeeDetails.jpg"
    //    });
    //    Assert.IsTrue(isExsit);
    //}

    public async Task TestWithPOM()
    {
        //playwrite driver
        using var playwright = await Playwright.CreateAsync();
        //Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        //page
        var page = await browser.NewPageAsync();
        //LoginPage loginPage = new LoginPage(page);
        LoginPgaeUpgraded loginPage = new LoginPgaeUpgraded(page);
        await page.GotoAsync(url: "http://www.eaapp.somee.com");
        await loginPage.ClickLogin();
        await loginPage.Login(userName: "admin", password: "password");

        var isExsit = await loginPage.IsEmployeeDetailsExists();
        Assert.IsTrue(isExsit);
    }
}