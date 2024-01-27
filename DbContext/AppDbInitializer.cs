using ComeToEgypt.DbContext.Enums;
using ComeToEgypt.Models;
using ProjectCompany.DpContext;

namespace ComeToEgypt.DbContext
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuildrer)
        {
            using (var serviceScope = applicationBuildrer.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Tickets
                if (!context.Tickets.Any())
                {
                    context.Tickets.AddRange(new List<Ticket>()
                    {
                            new Ticket()
                            {
                                GovernorateCategory = GovernorateCategory.Giza,
                                Description = "The Egyptian pyramids are ancient masonry structures located in Egypt",
                                Price = 20,
                                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/All_Gizah_Pyramids.jpg/580px-All_Gizah_Pyramids.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(20)
                            },
                            new Ticket()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Description = "This is the Description for King",
                                Price = 20,
                                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Kairo_Museum_Statuette_Cheops_03_%28cropped%29.jpg/1280px-Kairo_Museum_Statuette_Cheops_03_%28cropped%29.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(20)
                            },
                            new Ticket()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Description = "This is the Description for King",
                                Price = 20,
                                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/4/43/Djoser_statue.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(20)
                            },
                            new Ticket()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Description = "This is the Description for King",
                                Price = 20,
                                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/All_Gizah_Pyramids.jpg/580px-All_Gizah_Pyramids.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(20)
                            },
                            new Ticket()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Description = "This is the Description for King",
                                Price = 20,
                                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/0/02/KhabaCloseUp.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(20)
                            },
                            new Ticket()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Description = "This is the Description for King",
                                Price = 20,
                                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Sekhemkhet.png/1920px-Sekhemkhet.png",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(20)
                            }
                     });
                    context.SaveChanges();
                }

                
                //Employee
                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employee>()
                    {
                        new Employee()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first Employee",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Employee()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second Employee",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Employee()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third Employee",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Employee()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the forth Employee",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Employee()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth Employee",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Locations
                if (!context.Locations.Any())
                {
                    context.Locations.AddRange(new List<Location>()
                    {
                            new Location()
                            {
                                GovernorateCategory = GovernorateCategory.Giza,
                                Address = "Pyramid",
                                Discreption = "This is the discreption for location"
                            },
                            new Location()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Address = "Egypt Musuem",
                                Discreption = "This is the discreption for location"
                            },
                            new Location()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Address = "Egypt Musuem",
                                Discreption = "This is the discreption for location"
                            },
                            new Location()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Address = "Egypt Musuem",
                                Discreption = "This is the discreption for location"
                            },
                            new Location()
                            {
                                GovernorateCategory = GovernorateCategory.Giza,
                                Address = "Egypt Musuem",
                                Discreption = "This is the discreption for location"
                            },
                            new Location()
                            {
                                GovernorateCategory = GovernorateCategory.Cairo,
                                Address = "Egypt Musuem",
                                Discreption = "This is the discreption for location"
                            }
                     });
                    context.SaveChanges();
                }

                //Information
                if (!context.Informations.Any())
                {
                    context.Informations.AddRange(new List<Information>()
                    {
                        new Information()
                        {
                            KingName = "Khufu",
                            Bio = "This is the Bio of the first King",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Kairo_Museum_Statuette_Cheops_03_%28cropped%29.jpg/1280px-Kairo_Museum_Statuette_Cheops_03_%28cropped%29.jpg",
                            Bdate = "ca. 2551–2528 B.C.",
                            Gender = "M",
                            LocationId = 3,
                            TicketId = 2
                        },
                        new Information()
                        {
                            KingName = "Sekhemkhet",
                            Bio = "This is the Bio of the second King",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Sekhemkhet.png/1920px-Sekhemkhet.png",
                            Bdate = "ca. 2611–2605 B.C.",
                            Gender = "M",
                            LocationId = 3,
                            TicketId = 6
                        },
                        new Information()
                        {
                            KingName = "Khaba",
                            Bio = "This is the Bio of the third King",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/02/KhabaCloseUp.jpg",
                            Bdate = "ca. 2605–2599 B.C.",
                            Gender = "M",
                            LocationId = 3,
                            TicketId = 5
                        },
                        new Information()
                        {
                            KingName = "Pyramids",
                            Bio = "This is the Bio of the Pyramids",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/All_Gizah_Pyramids.jpg/580px-All_Gizah_Pyramids.jpg",
                            Bdate = "ca. 7000 B.C.",
                            Gender = "None",
                            LocationId = 1,
                            TicketId = 1
                        },
                        new Information()
                        {
                            KingName = "Djoser",
                            Bio = "This is the Bio of the forth King",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/43/Djoser_statue.jpg",
                            Bdate = "ca. 2630–2611 B.C.",
                            Gender = "M",
                            LocationId = 3,
                            TicketId = 3
                        },
                        new Information()
                        {
                            KingName = "Pyramids",
                            Bio = "This is the Bio of the forth King",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/43/Djoser_statue.jpg",
                            Bdate = "ca. 2630–2611 B.C.",
                            Gender = "M",
                            LocationId = 1,
                            TicketId = 4
                        }
                    });
                    context.SaveChanges();
                }

            }


            }
        }
}
