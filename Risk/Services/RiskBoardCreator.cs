﻿using Risk.Models;
using Risk.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Risk.Services
{
    public static class RiskConstants
    {
        public static class Continents
        {
            public const string NorthAmerica = "North America";
            public const string SouthAmerica = "South America";
            public const string Europe = "Europe";
            public const string Africa = "Africa";
            public const string Asia = "Asia";
            public const string Australia = "Australia";
        }

        public static class Countries
        {
            public const string Alaska = "Alaska";
            public const string NorthwestTerritory = "Northwest Territory";
            public const string Greenland = "Greenland";
            public const string Alberta = "Alberta";
            public const string Ontario = "Ontario";
            public const string Quebec = "Quebec";
            public const string WesternUnitedStates = "Western United States";
            public const string EasternUnitedStates = "Eastern United States ";
            public const string CentralAmerica = "Central America";

            public const string Venezuela = "Venezuela";
            public const string Peru = "Peru";
            public const string Brazil = "Brazil";
            public const string Argentina = "Argentina";

            public const string Iceland = "Iceland";
            public const string Scandinavia = "Scandinavia";
            public const string GreatBritain = "Great Britain";
            public const string NorthernEurope = "Northern Europe";
            public const string Ukraine = "Ukraine";
            public const string WesternEurope = "Western Europe";
            public const string SouthernEurope = "Southern Europe";

            public const string Egypt = "Egypt";
            public const string NorthAfrica = "North Africa";
            public const string EastAfrica = "East Africa";
            public const string Congo = "Congo";
            public const string SouthAfrica = "South Africa";
            public const string Madagascar = "Madagascar";

            public const string MiddleEast = "Middle East";
            public const string Afghanistan = "Afghanistan";
            public const string Ural = "Ural";
            public const string Siberia = "Siberia";
            public const string Yakutsk = "Yakutsk";
            public const string Kamchatka = "Kamchatka";
            public const string Irkutsk = "Irkutsk";
            public const string Mongolia = "Mongolia";
            public const string Japan = "Japan";
            public const string China = "China";
            public const string India = "India";
            public const string Siam = "Siam";

            public const string Indonesia = "Indonesia";
            public const string NewGuinea = "New Guinea";
            public const string WesternAustralia = "Western Australia";
            public const string EasternAustralia = "EasternAustralia";
        }
    }

    public class RiskBoardCreator : IBoardCreator
    {
        public Board CreateBoard()
        {
            var board = new Board
            {
                Countries = new SortedList<int, Country>
                {
                    {1, new Country
                    {
                        Name = RiskConstants.Countries.Alaska,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 115,
                        Y = 47
                    }},
                    {2, new Country
                    {
                        Name = RiskConstants.Countries.NorthwestTerritory,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 155,
                        Y = 45
                    }},
                    {3, new Country
                    {
                        Name = RiskConstants.Countries.Greenland,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 248,
                        Y = 38
                    }},
                    {4, new Country
                    {
                        Name = RiskConstants.Countries.Alberta,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 145,
                        Y = 70
                    }},
                    {5, new Country
                    {
                        Name = RiskConstants.Countries.Ontario,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 185,
                        Y = 75
                    }},
                    {6, new Country
                    {
                        Name = RiskConstants.Countries.Quebec,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 215,
                        Y = 72
                    }},
                    {7, new Country
                    {
                        Name = RiskConstants.Countries.WesternUnitedStates,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 143,
                        Y = 100
                    }},
                    {8, new Country
                    {
                        Name = RiskConstants.Countries.EasternUnitedStates,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 180,
                        Y = 112
                    }},
                    {9, new Country
                    {
                        Name = RiskConstants.Countries.CentralAmerica,
                        Continent = RiskConstants.Continents.NorthAmerica,
                        X = 137,
                        Y = 140
                    }},

                    {10, new Country
                    {
                        Name = RiskConstants.Countries.Venezuela,
                        Continent = RiskConstants.Continents.SouthAmerica,
                        X = 172,
                        Y = 167
                    }},
                    {11, new Country
                    {
                        Name = RiskConstants.Countries.Peru,
                        Continent = RiskConstants.Continents.SouthAmerica,
                        X = 155,
                        Y = 210
                    }},
                    {12, new Country
                    {
                        Name = RiskConstants.Countries.Brazil,
                        Continent = RiskConstants.Continents.SouthAmerica,
                        X = 200,
                        Y = 205
                    }},
                    {13, new Country
                    {
                        Name = RiskConstants.Countries.Argentina,
                        Continent = RiskConstants.Continents.SouthAmerica,
                        X = 163,
                        Y = 255
                    }},

                    {14, new Country
                    {
                        Name = RiskConstants.Countries.Iceland,
                        Continent = RiskConstants.Continents.Europe,
                        X = 284,
                        Y = 56
                    }},
                    {15, new Country
                    {
                        Name = RiskConstants.Countries.Scandinavia,
                        Continent = RiskConstants.Continents.Europe,
                        X = 325,
                        Y = 59
                    }},
                    {16, new Country
                    {
                        Name = RiskConstants.Countries.GreatBritain,
                        Continent = RiskConstants.Continents.Europe,
                        X = 268,
                        Y = 88
                    }},
                    {17, new Country
                    {
                        Name = RiskConstants.Countries.NorthernEurope,
                        Continent = RiskConstants.Continents.Europe,
                        X = 320,
                        Y = 96
                    }},
                    {18, new Country
                    {
                        Name = RiskConstants.Countries.Ukraine,
                        Continent = RiskConstants.Continents.Europe,
                        X = 365,
                        Y = 85
                    }},
                    {19, new Country
                    {
                        Name = RiskConstants.Countries.WesternEurope,
                        Continent = RiskConstants.Continents.Europe,
                        X = 285,
                        Y = 132
                    }},
                    {20, new Country
                    {
                        Name = RiskConstants.Countries.SouthernEurope,
                        Continent = RiskConstants.Continents.Europe,
                        X = 325,
                        Y = 132
                    }},

                    {21, new Country
                    {
                        Name = RiskConstants.Countries.Egypt,
                        Continent = RiskConstants.Continents.Africa,
                        X = 335,
                        Y = 175
                    }},
                    {22, new Country
                    {
                        Name = RiskConstants.Countries.NorthAfrica,
                        Continent = RiskConstants.Continents.Africa,
                        X = 290,
                        Y = 195
                    }},
                    {23, new Country
                    {
                        Name = RiskConstants.Countries.EastAfrica,
                        Continent = RiskConstants.Continents.Africa,
                        X = 365,
                        Y = 215
                    }},
                    {24, new Country
                    {
                        Name = RiskConstants.Countries.Congo,
                        Continent = RiskConstants.Continents.Africa,
                        X = 337,
                        Y = 235
                    }},
                    {25, new Country
                    {
                        Name = RiskConstants.Countries.SouthAfrica,
                        Continent = RiskConstants.Continents.Africa,
                        X = 337,
                        Y = 285
                    }},
                    {26, new Country
                    {
                        Name = RiskConstants.Countries.Madagascar,
                        Continent = RiskConstants.Continents.Africa,
                        X = 395,
                        Y = 285
                    }},

                    {27, new Country
                    {
                        Name = RiskConstants.Countries.MiddleEast,
                        Continent = RiskConstants.Continents.Asia,
                        X = 380,
                        Y = 167
                    }},
                    {28, new Country
                    {
                        Name = RiskConstants.Countries.Afghanistan,
                        Continent = RiskConstants.Continents.Asia,
                        X = 410,
                        Y = 110
                    }},
                    {29, new Country
                    {
                        Name = RiskConstants.Countries.Ural,
                        Continent = RiskConstants.Continents.Asia,
                        X = 417,
                        Y = 75
                    }},
                    {30, new Country
                    {
                        Name = RiskConstants.Countries.Siberia,
                        Continent = RiskConstants.Continents.Asia,
                        X = 445,
                        Y = 60
                    }},
                    {31, new Country
                    {
                        Name = RiskConstants.Countries.Yakutsk,
                        Continent = RiskConstants.Continents.Asia,
                        X = 475,
                        Y = 42
                    }},
                    {32, new Country
                    {
                        Name = RiskConstants.Countries.Kamchatka,
                        Continent = RiskConstants.Continents.Asia,
                        X = 515,
                        Y = 47
                    }},
                    {33, new Country
                    {
                        Name = RiskConstants.Countries.Irkutsk,
                        Continent = RiskConstants.Continents.Asia,
                        X = 476,
                        Y = 74
                    }},
                    {34, new Country
                    {
                        Name = RiskConstants.Countries.Mongolia,
                        Continent = RiskConstants.Continents.Asia,
                        X = 485,
                        Y = 102
                    }},
                    {35, new Country
                    {
                        Name = RiskConstants.Countries.China,
                        Continent = RiskConstants.Continents.Asia,
                        X = 470,
                        Y = 130
                    }},
                    {36, new Country
                    {
                        Name = RiskConstants.Countries.Japan,
                        Continent = RiskConstants.Continents.Asia,
                        X = 540,
                        Y = 100
                    }},
                    {37, new Country
                    {
                        Name = RiskConstants.Countries.India,
                        Continent = RiskConstants.Continents.Asia,
                        X = 440,
                        Y = 165
                    }},
                    {38, new Country
                    {
                        Name = RiskConstants.Countries.Siam,
                        Continent = RiskConstants.Continents.Asia,
                        X = 485,
                        Y = 175
                    }},

                    {39, new Country
                    {
                        Name = RiskConstants.Countries.Indonesia,
                        Continent = RiskConstants.Continents.Australia,
                        X = 490,
                        Y = 235
                    }},
                    {40, new Country
                    {
                        Name = RiskConstants.Countries.NewGuinea,
                        Continent = RiskConstants.Continents.Australia,
                        X = 550,
                        Y = 220
                    }},
                    {41, new Country
                    {
                        Name = RiskConstants.Countries.WesternAustralia,
                        Continent = RiskConstants.Continents.Australia,
                        X = 515,
                        Y = 290
                    }},
                    {42, new Country
                    {
                        Name = RiskConstants.Countries.EasternAustralia,
                        Continent = RiskConstants.Continents.Australia,
                        X = 560,
                        Y = 270
                    }},
                }
            };

            board.CountriesByName = board.Countries
                .ToDictionary(x => x.Value.Name, x => x.Value);

            board.Continents = new Dictionary<string, Continent>
            {
                { RiskConstants.Continents.NorthAmerica, new Continent
                {
                    Name = RiskConstants.Continents.NorthAmerica,
                    ArmyBonus = 5,
                    Countries = board.Countries
                        .Where(x => x.Value.Continent == RiskConstants.Continents.NorthAmerica)
                        .Select(x => x.Value).ToList()
                } },
                { RiskConstants.Continents.SouthAmerica, new Continent
                {
                    Name = RiskConstants.Continents.SouthAmerica,
                    ArmyBonus = 2,
                    Countries = board.Countries
                        .Where(x => x.Value.Continent == RiskConstants.Continents.SouthAmerica)
                        .Select(x => x.Value).ToList()
                } },
                { RiskConstants.Continents.Europe, new Continent
                {
                    Name = RiskConstants.Continents.Europe,
                    ArmyBonus = 5,
                    Countries = board.Countries
                        .Where(x => x.Value.Continent == RiskConstants.Continents.Europe)
                        .Select(x => x.Value).ToList()
                } },
                { RiskConstants.Continents.Africa, new Continent
                {
                    Name = RiskConstants.Continents.Africa,
                    ArmyBonus = 3,
                    Countries = board.Countries
                        .Where(x => x.Value.Continent == RiskConstants.Continents.Africa)
                        .Select(x => x.Value).ToList()
                } },
                { RiskConstants.Continents.Asia, new Continent
                {
                    Name = RiskConstants.Continents.Asia,
                    ArmyBonus = 7,
                    Countries = board.Countries
                        .Where(x => x.Value.Continent == RiskConstants.Continents.Asia)
                        .Select(x => x.Value).ToList()
                } },
                { RiskConstants.Continents.Australia, new Continent
                {
                    Name = RiskConstants.Continents.Australia,
                    ArmyBonus = 2,
                    Countries = board.Countries
                        .Where(x => x.Value.Continent == RiskConstants.Continents.Australia)
                        .Select(x => x.Value).ToList()
                } },
            };

            board.CountriesByName[RiskConstants.Countries.Alaska].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.NorthwestTerritory],
                board.CountriesByName[RiskConstants.Countries.Alberta],
                board.CountriesByName[RiskConstants.Countries.Kamchatka],
            };
            board.CountriesByName[RiskConstants.Countries.NorthwestTerritory].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Alaska],
                board.CountriesByName[RiskConstants.Countries.Alberta],
                board.CountriesByName[RiskConstants.Countries.Ontario],
                board.CountriesByName[RiskConstants.Countries.Greenland],
            };
            board.CountriesByName[RiskConstants.Countries.Greenland].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.NorthwestTerritory],
                board.CountriesByName[RiskConstants.Countries.Ontario],
                board.CountriesByName[RiskConstants.Countries.Quebec],
                board.CountriesByName[RiskConstants.Countries.Iceland],
            };
            board.CountriesByName[RiskConstants.Countries.Alberta].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Alaska],
                board.CountriesByName[RiskConstants.Countries.NorthwestTerritory],
                board.CountriesByName[RiskConstants.Countries.Ontario],
                board.CountriesByName[RiskConstants.Countries.WesternUnitedStates],
            };
            board.CountriesByName[RiskConstants.Countries.Ontario].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Alberta],
                board.CountriesByName[RiskConstants.Countries.NorthwestTerritory],
                board.CountriesByName[RiskConstants.Countries.Greenland],
                board.CountriesByName[RiskConstants.Countries.Quebec],
                board.CountriesByName[RiskConstants.Countries.EasternUnitedStates],
                board.CountriesByName[RiskConstants.Countries.WesternUnitedStates],
            };
            board.CountriesByName[RiskConstants.Countries.Quebec].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Ontario],
                board.CountriesByName[RiskConstants.Countries.Greenland],
                board.CountriesByName[RiskConstants.Countries.EasternUnitedStates],
            };
            board.CountriesByName[RiskConstants.Countries.WesternUnitedStates].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Alberta],
                board.CountriesByName[RiskConstants.Countries.Ontario],
                board.CountriesByName[RiskConstants.Countries.EasternUnitedStates],
                board.CountriesByName[RiskConstants.Countries.CentralAmerica],
            };
            board.CountriesByName[RiskConstants.Countries.EasternUnitedStates].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.WesternUnitedStates],
                board.CountriesByName[RiskConstants.Countries.Ontario],
                board.CountriesByName[RiskConstants.Countries.Quebec],
                board.CountriesByName[RiskConstants.Countries.CentralAmerica],
            };
            board.CountriesByName[RiskConstants.Countries.CentralAmerica].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.WesternUnitedStates],
                board.CountriesByName[RiskConstants.Countries.EasternUnitedStates],
                board.CountriesByName[RiskConstants.Countries.Venezuela],
            };

            board.CountriesByName[RiskConstants.Countries.Venezuela].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Peru],
                board.CountriesByName[RiskConstants.Countries.Brazil],
                board.CountriesByName[RiskConstants.Countries.CentralAmerica],
            };
            board.CountriesByName[RiskConstants.Countries.Peru].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Venezuela],
                board.CountriesByName[RiskConstants.Countries.Brazil],
                board.CountriesByName[RiskConstants.Countries.Argentina],
            };
            board.CountriesByName[RiskConstants.Countries.Brazil].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Venezuela],
                board.CountriesByName[RiskConstants.Countries.Peru],
                board.CountriesByName[RiskConstants.Countries.Argentina],
                board.CountriesByName[RiskConstants.Countries.NorthAfrica],
            };
            board.CountriesByName[RiskConstants.Countries.Argentina].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Peru],
                board.CountriesByName[RiskConstants.Countries.Brazil],
            };

            board.CountriesByName[RiskConstants.Countries.Iceland].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.GreatBritain],
                board.CountriesByName[RiskConstants.Countries.Scandinavia],
                board.CountriesByName[RiskConstants.Countries.Greenland],
            };
            board.CountriesByName[RiskConstants.Countries.Scandinavia].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Iceland],
                board.CountriesByName[RiskConstants.Countries.GreatBritain],
                board.CountriesByName[RiskConstants.Countries.NorthernEurope],
                board.CountriesByName[RiskConstants.Countries.Ukraine],
            };
            board.CountriesByName[RiskConstants.Countries.GreatBritain].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Iceland],
                board.CountriesByName[RiskConstants.Countries.Scandinavia],
                board.CountriesByName[RiskConstants.Countries.NorthernEurope],
                board.CountriesByName[RiskConstants.Countries.WesternEurope],
            };
            board.CountriesByName[RiskConstants.Countries.NorthernEurope].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Iceland],
                board.CountriesByName[RiskConstants.Countries.Scandinavia],
                board.CountriesByName[RiskConstants.Countries.GreatBritain],
                board.CountriesByName[RiskConstants.Countries.Ukraine],
                board.CountriesByName[RiskConstants.Countries.WesternEurope],
                board.CountriesByName[RiskConstants.Countries.SouthernEurope],
            };
            board.CountriesByName[RiskConstants.Countries.Ukraine].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Scandinavia],
                board.CountriesByName[RiskConstants.Countries.NorthernEurope],
                board.CountriesByName[RiskConstants.Countries.SouthernEurope],
                board.CountriesByName[RiskConstants.Countries.Ural],
                board.CountriesByName[RiskConstants.Countries.Afghanistan],
                board.CountriesByName[RiskConstants.Countries.MiddleEast],
            };
            board.CountriesByName[RiskConstants.Countries.WesternEurope].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.GreatBritain],
                board.CountriesByName[RiskConstants.Countries.NorthernEurope],
                board.CountriesByName[RiskConstants.Countries.SouthernEurope],
                board.CountriesByName[RiskConstants.Countries.NorthAfrica],
            };

            board.CountriesByName[RiskConstants.Countries.Egypt].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.NorthAfrica],
                board.CountriesByName[RiskConstants.Countries.EastAfrica],
                board.CountriesByName[RiskConstants.Countries.SouthernEurope],
                board.CountriesByName[RiskConstants.Countries.MiddleEast],
            };
            board.CountriesByName[RiskConstants.Countries.NorthAfrica].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Egypt],
                board.CountriesByName[RiskConstants.Countries.EastAfrica],
                board.CountriesByName[RiskConstants.Countries.Congo],
                board.CountriesByName[RiskConstants.Countries.Brazil],
            };
            board.CountriesByName[RiskConstants.Countries.EastAfrica].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Egypt],
                board.CountriesByName[RiskConstants.Countries.NorthAfrica],
                board.CountriesByName[RiskConstants.Countries.Congo],
                board.CountriesByName[RiskConstants.Countries.Madagascar],
                board.CountriesByName[RiskConstants.Countries.MiddleEast],
            };
            board.CountriesByName[RiskConstants.Countries.Congo].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.NorthAfrica],
                board.CountriesByName[RiskConstants.Countries.EastAfrica],
                board.CountriesByName[RiskConstants.Countries.SouthAfrica],
            };
            board.CountriesByName[RiskConstants.Countries.SouthAfrica].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Congo],
                board.CountriesByName[RiskConstants.Countries.EastAfrica],
                board.CountriesByName[RiskConstants.Countries.Madagascar],
            };
            board.CountriesByName[RiskConstants.Countries.Madagascar].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.EastAfrica],
                board.CountriesByName[RiskConstants.Countries.SouthAfrica],
            };

            board.CountriesByName[RiskConstants.Countries.MiddleEast].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Afghanistan],
                board.CountriesByName[RiskConstants.Countries.India],
                board.CountriesByName[RiskConstants.Countries.Ukraine],
                board.CountriesByName[RiskConstants.Countries.SouthernEurope],
                board.CountriesByName[RiskConstants.Countries.Egypt],
                board.CountriesByName[RiskConstants.Countries.EastAfrica],
            };
            board.CountriesByName[RiskConstants.Countries.Afghanistan].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.MiddleEast],
                board.CountriesByName[RiskConstants.Countries.India],
                board.CountriesByName[RiskConstants.Countries.China],
                board.CountriesByName[RiskConstants.Countries.Ural],
                board.CountriesByName[RiskConstants.Countries.Ukraine],
            };
            board.CountriesByName[RiskConstants.Countries.Ural].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Afghanistan],
                board.CountriesByName[RiskConstants.Countries.China],
                board.CountriesByName[RiskConstants.Countries.Siberia],
                board.CountriesByName[RiskConstants.Countries.Ukraine],
            };
            board.CountriesByName[RiskConstants.Countries.Siberia].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Ural],
                board.CountriesByName[RiskConstants.Countries.China],
                board.CountriesByName[RiskConstants.Countries.Mongolia],
                board.CountriesByName[RiskConstants.Countries.Irkutsk],
                board.CountriesByName[RiskConstants.Countries.Yakutsk],
            };
            board.CountriesByName[RiskConstants.Countries.Yakutsk].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Siberia],
                board.CountriesByName[RiskConstants.Countries.Irkutsk],
                board.CountriesByName[RiskConstants.Countries.Kamchatka],
            };
            board.CountriesByName[RiskConstants.Countries.Kamchatka].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Yakutsk],
                board.CountriesByName[RiskConstants.Countries.Irkutsk],
                board.CountriesByName[RiskConstants.Countries.Mongolia],
                board.CountriesByName[RiskConstants.Countries.Japan],
                board.CountriesByName[RiskConstants.Countries.Alaska],
            };
            board.CountriesByName[RiskConstants.Countries.Irkutsk].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Yakutsk],
                board.CountriesByName[RiskConstants.Countries.Kamchatka],
                board.CountriesByName[RiskConstants.Countries.Mongolia],
                board.CountriesByName[RiskConstants.Countries.Siberia],
            };
            board.CountriesByName[RiskConstants.Countries.Mongolia].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Irkutsk],
                board.CountriesByName[RiskConstants.Countries.Kamchatka],
                board.CountriesByName[RiskConstants.Countries.Japan],
                board.CountriesByName[RiskConstants.Countries.China],
                board.CountriesByName[RiskConstants.Countries.Siberia],
            };
            board.CountriesByName[RiskConstants.Countries.China].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Afghanistan],
                board.CountriesByName[RiskConstants.Countries.Ural],
                board.CountriesByName[RiskConstants.Countries.Siberia],
                board.CountriesByName[RiskConstants.Countries.Mongolia],
                board.CountriesByName[RiskConstants.Countries.Siam],
                board.CountriesByName[RiskConstants.Countries.India],
            };
            board.CountriesByName[RiskConstants.Countries.Japan].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Kamchatka],
                board.CountriesByName[RiskConstants.Countries.Mongolia],
            };
            board.CountriesByName[RiskConstants.Countries.India].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.MiddleEast],
                board.CountriesByName[RiskConstants.Countries.Afghanistan],
                board.CountriesByName[RiskConstants.Countries.China],
                board.CountriesByName[RiskConstants.Countries.Siam],
            };
            board.CountriesByName[RiskConstants.Countries.Siam].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.India],
                board.CountriesByName[RiskConstants.Countries.China],
                board.CountriesByName[RiskConstants.Countries.Indonesia],
            };

            board.CountriesByName[RiskConstants.Countries.Indonesia].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Siam],
                board.CountriesByName[RiskConstants.Countries.NewGuinea],
                board.CountriesByName[RiskConstants.Countries.WesternAustralia],
            };
            board.CountriesByName[RiskConstants.Countries.NewGuinea].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Indonesia],
                board.CountriesByName[RiskConstants.Countries.EasternAustralia],
                board.CountriesByName[RiskConstants.Countries.WesternAustralia],
            };
            board.CountriesByName[RiskConstants.Countries.WesternAustralia].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.Indonesia],
                board.CountriesByName[RiskConstants.Countries.EasternAustralia],
                board.CountriesByName[RiskConstants.Countries.NewGuinea],
            };
            board.CountriesByName[RiskConstants.Countries.EasternAustralia].AdjacentCountries = new List<Country>
            {
                board.CountriesByName[RiskConstants.Countries.WesternAustralia],
                board.CountriesByName[RiskConstants.Countries.NewGuinea],
            };

            return board;
        }
    }
}
