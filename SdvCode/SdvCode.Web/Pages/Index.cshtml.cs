// <copyright file="Index.cshtml.cs" company="SDV Code">
// Copyright (c) SDV Code. All rights reserved.
// </copyright>

namespace SdvCode.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;

    using SdvCode.Data;
    using SdvCode.Models.User;
    using SdvCode.Models.WebsiteActions.Post;

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
            this.db.Users.Add(new User
            {
                Id = "603d7154-5d3c-45ba-b2f9-f108941fd55f",
                AccessFailedCount = 0,
            });
            this.db.Posts.Add(new Models.Blog.Post
            {
                Id = "6218d619-d461-40b1-83dc-ed69e3ee49db",
            });

            this.db.LikedPostActions.Add(new LikedPostAction
            {
                Id = "b2fc97a8-9ae3-49c2-b963-af2f7ba6c054",
                OwnerId = "603d7154-5d3c-45ba-b2f9-f108941fd55f",
                LikerId = "603d7154-5d3c-45ba-b2f9-f108941fd55f",
                PostId = "6218d619-d461-40b1-83dc-ed69e3ee49db",
            });
            await this.db.SaveChangesAsync();
            var s = await this.db.LikedPostActions.Where(x => x.Post.Id == "6218d619-d461-40b1-83dc-ed69e3ee49db").FirstOrDefaultAsync();
        }
    }
}