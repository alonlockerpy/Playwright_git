using Microsoft.Playwright;

namespace PlaywrightDemo;

public class PlaywriteTests
{

    [Test]
    public async Task Test1()
    {
        //playwrite driver
        using var playwright = await Playwright.CreateAsync();
        //Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
          Headless  = false
        });
        //page
        var page = await browser.NewPageAsync();
        await page.GotoAsync(url: "http://www.eaapp.somee.com");
        await page.ClickAsync(selector: "text=Login");
        
        await page.FillAsync("#UserName", "admin");
        await page.FillAsync("#Password", "password");
        await page.ClickAsync("text=Log in");
        var isExsit = await page.Locator("text='Employee Details'").IsVisibleAsync();
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "EmployeeDetails.jpg"
        });
        Assert.IsTrue(isExsit);
    }
    public
}