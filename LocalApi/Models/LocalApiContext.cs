using Microsoft.EntityFrameworkCore;

namespace LocalApi.Models
{
    public class LocalApiContext : DbContext
    {
        public LocalApiContext(DbContextOptions<LocalApiContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Local>()
              .HasData(
                  new Local { LocalId = 1, Name = "Mama Dut" Location = "1414 SE Morrison St, Portland OR, 97214", Cuisine = "Vietnamese", Blerb = "Vietnamese food, hands down the best. From their boa to the Banh Mi, Mama Dut has some of the best food in town", Rating = 10 },
                  new Local { LocalId = 2, Name = "Vegan Junk Food", Location = "5052 SE Foster Rd, Portland Or, 97206", Cuisine = "American Classic", Blerb = "This restuarant is whack AF. Food is over salted, under seasoned and overly greasy. Their Insta pics look like someone made sick between two burger buns and decided to post it", Rating = 1 },
                  new Local { LocalId = 3, Name = "Mirisata", Location = "2420 SE Belmont st, Portland Or, 97214", Cuisine = "Sri Lanken", Blerb = "As far as i know, the only Sri Lanken restaraunt in Portland, making them the best. Employee owned with great food. food is spicy, so not for the weak willed", Rating = 8 },
                  new Local { LocalId = 4, Name = "Mis Tacones", Location = "1670 NE Killinsworth st, Portland OR, 97211", Cuisine = "Tex/Mex", Blerb = "the best vegan texmex in town. Queer owned, all welcoming. Food is out of this world delicious with TexMex Classics like the California Burrito, Chimichangas, nachoes, and the list goes on. a must stop", Rating = 10 },
                  new Local { LocalId = 5, Name = "Ben & Esther's Vegan Jewish Deil", Location = "1800 NE Alberta St, Portland OR 97211", Cuisine = "Jewish Deli", Blerb = "Fresh Bagels and has all of the classic Jewish Deli fair, but Vegan! I dream of the Black and White cookies and 'corned beef' sandwhiches", Rating = 8 },
                  new Local { LocalId = 6, Name = "Off The Griddle", Location = "6526 SE Foster Rd, Portland OR 97206", Cuisine = "Classic American", Blerb = "this was dope af, amazing food. Only Open for Brunch/Lunch", Rating = 8 },
                  new Local { LocalId = 7, Name = "Doe Donuts", Location = "4110 NE Sandy Blvd, Portland OR 97212", Cuisine = "Donuts", Blerb = "Best Donuts in PDX. Exciting flavors that change monthly, to keep things fresh. Their made in house ice cream is great too!", Rating = 9 },
                  new Local { LocalId = 8, Name = "Virtuous Pie", Location = "1126 SE Division St #200, Portland OR 97202", Cuisine = "Pizza", Blerb = "Good Pizzas, flat crust, exciting flavors", Rating = 6 },
                  new Local { LocalId = 9, Name = "DC Vegetarian", Location = "5026 SE Division St, Portland OR 97206", Cuisine = "American Classic/Deli", Blerb = "their 'steak and cheeze' is the best in PDX. Great online presence and thier other sandwiches are great too", Rating = 9 },
                  new Local { LocalId = 10, Name = "Cutie Buys", Location = "4138 SE 42nd Ave, Portland OR 97206", Cuisine = "HotDog", Blerb = "this is a little different, since it is mostly an all vegan grocer, but they do sell and make fresh hotdogs", Rating = 9 },
                  new Local { LocalId = 11, Name = "Veggie Grill", Location = "508 SW Taylor St, Portland OR 97204", Cuisine = "Chain restaraunt", Blerb = "A pretty good standard for vegan food. burger, salads, sandwiches and finger foods. all good", Rating = 7 }

              );
        
        }
        public DbSet<Local> Locals { get; set; }
    }
}