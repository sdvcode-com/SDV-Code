// <copyright file="Index.cshtml.cs" company="SDV Code">
// Copyright (c) SDV Code. All rights reserved.
// </copyright>

namespace SdvCode.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;

    using SdvCode.Data;
    using SdvCode.Models.User;

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly Context db;

        public IndexModel(ILogger<IndexModel> logger, Context db)
        {
            this.logger = logger;
            this.db = db;
        }

        public async Task OnGet()
        {
        }
    }
}