using System.Collections.Generic;
using AntDesignDemoProject.Models;
using Microsoft.AspNetCore.Components;

namespace AntDesignDemoProject.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}