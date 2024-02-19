namespace Flora.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Festive Pines Bouquet",
                        Description = "Bursting with Christmas spirit, this lush rose bouquet is accented with candy canes and pine cones for a touch of festive fun.Red roses, white snapdragons, and white cushion spray chrysanthemums are wrapped in a variegated aspidistra leaf and accented with seeded eucalyptus, lemon leaf, flat cedar, white pine, candy canes, and small frosted pinecones. Delivered in a clear glass cylinder vase.",
                        ImageURL = "https://assets.eflorist.com/assets/products/PZM_/TWR14-4A.jpg?impolicy=hero&impolicy=hero",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "On The Town",
                        Description = "Free their spirits with this fabulous array of pink flowers in a chic glass cylinder vase. As breezy and fun as a classic Gene Kelly movie, it will brighten their entire week.The lush bouquet includes dark pink hydrangea, pink roses and pink carnations accented with red ti leaves.",
                        ImageURL = "https://assets.eflorist.com/assets/products/PZM_/T553-1A.jpg?impolicy=hero&impolicy=hero",
                        Price = 7.99m
                    },

                    new Product
                    {
                        Id = 3,
                        Title = "Posh Pinks",
                        Description = "Show impeccable taste when you send this stylish bouquet of hot pink roses, pale pink lilies and mixed blossoms, arranged in a modern glass cube vase. Pretty, posh and perfectly high-class!Hot pink roses and Matsumoto asters, pink LA hybrid lilies and burgundy stock arrive in a clear glass Teleflora cube vase lined with variegated ti leaves.",
                        ImageURL = "https://assets.eflorist.com/assets/products/PZM_/T05N100A.jpg?impolicy=hero&impolicy=hero   ",
                        Price = 8.99m
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
