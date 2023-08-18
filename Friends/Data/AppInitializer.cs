using Friends.Data.Models;

namespace Friends.Data
{
    public class AppInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Friends.Any())
                {
                    context.Friends.AddRange(
                        new Friend()
                        {
                            FirstName = "Matthew",
                            LastName = "Kirlinko",
                            DateOfBirth = DateTime.Now,
                            Email = "mathkirlanko@gmail.com",
                            IsFavorited = true,
                        },
                        new Friend()
                        {
                            FirstName = "Grace",
                            LastName = "Anthony",
                            DateOfBirth = DateTime.Now,
                            Email = "garantho@gmail.com",
                            IsFavorited = false,
                        },
                        new Friend()
                        {
                            FirstName = "Peter",
                            LastName = "Cheque",
                            DateOfBirth = DateTime.Now,
                            Email = "pcheque@gmail.com",
                            IsFavorited = true,
                        },
                        new Friend()
                        {
                            FirstName = "Derrick",
                            LastName = "Fisher",
                            DateOfBirth = DateTime.Now,
                            Email = "derfisher@gmail.com",
                            IsFavorited = true,
                        },
                        new Friend()
                        {
                            FirstName = "Kate",
                            LastName = "Winsley",
                            DateOfBirth = DateTime.Now,
                            Email = "kawinsely@gmail.com",
                            IsFavorited = true,
                        },
                        new Friend()
                        {
                            FirstName = "Jordan",
                            LastName = "Sunders",
                            DateOfBirth = DateTime.Now,
                            Email = "jusunspark@gmail.com",
                            IsFavorited = true,
                        }
                    );
                }
            }
        }
    }
}
