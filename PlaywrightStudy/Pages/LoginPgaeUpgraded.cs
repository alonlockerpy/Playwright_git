using Microsoft.Playwright;

namespace PlaywrightDemo.Pages;
public class LoginPgaeUpgraded
{
    private IPage _page;
    public LoginPgaeUpgraded(IPage page) => _page = page;
    private ILocator _linkLogin => _page.Locator(selector: "text=Login");
    private ILocator _userName => _page.Locator(selector: "#UserName");
    private ILocator _password => _page.Locator(selector: "#Password");
    private ILocator _btnLogin => _page.Locator(selector: "text=Log in");
    private ILocator _linkEmployeeDetails => _page.Locator(selector: "text='Employee Details'");
    public async Task ClickLogin() => await _linkLogin.ClickAsync();
    public async Task Login(string userName, string password)
    {
        await _userName.FillAsync(userName);
        await _password.FillAsync(password);
        await _btnLogin.ClickAsync();
    }
    public async Task<bool> IsEmployeeDetailsExists() => await _linkEmployeeDetails.IsVisibleAsync();

}
