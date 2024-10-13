using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/09/spectra-mercury.jpg?w=4096&format=jpeg&crop=1",
                    "https://i.natgeofe.com/k/82af8309-2ad4-48a4-bcf8-45d8a1d8fb8e/mercury-planet.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/06/Venus-jpeg.webp?w=4096&format=png&crop=1",
                    "https://c02.purpledshub.com/uploads/sites/48/2023/12/venus-atmosphere.jpg",
                    "https://images.theconversation.com/files/487252/original/file-20220929-1555-oz5asc.jpeg?ixlib=rb-4.1.0&q=45&auto=format&w=1000&fit=clip"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://hips.hearstapps.com/hmg-prod/images/gettyimages-1442849073-648c673408c0f.jpg",
                    "https://storage.googleapis.com/gweb-uniblog-publish-prod/images/earth-4k.width-1200.format-webp.webp",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://c02.purpledshub.com/uploads/sites/41/2024/04/jupiter.jpg",
                    "https://s.err.ee/photo/crop/2020/12/08/857593h15d9t47.jpg",
                    "https://images.squarespace-cdn.com/content/v1/5fa5ec79661ee904d2973ca0/1704744976541-1FRENDSZJAF0FUIZPMVY/jupiter+nasa+photo.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg",
                    "https://eos.org/wp-content/uploads/2022/03/saturn-aurora.jpg",
                    "https://c.files.bbci.co.uk/17073/production/_105232349_saturn.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://chandra.harvard.edu/photo/2021/uranus/uranus_lg.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/09/PIA01492-1.jpg?w=4096&format=jpeg",
                    "https://c02.purpledshub.com/uploads/sites/48/2019/04/UranusMAIN-142ae5a.jpg?w=1029&webp=1"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2024/03/pia01492-neptune-full-disk-16x9-1.jpg?w=4096&format=jpeg&crop=1",
                    "https://images.nationalgeographic.org/image/upload/t_edhub_resource_key_image/videos/posters/Neptune%20101",
                    "https://i0.wp.com/amazingphysicsforall.com/wp-content/uploads/2022/07/neptune-planet-space-5568916.png?fit=1280%2C1280&ssl=1"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "Oval-shaped dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea is an oval-shaped dwarf planet that is one of the fastest rotating large objects in our solar system. " +
                            "The fast spin distorts Haumea's shape, making this dwarf planet look like a football. " +
                            "Haumea is named after the Hawaiian goddess of fertility. " +
                            "Haumea is extremely cold and doesn't appear to have conditions suitable for life. " +
                            "With an equatorial diameter of about 1,080 miles (about 1,740 kilometers), " +
                            "Haumea is about 1/7 the width of Earth.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.usatoday.com/gcdn/-mm-/914fa122ab283e7c4d9b49cd1810c16426530591/c=714-0-3114-3200/local/-/media/2017/10/11/USATODAY/USATODAY/636433277086394454-2017-06-07303A-haumea-350.jpg",
                    "https://static.wikia.nocookie.net/sailormoonfanon/images/5/5d/Haumea.jpg/revision/latest?cb=20181029070238",
                    "https://cdn.sci.news/images/enlarge10/image_11303e-Haumea.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "Largest dwarf",
                HeroImage = "eris.png",
                Description = "Eris is one of largest the dwarf planets in our solar system. It's about the same size as Pluto, but it's three times farther from the Sun. " +
                            "The discovery of Eris help trigger a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets. " +
                            "With an equatorial diameter of about 1,500 miles (2,400 kilometers), Eris is about 1/5 the width of Earth. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://cdn.eso.org/images/screen/eso1142a.jpg",
                    "https://cff2.earth.com/uploads/2024/02/20135637/Eris_icy-dwarf-planet_kuiper-belt_1m.jpg",
                    "https://i.natgeofe.com/n/495a21cb-c570-43d8-b5f7-3dfbedb91932/42531.jpg"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "Dwarf planet Makemake",
                HeroImage = "makemake.png",
                Description = "Located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.  " +
                            "Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. " +
                            "It takes about 305 Earth years for this dwarf planet to make one trip around the Sun. " +
                            "Makemake holds an important place in the history of solar system studies because it was one of the objects – along with Eris – whose discovery prompted the International Astronomical Union to reconsider the definition of a planet, and to create the new group of dwarf planets. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2008/07/Makemake.jpg",
                    "https://i.pinimg.com/564x/3f/99/5c/3f995c01c8e4aaf03b7bc279b3890dad.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "An asteroid for many years",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. " +
                            "It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. " +
                            "When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to be explored by a spacecraft. " +
                            "Called an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006. " +
                            "Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/640px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://s.err.ee/photo/crop/2022/05/20/1479778hf3abt2.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
