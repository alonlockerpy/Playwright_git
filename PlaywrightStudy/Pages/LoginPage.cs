using Microsoft.Playwright;

namespace PlaywrightDemo.Pages;

public class LoginPage
{
    private IPage _page;
    private readonly ILocator _linkLogin;
    private readonly ILocator _userName;
    private readonly ILocator _password;
    private readonly ILocator _btnLogin;
    private readonly ILocator _linkEmployeeDetails;
    
    public LoginPage(IPage page)
    {
        _page = page;
        _linkLogin = _page.Locator(selector: "text=Login");
        _userName = _page.Locator("#UserName");
        _password = _page.Locator("#Password");
        _btnLogin = _page.Locator(selector: "text=Log in");
        _linkEmployeeDetails = _page.Locator(selector: "text='Employee Details'");
        

    }
}