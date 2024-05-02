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
                },
                new Character
                {
                    CharacterId = 5,
                    Name = "Shadow the Hedgehog",
                    Year = 2001,
                    Origin = "Sonic Adventure 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 6,
                    Name = "Silver the Hedgehog",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 7,
                    Name = "Doctor Ivo " + '"' + "Eggman" + '"' + "Robotnik", // - "Snoo pingas usual, I see."
                    Year = 1991,
                    Origin = "Sonic the Hedgehog (1991)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 8,
                    Name = "Charmy Bee",
                    Year = 1992,
                    Origin = "ソニック·ザ·ヘッジホッグ",
                    OgTypeId = "M"
                },
                new Character
                {
                    CharacterId = 9,
                    Name = "Vector the Crocodile",
                    Year = 1991,
                    Origin = "Sonic the Hedgehog Story Comic",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 10,
                    Name = "Espio the Chameleon",
                    Year = 1995,
                    Origin = "Knuckles Chaotix",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 11,
                    Name = "Big the Cat",
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 12,
                    Name = "Metal Sonic",
                    Year = 1993,
                    Origin = "Sonic the Hedgehog CD",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 13,
                    Name = "Froggy",
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 14,
                    Name = "Chaos",
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 15,
                    Name = "E-100 Alpha " + '"' + "Zero" + '"',
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 16,
                    Name = "E-102 Gamma",
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 17,
                    Name = "E-123 Omega",
                    Year = 2003,
                    Origin = "Sonic Heroes",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 18,
                    Name = "Professor Gerald Robotnik",
                    Year = 2001,
                    Origin = "Sonic Adventure 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 19,
                    Name = "Maria Robotnik",
                    Year = 2001,
                    Origin = "Sonic Adventure 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 20,
                    Name = "Rouge the Bat",
                    Year = 2001,
                    Origin = "Sonic Adventure 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 21,
                    Name = "The President",
                    Year = 2001,
                    Origin = "Sonic Adventure 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 22,
                    Name = "Mr. President",
                    Year = 1996,
                    Origin = "Sonic the Hedgehog: The Movie",
                    OgTypeId = "F"
                },
                new Character
                {
                    CharacterId = 23,
                    Name = "Sara",
                    Year = 1996,
                    Origin = "Sonic the Hedgehog: The Movie",
                    OgTypeId = "F"
                },
                new Character
                {
                    CharacterId = 24,
                    Name = "Metal Robotnik",
                    Year = 1996,
                    Origin = "Sonic the Hedgehog: The Movie",
                    OgTypeId = "F"
                },
                new Character
                {
                    CharacterId = 25,
                    Name = "Old Man Owl",
                    Year = 1996,
                    Origin = "Sonic the Hedgehog: The Movie",
                    OgTypeId = "F"
                },
                new Character
                {
                    CharacterId = 26,
                    Name = "Hyper Metal Sonic",
                    Year = 1996,
                    Origin = "Sonic the Hedgehog: The Movie",
                    OgTypeId = "F"
                },
                new Character
                {
                    CharacterId = 27,
                    Name = "Shard " + '"' + "Jack" + '"' + "the Metal Sonic",
                    Year = 1995,
                    Origin = "Sonic the Hedgehog #25",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 28,
                    Name = "President's Aide",
                    Year = 1996,
                    Origin = "Sonic the Hedgehog: The Movie",
                    OgTypeId = "F"
                },
                new Character
                {
                    CharacterId = 29,
                    Name = "President Michael K.",
                    Year = 2003,
                    Origin = "ソニックＸ S1E4: Chaos Emerald Chaos",
                    OgTypeId = "A"
                },
                new Character
                {
                    CharacterId = 30,
                    Name = "Sir Dr. Charles the Hedgehog",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog #0",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 31,
                    Name = "Caterkiller",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog #1/4",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 32,
                    Name = "Rotor Walrus",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog #1/4",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 33,
                    Name = "Princess Sally Alicia Acorn",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog #1/4",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 34,
                    Name = "Blaze the Cat",
                    Year = 2005,
                    Origin = "Sonic Rush",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 35,
                    Name = "Eggman Nega",
                    Year = 2005,
                    Origin = "Sonic Rush",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 36,
                    Name = "Sticks the Badger",
                    Year = 2014,
                    Origin = "Sonic Boom",
                    OgTypeId = "S"
                },
                new Character
                {
                    CharacterId = 37,
                    Name = "Princess Elise III",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 38,
                    Name = "Duke of Soleanna",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 39,
                    Name = "Duchess of Soleanna",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 40,
                    Name = "Iblis",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 41,
                    Name = "Mephiles the Dark",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 42,
                    Name = "Lord Regis",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 43,
                    Name = "Alberto Robert",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 44,
                    Name = "Alfano",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 45,
                    Name = "Albert Einstein",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 46,
                    Name = "Solaris the Sun God",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 47,
                    Name = "Aristo",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 48,
                    Name = "Aristotle",
                    Year = 2006,
                    Origin = "Sonic the Hedgehog (2006)",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 49,
                    Name = "Antoine D'Coolette",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog #1/4",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 50,
                    Name = "Bunnie D'Coolette",
                    Year = 1993,
                    Origin = "Sonic the Hedgehog #1 (miniseries)",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 51,
                    Name = "Wang the Impending",
                    Year = 2008,
                    Origin = "Sonic Unleashed",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 52,
                    Name = "Fang the Sniper",
                    Year = 1994,
                    Origin = "Sonic the Hedgehog: Triple Trouble",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 53,
                    Name = "Mighty the Armadillo",
                    Year = 1993,
                    Origin = "SegaSonic the Hedgehog",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 54,
                    Name = "Ray the Flying Squirrel",
                    Year = 1993,
                    Origin = "SegaSonic the Hedgehog",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 55,
                    Name = "Cream the Rabbit",
                    Year = 2002,
                    Origin = "Sonic Advance 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 56,
                    Name = "Cheese",
                    Year = 2002,
                    Origin = "Sonic Advance 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 57,
                    Name = "Vanilla the Rabbit",
                    Year = 2002,
                    Origin = "Sonic Advance 2",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 58,
                    Name = "Tikal",
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 59,
                    Name = "Omochao",
                    Year = 1998,
                    Origin = "Sonic Adventure",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 60,
                    Name = "Emerl",
                    Year = 2015,
                    Origin = "Sonic the Hedgehog #271",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 61,
                    Name = "Chocola",
                    Year = 2003,
                    Origin = "Sonic Heroes",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 62,
                    Name = "Neo Metal Sonic",
                    Year = 2003,
                    Origin = "Sonic Heroes",
                    OgTypeId = "G"
                },
                new Character
                {
                    CharacterId = 63,
                    Name = "Maximillian Acorn",
                    Year = 1994,
                    Origin = "Sonic the Hedgehog #17",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 64,
                    Name = "Lady Alicia Acorn",
                    Year = 1997,
                    Origin = "Sonic Super Special #2",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 65,
                    Name = "King Elias Acorn of Mobius",
                    Year = 1998,
                    Origin = "Knuckles the Echidna #19",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 66,
                    Name = "Megan " + '"' + "Meg" + '"' + " Acorn",
                    Year = 2003,
                    Origin = "Sonic the Hedgehog #121",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 67,
                    Name = "Alexis Acorn",
                    Year = 2003,
                    Origin = "Sonic the Hedgehog #121",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 68,
                    Name = "Joss",
                    Year = 2003,
                    Origin = "Sonic the Hedgehog #121",
                    OgTypeId = "C"
                },
                new Character
                {
                    CharacterId = 69,
                    Name = "Horizont-Al",
                    Year = 1992,
                    Origin = "Sonic the Hedgehog #2",
                    OgTypeId = "C"
                }
            );
        }
    }
}
