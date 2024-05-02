using Microsoft.EntityFrameworkCore;

namespace CIS_296_Final_Project.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext() { }

        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<OgType> OgTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OgType>().HasData(
                new OgType { OgTypeId = "A", Name = "Anime" },
                new OgType { OgTypeId = "C", Name = "Comic" },
                new OgType { OgTypeId = "F", Name = "Movie" }, //[F]ilm
                new OgType { OgTypeId = "G", Name = "Game" },
                new OgType { OgTypeId = "M", Name = "Manga" },
                new OgType { OgTypeId = "S", Name = "Cartoon" } //[S]how
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = 1,
                    Name = "Sonic the Hedgehog",
                    Year = 1991,
                    Origin = "Sonic the Hedgehog (1991)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 2,
                    Name = "Miles " + '"' + "Tails" + '"' + " Prower",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 3,
                    Name = "Knuckles the Echidna",
                    Year = 1993,
                    Origin = "Sonic the Hedgehog 3",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 4, 
                    Name = "Amy Rose", // "Amy Rose? I didn't know she could stand." - Max0r
                    Year = 1992,
                    Origin = "ソニック·ザ·ヘッジホッグ",
                    OgTypeId = "M"
                }
            );
        }
    }
}
