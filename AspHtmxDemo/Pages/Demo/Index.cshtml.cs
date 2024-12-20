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

    public PartialViewResult OnGetYourNumber()
    {
        OnGet();
        return Partial("_YourNumber", this);
    }
}
