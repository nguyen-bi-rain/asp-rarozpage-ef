using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorweb.models;

namespace razorweb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly MyBlogContext _myblogcontext;

    public IndexModel(ILogger<IndexModel> logger,MyBlogContext myblogcontext)
    {
        _logger = logger;
        _myblogcontext = myblogcontext;
    }

    public void OnGet()
    {
        var posts = (from a in _myblogcontext.articles 
                     orderby a.Create descending select a
        ).ToList();
        ViewData["posts"] = posts;
    }
}
