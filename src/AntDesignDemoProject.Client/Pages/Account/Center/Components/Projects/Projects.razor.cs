using System.Collections.Generic;
using AntDesignDemoProject.Models;
using Microsoft.AspNetCore.Components;
using AntDesign;

namespace AntDesignDemoProject.Pages.Account.Center
{
    public partial class Projects
    {
        private readonly ListGridType _listGridType = new ListGridType
        {
            Gutter = 24,
            Column = 4
        };

        [Parameter]
        public IList<ListItemDataType> List { get; set; }
    }
}