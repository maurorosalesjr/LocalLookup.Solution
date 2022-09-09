using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locals",
                columns: table => new
                {
                    LocalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Cuisine = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Blerb = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locals", x => x.LocalId);
                });

            migrationBuilder.InsertData(
                table: "Locals",
                columns: new[] { "LocalId", "Blerb", "Cuisine", "Location", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Vietnamese food, hands down the best. From their boa to the Banh Mi, Mama Dut has some of the best food in town", "Vietnamese", "1414 SE Morrison St, Portland OR, 97214", "Mama Dut", 10 },
                    { 2, "This restuarant is whack AF. Food is over salted, under seasoned and overly greasy. Their Insta pics look like someone made sick between two burger buns and decided to post it", "American Classic", "5052 SE Foster Rd, Portland Or, 97206", "Vegan Junk Food", 1 },
                    { 3, "As far as i know, the only Sri Lanken restaraunt in Portland, making them the best. Employee owned with great food. food is spicy, so not for the weak willed", "Sri Lanken", "2420 SE Belmont st, Portland Or, 97214", "Mirisata", 8 },
                    { 4, "the best vegan texmex in town. Queer owned, all welcoming. Food is out of this world delicious with TexMex Classics like the California Burrito, Chimichangas, nachoes, and the list goes on. a must stop", "Tex/Mex", "1670 NE Killinsworth st, Portland OR, 97211", "Mis Tacones", 10 },
                    { 5, "Fresh Bagels and has all of the classic Jewish Deli fair, but Vegan! I dream of the Black and White cookies and 'corned beef' sandwhiches", "Jewish Deli", "1800 NE Alberta St, Portland OR 97211", "Ben & Esther's Vegan Jewish Deil", 8 },
                    { 6, "this was dope af, amazing food. Only Open for Brunch/Lunch", "Classic American", "6526 SE Foster Rd, Portland OR 97206", "Off The Griddle", 8 },
                    { 7, "Best Donuts in PDX. Exciting flavors that change monthly, to keep things fresh. Their made in house ice cream is great too!", "Donuts", "4110 NE Sandy Blvd, Portland OR 97212", "Doe Donuts", 9 },
                    { 8, "Good Pizzas, flat crust, exciting flavors", "Pizza", "1126 SE Division St #200, Portland OR 97202", "Virtuous Pie", 6 },
                    { 9, "their 'steak and cheeze' is the best in PDX. Great online presence and thier other sandwiches are great too", "American Classic/Deli", "5026 SE Division St, Portland OR 97206", "DC Vegetarian", 9 },
                    { 10, "this is a little different, since it is mostly an all vegan grocer, but they do sell and make fresh hotdogs", "HotDog", "4138 SE 42nd Ave, Portland OR 97206", "Cutie Buys", 9 },
                    { 11, "A pretty good standard for vegan food. burger, salads, sandwiches and finger foods. all good", "Chain restaraunt", "508 SW Taylor St, Portland OR 97204", "Veggie Grill", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locals");
        }
    }
}
