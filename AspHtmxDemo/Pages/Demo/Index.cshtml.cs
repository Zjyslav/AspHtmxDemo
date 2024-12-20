using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspHtmxDemo.Pages.Demo;

public class IndexModel : PageModel
{
    public int YourNumber { get; set; }

    public void OnGet()
    {
        YourNumber = Random.Shared.Next(1, 100);
    }

    public async Task<PartialViewResult> OnGetYourNumberAsync()
    {
        OnGet();
        await Task.Delay(1000);
        return Partial("_YourNumber", this);
    }

    public async Task<PartialViewResult> OnPostNumberListItemAsync(int yourNumber)
    {
        YourNumber = yourNumber;
        await Task.Delay(250);
        return Partial("_NumberListItem", this);
    }
}
