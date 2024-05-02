﻿// <auto-generated />
using System;
using CIS_296_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS_296_Final_Project.Migrations
{
    [DbContext(typeof(CharacterContext))]
    partial class CharacterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CIS_296_Final_Project.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("OgTypeId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Name = "Sonic the Hedgehog",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (1991)",
                            Year = 1991
                        },
                        new
                        {
                            CharacterId = 2,
                            Name = "Miles \"Tails\" Prower",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog 2",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 3,
                            Name = "Knuckles the Echidna",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog 3",
                            Year = 1993
                        },
                        new
                        {
                            CharacterId = 4,
                            Name = "Amy Rose",
                            OgTypeId = "M",
                            Origin = "ソニック·ザ·ヘッジホッグ",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 5,
                            Name = "Shadow the Hedgehog",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure 2",
                            Year = 2001
                        },
                        new
                        {
                            CharacterId = 6,
                            Name = "Silver the Hedgehog",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 7,
                            Name = "Doctor Ivo \"Eggman\"Robotnik",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (1991)",
                            Year = 1991
                        },
                        new
                        {
                            CharacterId = 8,
                            Name = "Charmy Bee",
                            OgTypeId = "M",
                            Origin = "ソニック·ザ·ヘッジホッグ",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 9,
                            Name = "Vector the Crocodile",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog Story Comic",
                            Year = 1991
                        },
                        new
                        {
                            CharacterId = 10,
                            Name = "Espio the Chameleon",
                            OgTypeId = "G",
                            Origin = "Knuckles Chaotix",
                            Year = 1995
                        },
                        new
                        {
                            CharacterId = 11,
                            Name = "Big the Cat",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 12,
                            Name = "Metal Sonic",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog CD",
                            Year = 1993
                        },
                        new
                        {
                            CharacterId = 13,
                            Name = "Froggy",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 14,
                            Name = "Chaos",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 15,
                            Name = "E-100 Alpha \"Zero\"",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 16,
                            Name = "E-102 Gamma",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 17,
                            Name = "E-123 Omega",
                            OgTypeId = "G",
                            Origin = "Sonic Heroes",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 18,
                            Name = "Professor Gerald Robotnik",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure 2",
                            Year = 2001
                        },
                        new
                        {
                            CharacterId = 19,
                            Name = "Maria Robotnik",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure 2",
                            Year = 2001
                        },
                        new
                        {
                            CharacterId = 20,
                            Name = "Rouge the Bat",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure 2",
                            Year = 2001
                        },
                        new
                        {
                            CharacterId = 21,
                            Name = "The President",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure 2",
                            Year = 2001
                        },
                        new
                        {
                            CharacterId = 22,
                            Name = "Mr. President",
                            OgTypeId = "F",
                            Origin = "Sonic the Hedgehog: The Movie",
                            Year = 1996
                        },
                        new
                        {
                            CharacterId = 23,
                            Name = "Sara",
                            OgTypeId = "F",
                            Origin = "Sonic the Hedgehog: The Movie",
                            Year = 1996
                        },
                        new
                        {
                            CharacterId = 24,
                            Name = "Metal Robotnik",
                            OgTypeId = "F",
                            Origin = "Sonic the Hedgehog: The Movie",
                            Year = 1996
                        },
                        new
                        {
                            CharacterId = 25,
                            Name = "Old Man Owl",
                            OgTypeId = "F",
                            Origin = "Sonic the Hedgehog: The Movie",
                            Year = 1996
                        },
                        new
                        {
                            CharacterId = 26,
                            Name = "Hyper Metal Sonic",
                            OgTypeId = "F",
                            Origin = "Sonic the Hedgehog: The Movie",
                            Year = 1996
                        },
                        new
                        {
                            CharacterId = 27,
                            Name = "Shard \"Jack\"the Metal Sonic",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #25",
                            Year = 1995
                        },
                        new
                        {
                            CharacterId = 28,
                            Name = "President's Aide",
                            OgTypeId = "F",
                            Origin = "Sonic the Hedgehog: The Movie",
                            Year = 1996
                        },
                        new
                        {
                            CharacterId = 29,
                            Name = "President Michael K.",
                            OgTypeId = "A",
                            Origin = "ソニックＸ S1E4: Chaos Emerald Chaos",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 30,
                            Name = "Sir Dr. Charles the Hedgehog",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #0",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 31,
                            Name = "Caterkiller",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #1/4",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 32,
                            Name = "Rotor Walrus",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #1/4",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 33,
                            Name = "Princess Sally Alicia Acorn",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #1/4",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 34,
                            Name = "Blaze the Cat",
                            OgTypeId = "G",
                            Origin = "Sonic Rush",
                            Year = 2005
                        },
                        new
                        {
                            CharacterId = 35,
                            Name = "Eggman Nega",
                            OgTypeId = "G",
                            Origin = "Sonic Rush",
                            Year = 2005
                        },
                        new
                        {
                            CharacterId = 36,
                            Name = "Sticks the Badger",
                            OgTypeId = "S",
                            Origin = "Sonic Boom",
                            Year = 2014
                        },
                        new
                        {
                            CharacterId = 37,
                            Name = "Princess Elise III",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 38,
                            Name = "Duke of Soleanna",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 39,
                            Name = "Duchess of Soleanna",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 40,
                            Name = "Iblis",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 41,
                            Name = "Mephiles the Dark",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 42,
                            Name = "Lord Regis",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 43,
                            Name = "Alberto Robert",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 44,
                            Name = "Alfano",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 45,
                            Name = "Albert Einstein",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 46,
                            Name = "Solaris the Sun God",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 47,
                            Name = "Aristo",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 48,
                            Name = "Aristotle",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog (2006)",
                            Year = 2006
                        },
                        new
                        {
                            CharacterId = 49,
                            Name = "Antoine D'Coolette",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #1/4",
                            Year = 1992
                        },
                        new
                        {
                            CharacterId = 50,
                            Name = "Bunnie D'Coolette",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #1 (miniseries)",
                            Year = 1993
                        },
                        new
                        {
                            CharacterId = 51,
                            Name = "Wang the Impending",
                            OgTypeId = "G",
                            Origin = "Sonic Unleashed",
                            Year = 2008
                        },
                        new
                        {
                            CharacterId = 52,
                            Name = "Fang the Sniper",
                            OgTypeId = "G",
                            Origin = "Sonic the Hedgehog: Triple Trouble",
                            Year = 1994
                        },
                        new
                        {
                            CharacterId = 53,
                            Name = "Mighty the Armadillo",
                            OgTypeId = "G",
                            Origin = "SegaSonic the Hedgehog",
                            Year = 1993
                        },
                        new
                        {
                            CharacterId = 54,
                            Name = "Ray the Flying Squirrel",
                            OgTypeId = "G",
                            Origin = "SegaSonic the Hedgehog",
                            Year = 1993
                        },
                        new
                        {
                            CharacterId = 55,
                            Name = "Cream the Rabbit",
                            OgTypeId = "G",
                            Origin = "Sonic Advance 2",
                            Year = 2002
                        },
                        new
                        {
                            CharacterId = 56,
                            Name = "Cheese",
                            OgTypeId = "G",
                            Origin = "Sonic Advance 2",
                            Year = 2002
                        },
                        new
                        {
                            CharacterId = 57,
                            Name = "Vanilla the Rabbit",
                            OgTypeId = "G",
                            Origin = "Sonic Advance 2",
                            Year = 2002
                        },
                        new
                        {
                            CharacterId = 58,
                            Name = "Tikal",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 59,
                            Name = "Omochao",
                            OgTypeId = "G",
                            Origin = "Sonic Adventure",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 60,
                            Name = "Emerl",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #271",
                            Year = 2015
                        },
                        new
                        {
                            CharacterId = 61,
                            Name = "Chocola",
                            OgTypeId = "G",
                            Origin = "Sonic Heroes",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 62,
                            Name = "Neo Metal Sonic",
                            OgTypeId = "G",
                            Origin = "Sonic Heroes",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 63,
                            Name = "Maximillian Acorn",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #17",
                            Year = 1994
                        },
                        new
                        {
                            CharacterId = 64,
                            Name = "Lady Alicia Acorn",
                            OgTypeId = "C",
                            Origin = "Sonic Super Special #2",
                            Year = 1997
                        },
                        new
                        {
                            CharacterId = 65,
                            Name = "King Elias Acorn of Mobius",
                            OgTypeId = "C",
                            Origin = "Knuckles the Echidna #19",
                            Year = 1998
                        },
                        new
                        {
                            CharacterId = 66,
                            Name = "Megan \"Meg\" Acorn",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #121",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 67,
                            Name = "Alexis Acorn",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #121",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 68,
                            Name = "Joss",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #121",
                            Year = 2003
                        },
                        new
                        {
                            CharacterId = 69,
                            Name = "Horizont-Al",
                            OgTypeId = "C",
                            Origin = "Sonic the Hedgehog #2",
                            Year = 1992
                        });
                });

            modelBuilder.Entity("CIS_296_Final_Project.Models.OgType", b =>
                {
                    b.Property<string>("OgTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgTypeId");

                    b.ToTable("OgTypes");

                    b.HasData(
                        new
                        {
                            OgTypeId = "A",
                            Name = "Anime"
                        },
                        new
                        {
                            OgTypeId = "C",
                            Name = "Comic"
                        },
                        new
                        {
                            OgTypeId = "F",
                            Name = "Movie"
                        },
                        new
                        {
                            OgTypeId = "G",
                            Name = "Game"
                        },
                        new
                        {
                            OgTypeId = "M",
                            Name = "Manga"
                        },
                        new
                        {
                            OgTypeId = "S",
                            Name = "Cartoon"
                        });
                });

            modelBuilder.Entity("CIS_296_Final_Project.Models.Character", b =>
                {
                    b.HasOne("CIS_296_Final_Project.Models.OgType", "OgType")
                        .WithMany()
                        .HasForeignKey("OgTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgType");
                });
#pragma warning restore 612, 618
        }
    }
}
