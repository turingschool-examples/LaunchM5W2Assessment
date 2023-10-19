using Microsoft.EntityFrameworkCore;
using RecordCollection.Models;

namespace RecordCollection.DataAccess
{
    public class RecordCollectionContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public RecordCollectionContext(DbContextOptions<RecordCollectionContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Album>()
                .HasData(
                    new List<Album>
                    {
                        new Album
                        {
                            Id = 1,
                            Title = "Dark Side of the Moon",
                            Artist = "Pink Floyd",
                            ReleaseDate = new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 2,
                            Title = "Abbey Road",
                            Artist = "The Beatles",
                            ReleaseDate = new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 3,
                            Title = "Led Zeppelin IV",
                            Artist = "Led Zeppelin",
                            ReleaseDate = new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 4,
                            Title = "Rumours",
                            Artist = "Fleetwood Mac",
                            ReleaseDate = new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 5,
                            Title = "The Wall",
                            Artist = "Pink Floyd",
                            ReleaseDate = new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 6,
                            Title = "Revolver",
                            Artist = "The Beatles",
                            ReleaseDate = new DateTime(1966, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 7,
                            Title = "Led Zeppelin II",
                            Artist = "Led Zeppelin",
                            ReleaseDate = new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 8,
                            Title = "When We All Fall Asleep, Where Do We Go?",
                            Artist = "Billie Eilish",
                            ReleaseDate = new DateTime(2019, 3, 29, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new Album
                        {
                            Id = 9,
                            Title = "Obviously",
                            Artist = "Lake Street Dive",
                            ReleaseDate = new DateTime(2021, 3, 12, 0, 0, 0, DateTimeKind.Utc)
                        }
                    }
                );
        }
    }
}
