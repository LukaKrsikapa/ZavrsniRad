﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZavrsniRad.Models;

#nullable disable

namespace ZavrsniRad.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20230808155326_test02")]
    partial class test02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ZavrsniRad.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Mojang is a visionary Swedish video game company celebrated for its masterpiece, Minecraft, an immensely popular open-world sandbox game that sparks boundless creativity. Embracing community engagement and relentless innovation, Mojang stands tall as a trailblazer in the gaming industry.",
                            Name = "Mojang"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Perfuse Entertainment is a visionary gaming company, crafting immersive experiences with boundless creativity. Their talented team of developers and designers brings captivating games to life, leaving players enchanted and hungry for more. With a passion for storytelling and innovation, Perfuse Entertainment shines as a rising star in the gaming world, delighting audiences worldwide with their stunning creations.",
                            Name = "Perfuse Entertainment"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bandai Namco Entertainment is a gaming powerhouse, known for crafting unforgettable experiences that capture hearts worldwide. With a legacy dating back to the arcade era, they continue to delight players with iconic franchises and cutting-edge titles, making them a beloved and influential presence in the gaming community.",
                            Name = "Bandai Namco Entertainment"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Criterion Software, a trailblazing gaming company, sets new standards in visual excellence and interactive innovation. Renowned for their cutting-edge technology and tools, they empower developers globally. With a passion for elevating gaming experiences, Criterion Software continues to create visually stunning and immersive games that captivate players worldwide.",
                            Name = "Criterion Software"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Nintendo, the iconic Japanese gaming company, is a beacon of innovation and creativity. With legendary franchises like Super Mario and Pokémon, they've enchanted players of all ages for generations. Renowned for their family-friendly approach and groundbreaking consoles, Nintendo continues to spread joy and create cherished memories worldwide.",
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Ubisoft, a gaming global giant, creates captivating and imaginative experiences. Their iconic franchises like Assassin's Creed and Far Cry have won the hearts of players worldwide. With a pioneering spirit, Ubisoft continues to shape the future of interactive entertainment, delivering unforgettable adventures and pushing creative boundaries.",
                            Name = "Ubisoft"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Obsidian Entertainment, a revered game development studio, weaves captivating role-playing experiences. With a flair for storytelling, their titles like Fallout: New Vegas and The Outer Worlds earn critical acclaim and a devoted fan base. Setting new RPG standards, Obsidian's engaging narratives and immersive worlds enchant gamers worldwide.",
                            Name = "Obsidian Entertainment"
                        });
                });

            modelBuilder.Entity("ZavrsniRad.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "The gameplay of Minecraft offers players a high degree of freedom and creativity. They can gather resources by mining blocks, such as wood, stone, and ores, which can be used to craft tools, weapons, and building materials. The crafting system in Minecraft allows players to combine different resources in a specific pattern to create various items and tools.",
                            GenreId = 1,
                            IsOnSale = false,
                            Name = "Minecraft",
                            PlatformId = 1,
                            Price = 19.99m,
                            PublisherId = 1,
                            Thumbnail = "/img/minecraftthumbnail.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "In Golf It, players navigate through a series of imaginative and challenging mini-golf courses. The game offers a variety of beautifully designed and visually captivating environments, including lush green landscapes, whimsical fantasy worlds, and even unconventional settings like space or underwater.",
                            GenreId = 5,
                            IsOnSale = false,
                            Name = "Golf It",
                            PlatformId = 1,
                            Price = 9.99m,
                            PublisherId = 2,
                            Thumbnail = "/img/GolfItThumbnail.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "Tekken offers various gameplay modes to cater to different player preferences. The Arcade mode allows players to follow a character-specific story arc, progressing through a series of battles against AI-controlled opponents. The Versus mode enables local multiplayer, pitting players against each other in thrilling head-to-head matches. Tekken also includes an expansive Practice mode, allowing players to hone their skills, learn new moves, and experiment with combos and strategies.",
                            GenreId = 2,
                            IsOnSale = true,
                            Name = "Tekken 7",
                            PlatformId = 3,
                            Price = 28.45m,
                            PublisherId = 3,
                            Thumbnail = "/img/tekkenthumbnail.jpg"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Description = "In the world of Need for Speed, players step into the shoes of street racers, navigating through vast open-world environments or tightly designed tracks in a variety of exotic, high-performance cars. The franchise offers a mix of both legal and illegal racing experiences, allowing players to compete in sanctioned events or engage in illicit street races.",
                            GenreId = 3,
                            IsOnSale = false,
                            Name = "Need For Speed: Most Wanted",
                            PlatformId = 2,
                            Price = 19.99m,
                            PublisherId = 4,
                            Thumbnail = "/img/nfsmwthumbnail.jpg"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            Description = "The core gameplay of Super Smash Bros revolves around intense battles between multiple characters on interactive stages. Players control their chosen character and attempt to knock their opponents off the stage to score points and secure victories. The game features a wide array of attacks, special moves, and defensive maneuvers that vary depending on the character being played.",
                            GenreId = 2,
                            IsOnSale = false,
                            Name = "Super Smash Bros",
                            PlatformId = 3,
                            Price = 35.99m,
                            PublisherId = 5,
                            Thumbnail = "/img/supersmashbrosthumbnail.webp"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 6,
                            Description = "The gameplay of Black Flag combines the series' signature historical exploration and stealth mechanics with the new and exhilarating element of naval combat. Players can freely traverse the Caribbean Sea on Edward's ship, the Jackdaw, engaging in intense naval battles, looting enemy vessels, and even boarding enemy ships to engage in close-quarters combat.",
                            GenreId = 4,
                            IsOnSale = true,
                            Name = "Assassin's Creed: Black Flag",
                            PlatformId = 2,
                            Price = 8.49m,
                            PublisherId = 6,
                            Thumbnail = "/img/acblackflagthumbnail.jpg"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 7,
                            Description = "Fallout: New Vegas offers a vast and immersive open-world experience. Players can freely explore the expansive desert landscape, encountering various factions, mutated creatures, and morally ambiguous characters along the way. The game presents players with multiple branching paths and a multitude of choices, allowing for a high degree of player agency and influencing the outcome of the story.",
                            GenreId = 6,
                            IsOnSale = false,
                            Name = "Fallout: New Vegas",
                            PlatformId = 1,
                            Price = 9.99m,
                            PublisherId = 7,
                            Thumbnail = "/img/falloutnvthumbnail.jpeg"
                        });
                });

            modelBuilder.Entity("ZavrsniRad.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fighter"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 6,
                            Name = "RPG"
                        });
                });

            modelBuilder.Entity("ZavrsniRad.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "XBOX"
                        },
                        new
                        {
                            Id = 3,
                            Name = "PlayStation"
                        });
                });

            modelBuilder.Entity("ZavrsniRad.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mojang Studios"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Perfuse Entertainment"
                        },
                        new
                        {
                            Id = 3,
                            Name = "BNE Entertainment"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Electronic Arts"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ubisoft"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bethesda Softworks"
                        });
                });

            modelBuilder.Entity("ZavrsniRad.Models.Game", b =>
                {
                    b.HasOne("ZavrsniRad.Models.Author", "Author")
                        .WithMany("Games")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZavrsniRad.Models.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZavrsniRad.Models.Platform", "Platform")
                        .WithMany("Games")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZavrsniRad.Models.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Platform");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("ZavrsniRad.Models.Author", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("ZavrsniRad.Models.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("ZavrsniRad.Models.Platform", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("ZavrsniRad.Models.Publisher", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
