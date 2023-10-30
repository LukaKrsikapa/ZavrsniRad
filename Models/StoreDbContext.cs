﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZavrsniRad.Models
{
    public class StoreDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Survival", Description = "The Survival genre of games immerses players in unforgiving environments where the primary objective is to stay alive against all odds. These games challenge players' strategic thinking, resource management, adaptability, and resilience in the face of relentless challenges. Whether set in post-apocalyptic wastelands, dense forests, desolate islands, or even outer space, Survival games require players to navigate limited resources, harsh weather conditions, dangerous wildlife, and often hostile human NPCs or other players.\r\n\r\nAt the core of the Survival genre is the constant struggle for basic necessities such as food, water, shelter, and medical supplies. Players must scavenge for resources, hunt for food, purify water, and construct makeshift shelters to protect themselves from the elements and potential threats. Crafting systems play a crucial role, allowing players to create tools, weapons, and protective gear using the materials they collect.\r\n\r\nThe day-night cycle often adds another layer of challenge, as the darkness of night can bring out more dangerous creatures or present visibility issues. In some Survival games, players might also have to manage their characters' physical and mental well-being, dealing with factors like fatigue, hunger, thirst, and even mental stability.\r\n\r\nEmergent gameplay is a hallmark of the Survival genre. Players are encouraged to experiment, adapt, and come up with creative solutions to survive. Interactions with the environment and other in-game elements can lead to unexpected consequences, fostering a dynamic and immersive experience.\r\n\r\nSome Survival games incorporate a cooperative or multiplayer aspect, allowing players to team up to tackle the challenges together, while others emphasize player-versus-player interactions, creating a tense environment where both AI threats and human opponents must be contended with.\r\n\r\nSurvival games often evoke a sense of immersion and vulnerability, creating an intense emotional connection between the player and the in-game character. The genre's combination of resource scarcity, environmental hazards, and the constant pressure to make life-or-death decisions leads to a unique and captivating gaming experience that appeals to those who seek a test of their strategic prowess and adaptability in the most trying of circumstances." },
            new Genre { Id = 2, Name = "Fighter", Description = "The Fighter genre of games thrusts players into the adrenaline-pumping world of one-on-one combat, where skill, reflexes, strategy, and mastery of mechanics are the keys to victory. In these games, players assume the role of powerful and diverse characters, each with their own unique fighting styles, abilities, and backgrounds. Whether engaged in martial arts tournaments, fantasy battles, or futuristic brawls, Fighter games deliver intense, fast-paced action that demands precision and quick decision-making.\r\n\r\nAt the heart of the Fighter genre is the art of close-quarters combat. Players engage in visceral battles, executing a wide array of punches, kicks, special moves, and combos to overpower their opponents. Timing, reflexes, and understanding the movesets of various characters are paramount, as split-second decisions can mean the difference between triumph and defeat.\r\n\r\nFighter games often feature a diverse roster of characters, each with their own distinct personalities, visual designs, and fighting techniques. These characters can range from classic martial artists to supernatural beings, robots, monsters, and more, adding depth and variety to the gameplay.\r\n\r\nMultiplayer modes are a cornerstone of the Fighter genre, with competitive play pitting players against each other in local or online matches. These matches can be casual for friendly rivalry or highly competitive for those seeking to climb leaderboards and prove their prowess on a global scale.\r\n\r\nStory modes and single-player campaigns frequently provide context and depth to the characters and their motivations. These modes can offer immersive narratives, character development, and opportunities to face off against a variety of opponents, often culminating in challenging boss battles.\r\n\r\nCharacter customization and progression systems are also common in modern Fighter games, allowing players to personalize their fighters with different costumes, accessories, and even unlock new moves or abilities as they progress. This adds a layer of personalization and strategic depth beyond the core combat mechanics.\r\n\r\nThe Fighter genre's combination of fast-paced action, intricate move sets, and competitive gameplay makes it a favorite among players who relish intense duels and the thrill of outmaneuvering opponents through well-timed combos and strategic positioning. Whether played casually among friends or in high-stakes tournaments, Fighter games deliver an electrifying experience that rewards dedication, practice, and a deep understanding of the mechanics." },
            new Genre { Id = 3, Name = "Racing", Description = "The Racing genre of games puts players in the driver's seat, offering an exhilarating and immersive experience of speed, competition, and precision. These games simulate the thrill of high-speed races, featuring a variety of vehicles ranging from realistic cars to futuristic hovercrafts and everything in between. Racing games encompass a wide range of subgenres, each catering to different preferences and styles of racing enthusiasts.\r\n\r\nAt the core of the Racing genre is the sensation of speed and control. Players navigate through intricate tracks, winding roads, and sometimes open-world environments while striving to maintain optimal racing lines, handle challenging curves, and execute skillful overtakes. The emphasis on timing, reflexes, and understanding the physics of the vehicles creates a dynamic and adrenaline-fueled experience.\r\n\r\nRacing games often offer different modes to cater to various player preferences. Simulation-style racing games provide a realistic driving experience, taking into account factors such as tire grip, vehicle weight, and aerodynamics. On the other hand, arcade-style racing games prioritize fun and accessibility, allowing players to perform gravity-defying stunts and utilize power-ups for a more playful experience.\r\n\r\nThe variety of vehicles in Racing games spans from everyday cars to high-performance supercars, off-road trucks, motorcycles, and even unconventional vehicles like karts or jet skis. Each vehicle type presents unique challenges and gameplay mechanics, contributing to the diversity of the genre.\r\n\r\nMultiplayer modes are a key component of Racing games, enabling players to compete against friends or online opponents. This can range from straightforward head-to-head races to more elaborate modes involving team-based competitions, time trials, and endurance races.\r\n\r\nVisual and audio fidelity play a significant role in the Racing genre's appeal. Modern racing games feature stunning graphics, realistic vehicle models, dynamic weather systems, and meticulously crafted tracks that add to the immersion. Engine roars, tire screeches, and the rush of wind contribute to the sensory experience, making players feel like they're truly behind the wheel.\r\n\r\nRacing games often incorporate progression systems, allowing players to unlock new vehicles, tracks, and customization options as they progress. This sense of progression keeps players engaged and motivated to continue improving their skills.\r\n\r\nWhether players are seeking the thrill of competitive multiplayer races, the satisfaction of mastering complex tracks, or the joy of performing outrageous stunts, the Racing genre offers a dynamic and heart-pounding gaming experience that captures the excitement of speed, competition, and the pursuit of victory." },
            new Genre { Id = 4, Name = "Adventure", Description = "The Adventure genre of games invites players into immersive worlds where exploration, storytelling, and problem-solving are the focal points of the experience. These games emphasize narrative-driven gameplay, character development, and the gradual unraveling of mysteries within richly crafted environments. Spanning a wide range of settings from historical periods to fantastical realms, the Adventure genre offers players a chance to embark on captivating journeys filled with discovery and emotional engagement.\r\n\r\nCentral to the Adventure genre is the narrative aspect, often featuring complex storylines that can range from epic quests to intimate character-driven dramas. Players assume the role of protagonists who navigate through a series of challenges, interacting with various characters, objects, and environments to progress the story. Choices made by players can influence the direction of the narrative, offering a sense of agency and personal investment in the unfolding events.\r\n\r\nExploration is a core element of Adventure games, encouraging players to traverse diverse landscapes, uncover hidden secrets, and piece together the lore of the game world. Puzzles and brain-teasers are often integrated into the gameplay, requiring players to think critically, use logic, and sometimes experiment with unconventional solutions to overcome obstacles.\r\n\r\nThe Adventure genre encompasses various subgenres, including point-and-click adventures, action-adventure games, open-world exploration, and interactive storytelling experiences. Each subgenre offers a unique blend of gameplay mechanics, ranging from intricate dialogues and item interactions to combat sequences and platforming challenges.\r\n\r\nVisual aesthetics and world-building are key components of Adventure games. Environments are meticulously designed to convey atmosphere and evoke emotions, while characters are crafted with depth and distinct personalities. Voice acting, music, and sound effects contribute to the overall immersion, enhancing the player's emotional connection to the narrative.\r\n\r\nThe Adventure genre often elicits a sense of wonder and curiosity, as players are encouraged to seek out hidden paths, solve mysteries, and uncover the underlying truths of the game's world. Whether unraveling a grand epic or experiencing an intimate personal journey, Adventure games offer an escape into captivating narratives and the joy of exploration.\r\n\r\nWhether players are seeking thought-provoking puzzles, compelling characters, or the thrill of uncovering enigmatic stories, the Adventure genre provides an enriching and intellectually stimulating gaming experience that immerses players in imaginative worlds and invites them to become active participants in the unfolding tales." },
            new Genre { Id = 5, Name = "Sport", Description = "The Sport genre of games captures the excitement, competition, and skill of real-world athletic activities, allowing players to virtually participate in a wide range of sports without leaving their screens. These games offer a dynamic blend of realistic gameplay mechanics, strategic thinking, and immersive experiences that replicate the intensity and camaraderie of physical sports. From team-based competitions to individual challenges, the Sport genre delivers an array of options for sports enthusiasts and gamers alike.\r\n\r\nAt the heart of the Sport genre lies the faithful recreation of various sports, including soccer, basketball, football, baseball, tennis, golf, and more. Players can step into the shoes of their favorite athletes or teams, engaging in matches that simulate the rules, strategies, and nuances of the real sports.\r\n\r\nRealism is a crucial aspect of Sport games, with developers striving to replicate the physics, movements, and tactics of each sport as accurately as possible. This attention to detail allows players to experience the same strategies, plays, and strategies used by professional athletes.\r\n\r\nMultiplayer modes are a hallmark of the Sport genre, offering the chance for players to compete against friends or online opponents. Whether in local split-screen matches or global online competitions, multiplayer modes promote teamwork, strategy, and head-to-head rivalries that mirror the excitement of real sports events.\r\n\r\nIn addition to traditional sports simulations, the Sport genre often incorporates arcade-style games that infuse sports elements with over-the-top action and unique power-ups. These games emphasize fun and accessibility, providing a more lighthearted and exaggerated take on sports experiences.\r\n\r\nCareer modes are a common feature in Sport games, allowing players to create custom athletes or teams and guide them through various challenges, tournaments, and seasons. Progression systems, skill development, and the ability to unlock new gear or abilities add depth to the gameplay and keep players engaged.\r\n\r\nVisual and audio fidelity play a significant role in the Sport genre, with modern games featuring realistic stadiums, crowd reactions, and detailed character models. Commentary, ambient sounds, and crowd chants enhance the immersion, making players feel like they're in the midst of a real sports event.\r\n\r\nWhether players are drawn to the tactical aspects of team sports, the precision required in individual sports, or the joy of friendly competition, the Sport genre offers a diverse array of experiences that celebrate athleticism, strategy, and the thrill of victory. It allows both sports enthusiasts and gamers to engage in the excitement of sports in an interactive and captivating way." },
            new Genre { Id = 6, Name = "RPG", Description = "The RPG (Role-Playing Game) genre of games transports players into richly detailed worlds where they assume the roles of characters on epic journeys of self-discovery, adventure, and heroism. Character development, immersive storytelling, and strategic decision-making are the cornerstones of RPGs, offering players a chance to shape their destinies within fantastical or even historical settings. This genre encapsulates a wide range of experiences, from high-fantasy epics to science fiction sagas, each tailored to provide an immersive and engaging narrative experience.\r\n\r\nCentral to the RPG genre is the concept of role-playing, allowing players to inhabit the personas of diverse characters with distinct backgrounds, abilities, and motivations. These characters evolve over the course of the game, growing in strength, skills, and personal relationships based on the player's choices and actions.\r\n\r\nNarrative depth is a defining feature of RPGs. Players engage with intricate storylines, encountering memorable characters, exploring complex moral dilemmas, and uncovering hidden mysteries that contribute to the immersive experience. Quests, dialogue choices, and branching narratives give players a sense of agency in shaping the direction of the story.\r\n\r\nCharacter customization is a key aspect of RPGs, allowing players to craft their avatars' appearances, abilities, and playstyles to suit their preferences. Whether developing a spell-casting mage, a cunning rogue, or a valiant warrior, the genre offers a diverse range of character archetypes.\r\n\r\nGameplay mechanics vary widely within the RPG genre. Turn-based combat, real-time action combat, or a mix of both are common approaches, each contributing to the unique feel of the game. Players strategize, manage resources, and execute abilities to overcome enemies and challenges.\r\n\r\nWorld-building and environmental design play a pivotal role in RPGs, as developers create intricate settings with unique cultures, histories, and landscapes. From sprawling open worlds to labyrinthine dungeons, each location contributes to the sense of immersion and discovery.\r\n\r\nProgression and exploration are integral to RPGs, with players encouraged to explore every nook and cranny of the game world to find hidden treasures, complete quests, and uncover lore. The sense of discovery and the satisfaction of growth keep players engaged for hours on end.\r\n\r\nThe RPG genre often offers players the freedom to make choices that impact the story and the game world, leading to multiple endings and a personalized experience. These choices can range from moral decisions to alliances forged with different factions.\r\n\r\nWhether players are drawn to epic tales of heroism, intricate character interactions, or the allure of exploring immersive worlds, the RPG genre provides an opportunity to step into the shoes of captivating personas and shape their destinies. With its emphasis on storytelling, character development, and player agency, RPGs offer an expansive and emotionally resonant gaming experience that appeals to those who seek rich narratives and the thrill of becoming part of a grand adventure." }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "Mojang",
                    Description = "Mojang is a visionary Swedish video game company celebrated for its masterpiece, Minecraft, " +
                    "an immensely popular open-world sandbox game that sparks boundless creativity. " +
                    "Embracing community engagement and relentless innovation, Mojang stands tall as a trailblazer in the gaming industry."
                },
                new Author
                {
                    Id = 2,
                    Name = "Perfuse Entertainment",
                    Description = "Perfuse Entertainment is a visionary gaming company, crafting immersive experiences " +
                    "with boundless creativity. Their talented team of developers and designers brings captivating " +
                    "games to life, leaving players enchanted and hungry for more. " +
                    "With a passion for storytelling and innovation, Perfuse Entertainment shines as a rising star in " +
                    "the gaming world, delighting audiences worldwide with their stunning creations."
                },
                new Author
                { 
                    Id = 3,
                    Name = "Bandai Namco Entertainment",
                    Description = "Bandai Namco Entertainment is a gaming powerhouse, known for crafting unforgettable experiences that capture " +
                    "hearts worldwide. With a legacy dating back to the arcade era, they continue to delight players with iconic " +
                    "franchises and cutting-edge titles, making them a beloved and influential presence in the gaming community."
                },
                new Author
                {
                    Id = 4,
                    Name = "Criterion Software",
                    Description = "Criterion Software, a trailblazing gaming company, sets new standards in visual excellence and interactive innovation. " +
                    "Renowned for their cutting-edge technology and tools, they empower developers globally. With a passion for elevating gaming experiences, " +
                    "Criterion Software continues to create visually stunning and immersive games that captivate players worldwide."
                },
                new Author
                {
                    Id = 5,
                    Name = "Nintendo",
                    Description = "Nintendo, the iconic Japanese gaming company, is a beacon of innovation and creativity. " +
                    "With legendary franchises like Super Mario and Pokémon, they've enchanted players of all ages for generations. " +
                    "Renowned for their family-friendly approach and groundbreaking consoles, Nintendo continues to spread joy and create cherished memories worldwide."
                },
                new Author
                {
                    Id = 6,
                    Name = "Ubisoft",
                    Description = "Ubisoft, a gaming global giant, creates captivating and imaginative experiences. " +
                    "Their iconic franchises like Assassin's Creed and Far Cry have won the hearts of players worldwide. " +
                    "With a pioneering spirit, Ubisoft continues to shape the future of interactive entertainment, delivering unforgettable adventures and " +
                    "pushing creative boundaries."
                },
                new Author
                {
                    Id = 7,
                    Name = "Obsidian Entertainment",
                    Description = "Obsidian Entertainment, a revered game development studio, weaves captivating role-playing experiences. " +
                    "With a flair for storytelling, their titles like Fallout: New Vegas and The Outer Worlds earn critical acclaim and a devoted fan base. " +
                    "Setting new RPG standards, Obsidian's engaging narratives and immersive worlds enchant gamers worldwide."
                }
                );

            modelBuilder.Entity<Platform>().HasData(
                new Platform { Id = 1, Name = "PC"},
                new Platform { Id = 2, Name = "XBOX" },
                new Platform { Id = 3, Name = "PlayStation" }
                );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Name = "Mojang Studios"},
                new Publisher { Id = 2, Name = "Perfuse Entertainment" },
                new Publisher { Id = 3, Name = "BNE Entertainment" },
                new Publisher { Id = 4, Name = "Electronic Arts" },
                new Publisher { Id = 5, Name = "Nintendo" },
                new Publisher { Id = 6, Name = "Ubisoft" },
                new Publisher { Id = 7, Name = "Bethesda Softworks" }
                );

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 1,
                Name = "Minecraft",
                Description = "The gameplay of Minecraft offers players a high degree of freedom and creativity. They can gather resources by mining blocks, such as wood, stone, and ores, which can be used to craft tools, weapons, and building materials." +
                " The crafting system in Minecraft allows players to combine different resources in a specific pattern to create various items and tools.",
                IsOnSale = false,
                Price = 19.99M,
                Thumbnail = "/img/minecraftthumbnail.jpg",
                IsOwned = false,
                GenreId = 1,
                AuthorId = 1,
                PublisherId = 1,
                PlatformId = 1
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 2,
                Name = "Golf It",
                Description = "In Golf It, players navigate through a series of imaginative and challenging mini-golf courses." +
                " The game offers a variety of beautifully designed and visually captivating environments, including lush green landscapes, whimsical fantasy worlds, and even unconventional settings like space or underwater.",
                IsOnSale = false,
                Price = 9.99M,
                Thumbnail = "/img/GolfItThumbnail.jpeg",
                IsOwned = false,
                GenreId = 5,
                AuthorId = 2,
                PublisherId = 2,
                PlatformId = 1
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 3,
                Name = "Tekken 7",
                Description = "Tekken offers various gameplay modes to cater to different player preferences." +
                " The Arcade mode allows players to follow a character-specific story arc, progressing through a series of battles against AI-controlled opponents." +
                " The Versus mode enables local multiplayer, pitting players against each other in thrilling head-to-head matches." +
                " Tekken also includes an expansive Practice mode, allowing players to hone their skills, learn new moves, and experiment with combos and strategies.",
                IsOnSale = true,
                Price = 28.45M,
                Thumbnail = "/img/tekkenthumbnail.jpg",
                IsOwned = false,
                GenreId = 2,
                AuthorId = 3,
                PublisherId = 3,
                PlatformId = 3
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 4,
                Name = "Need For Speed: Most Wanted",
                Description = "In the world of Need for Speed, players step into the shoes of street racers," +
                " navigating through vast open-world environments or tightly designed tracks in a variety of exotic, high-performance cars." +
                " The franchise offers a mix of both legal and illegal racing experiences," +
                " allowing players to compete in sanctioned events or engage in illicit street races.",
                IsOnSale = false,
                Price = 19.99M,
                Thumbnail = "/img/nfsmwthumbnail.jpg",
                IsOwned = false,
                GenreId = 3,
                AuthorId = 4,
                PublisherId = 4,
                PlatformId = 2
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 5,
                Name = "Super Smash Bros",
                Description = "The core gameplay of Super Smash Bros revolves around intense battles between multiple characters on interactive stages." +
                " Players control their chosen character and attempt to knock their opponents off the stage to score points and secure victories." +
                " The game features a wide array of attacks, special moves, and defensive maneuvers that vary depending on the character being played.",
                IsOnSale = false,
                Price = 35.99M,
                Thumbnail = "/img/supersmashbrosthumbnail.webp",
                IsOwned = false,
                GenreId = 2,
                AuthorId = 5,
                PublisherId = 5,
                PlatformId = 3
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 6,
                Name = "Assassin's Creed: Black Flag",
                Description = "The gameplay of Black Flag combines the series' signature historical exploration and stealth mechanics with the new and exhilarating" +
                " element of naval combat. Players can freely traverse the Caribbean Sea on Edward's ship, the Jackdaw, engaging in intense naval battles," +
                " looting enemy vessels, and even boarding enemy ships to engage in close-quarters combat.",
                IsOnSale = true,
                Price = 8.49M,
                Thumbnail = "/img/acblackflagthumbnail.jpg",
                IsOwned = false,
                GenreId = 4,
                AuthorId = 6,
                PublisherId = 6,
                PlatformId = 2
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 7,
                Name = "Fallout: New Vegas",
                Description = "Fallout: New Vegas offers a vast and immersive open-world experience." +
                " Players can freely explore the expansive desert landscape, encountering various factions, mutated creatures," +
                " and morally ambiguous characters along the way. The game presents players with multiple branching paths and a multitude of choices," +
                " allowing for a high degree of player agency and influencing the outcome of the story.",
                IsOnSale = false,
                Price = 9.99M,
                Thumbnail = "/img/falloutnvthumbnail.jpeg",
                IsOwned = false,
                GenreId = 6,
                AuthorId = 7,
                PublisherId = 7,
                PlatformId = 1
            });
        }
    }
}
