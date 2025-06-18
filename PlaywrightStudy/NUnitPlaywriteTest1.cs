using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo;

//Add For running all tests (using NUnit PageTest) in paralell mode 
//[Parallelizable(ParallelScope.Self)]
public class NUnitPlaywriteTests : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync(url: "http://www.eaapp.somee.com");
    }

    [Test]
    public async Task Test1()
    {
       
        await Page.ClickAsync(selector: "text=Login");
        
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        await Page.ClickAsync("text=Log in");
        await Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "EmployeeDetails.jpg"
        });
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();
    }
}
//should set only this test as active
//run form Terminal: HEADED=1 dotnet test