using ECommerceAPI.Models;

namespace ECommerceAPI.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product { ItemCode = "5", ItemName = "PIL KODAK XTRA HEAVY 9 V", UnitPrice = 5.15m, Category1 = "EV", Category2 = "ELEKTRIK-ELEKTRONIK", Brand = "KODAK" },
                    new Product { ItemCode = "6", ItemName = "PIL KODAK AA*2 MAX ALKALIN KALEM", UnitPrice = 8.26m, Category1 = "EV", Category2 = "ELEKTRIK-ELEKTRONIK", Brand = "KODAK" },
                    new Product { ItemCode = "11", ItemName = "VAKKUMLU TASIYICI TIR", UnitPrice = 20.83m, Category1 = "OYUNCAK", Category2 = "ZEKA GELISTIRICI", Brand = "OYUNCAK" },
                    new Product { ItemCode = "17", ItemName = "OFICA SERIT DAKSIL", UnitPrice = 1.01m, Category1 = "EV", Category2 = "KITAP-DERGI-KIRTASIYE", Brand = "KIRTASIYELER" },
                    new Product { ItemCode = "23", ItemName = "MARUL KIVIRCIK", UnitPrice = 6.25m, Category1 = "YESILLIK", Category2 = "MANAV", Brand = "MAROL" },
                    new Product { ItemCode = "29", ItemName = "CARPEX TYPES KLIMA KOKU SUMMER BREEZE", UnitPrice = 7.53m, Category1 = "TEMIZLIK", Category2 = "KOKULAR", Brand = "CARPEX" },
                    new Product { ItemCode = "35", ItemName = "OYUNCAK KUTUDA RENKLI SACLI BEBEK", UnitPrice = 40.03m, Category1 = "OYUNCAK", Category2 = "ZEKA GELISTIRICI", Brand = "OYUNCAK" },
                    new Product { ItemCode = "40", ItemName = "SOGAN KISKA PK.", UnitPrice = 0.73m, Category1 = "SEBZE", Category2 = "MANAV", Brand = "SOGAN" },
                    new Product { ItemCode = "49", ItemName = "ARMUT DEVECI", UnitPrice = 9.90m, Category1 = "MEYVE", Category2 = "MANAV", Brand = "ARMUT" },
                    new Product { ItemCode = "54", ItemName = "DOMATES ARI SALKIM", UnitPrice = 6.54m, Category1 = "SEBZE", Category2 = "MANAV", Brand = "DOMATES" },
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User { Username = "N_OZSIMITCI", NameSurname = "Nazlıcan ÖZSİMİTÇİ", Email = "N_OZSIMITCI@sqlegitimbtk.com", Gender = "K", BirthDate = new DateTime(1951, 12, 29), CreatedDate = new DateTime(2018, 7, 25), PhoneNumber = "(532)5898448" },
                    new User { Username = "E_SELIM", NameSurname = "Emirhan SELİM", Email = "E_SELIM@sqlegitimbtk.com", Gender = "E", BirthDate = new DateTime(1993, 1, 21), CreatedDate = new DateTime(2018, 7, 28), PhoneNumber = "(534)8242021" },
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Addresses.Any())
            {
                var addresses = new List<Address>
                {
                    new Address { UserId = 1, AddressText = "ÇEPNİ MAH. YILDIRIM SOKAK NO:381", Country = "TÜRKİYE", City = "SİVAS", Town = "GEMEREK" },
                    new Address { UserId = 2, AddressText = "ORUÇREİS MAH. AKASYA SOKAK NO:453", Country = "TÜRKİYE", City = "NEVŞEHİR", Town = "GÜLŞEHİR" },
                };

                context.Addresses.AddRange(addresses);
                context.SaveChanges();
            }
        }
    }
}