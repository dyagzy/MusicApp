using MVC5.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    public class SeedDataDbInitilizer : DropCreateDatabaseAlways<MVC5MusicStoreDbContext>
    {
        protected override void Seed(MVC5MusicStoreDbContext context)
        {
            context.Artists.Add(new Artist { Name = "James Morgan" });
            context.Genres.Add(new Genre { Name = "Rock", Description = "Yoruba Rock" });
            context.Albums.Add(new Album { Genre =  new Genre {Name = "Awilo HolyGhost" }, 
                Price = 89.9m,
                Title = "Travis Green" });
            
            base.Seed(context);
        }
    }
}