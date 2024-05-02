﻿using Microsoft.EntityFrameworkCore;

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
                    Name = "Doctor Ivo " + '"' + "Eggman" + '"' + "Robotnik", // - "Snooping as usual, I see."
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
                }
            );
        }
    }
}
