using Poker.Common.Models;

namespace Poker.Common
{
    /// <summary>
    /// Helper
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Helper
        /// </summary>
        public Helper()
        {

        }

        // /// <summary>
        // /// Mappings
        // /// </summary>
        // /// <returns></returns>
        // public static List<KeyValuePair<string, string>> Mappings()
        // {
        //     // Mappings
        //     // k2.webp => Clubs
        //     // l2.webp => Diamonds
        //     // p2.webp => Spades
        //     // s2.webp => Hearts

        //     // TODO: Scan each sticker and add the value(s) here...

        //     List<KeyValuePair<string, string>> rfidMapping = new List<KeyValuePair<string, string>>
        //     {
        //         // Clubs (k)
        //         new KeyValuePair<string, string>("2c", "k2"), // 2 of Clubs
        //         new KeyValuePair<string, string>("3c", "k3"), // 3 of Clubs
        //         new KeyValuePair<string, string>("4c", "k4"), // 4 of Clubs
        //         new KeyValuePair<string, string>("5c", "k5"), // 5 of Clubs
        //         new KeyValuePair<string, string>("6c", "k6"), // 6 of Clubs
        //         new KeyValuePair<string, string>("7c", "k7"), // 7 of Clubs
        //         new KeyValuePair<string, string>("8c", "k8"), // 8 of Clubs
        //         new KeyValuePair<string, string>("9c", "k9"), // 9 of Clubs
        //         new KeyValuePair<string, string>("10c", "k10"), // 10 of Clubs
        //         new KeyValuePair<string, string>("jc", "kj"), // Jack of Clubs
        //         new KeyValuePair<string, string>("qc", "kq"), // Queen of Clubs
        //         new KeyValuePair<string, string>("kc", "kk"), // King of Clubs
        //         new KeyValuePair<string, string>("ac", "ka"), // Ace of Clubs

        //         // Diamonds (l)
        //         new KeyValuePair<string, string>("2d", "l2"), // 2 of Diamonds
        //         new KeyValuePair<string, string>("3d", "l3"), // 3 of Diamonds
        //         new KeyValuePair<string, string>("4d", "l4"), // 4 of Diamonds
        //         new KeyValuePair<string, string>("5d", "l5"), // 5 of Diamonds
        //         new KeyValuePair<string, string>("6d", "l6"), // 6 of Diamonds
        //         new KeyValuePair<string, string>("7d", "l7"), // 7 of Diamonds
        //         new KeyValuePair<string, string>("8d", "l8"), // 8 of Diamonds
        //         new KeyValuePair<string, string>("9d", "l9"), // 9 of Diamonds
        //         new KeyValuePair<string, string>("10d", "l10"), // 10 of Diamonds
        //         new KeyValuePair<string, string>("jd", "lj"), // Jack of Diamonds
        //         new KeyValuePair<string, string>("qd", "lq"), // Queen of Diamonds
        //         new KeyValuePair<string, string>("kd", "lk"), // King of Diamonds
        //         new KeyValuePair<string, string>("ad", "la"), // Ace of Diamonds

        //         // Spades (p)
        //         new KeyValuePair<string, string>("2s", "p2"), // 2 of Spades
        //         new KeyValuePair<string, string>("3s", "p3"), // 3 of Spades
        //         new KeyValuePair<string, string>("4s", "p4"), // 4 of Spades
        //         new KeyValuePair<string, string>("5s", "p5"), // 5 of Spades
        //         new KeyValuePair<string, string>("6s", "p6"), // 6 of Spades
        //         new KeyValuePair<string, string>("7s", "p7"), // 7 of Spades
        //         new KeyValuePair<string, string>("8s", "p8"), // 8 of Spades
        //         new KeyValuePair<string, string>("9s", "p9"), // 9 of Spades
        //         new KeyValuePair<string, string>("10s", "p10"), // 10 of Spades
        //         new KeyValuePair<string, string>("js", "pj"), // Jack of Spades
        //         new KeyValuePair<string, string>("qs", "pq"), // Queen of Spades
        //         new KeyValuePair<string, string>("ks", "pk"), // King of Spades
        //         new KeyValuePair<string, string>("as", "pa"), // Ace of Spades

        //         // Hearts (s)
        //         new KeyValuePair<string, string>("2h", "s2"), // 2 of Hearts
        //         new KeyValuePair<string, string>("3h", "s3"), // 3 of Hearts
        //         new KeyValuePair<string, string>("4h", "s4"), // 4 of Hearts
        //         new KeyValuePair<string, string>("5h", "s5"), // 5 of Hearts
        //         new KeyValuePair<string, string>("6h", "s6"), // 6 of Hearts
        //         new KeyValuePair<string, string>("7h", "s7"), // 7 of Hearts
        //         new KeyValuePair<string, string>("8h", "s8"), // 8 of Hearts
        //         new KeyValuePair<string, string>("9h", "s9"), // 9 of Hearts
        //         new KeyValuePair<string, string>("10h", "s10"), // 10 of Hearts
        //         new KeyValuePair<string, string>("jh", "sj"), // Jack of Hearts
        //         new KeyValuePair<string, string>("qh", "sq"), // Queen of Hearts
        //         new KeyValuePair<string, string>("kh", "sk"), // King of Hearts
        //         new KeyValuePair<string, string>("ah", "sa") // Ace of Hearts
        //     };

        //     return rfidMapping;
        // }

        /// <summary>
        /// Mappings
        /// </summary>
        /// <returns></returns>
        public static List<Mapping> Mappings()
        {
            List<Mapping> rfidMapping = new ()
            {
                // Clubs (k)
                new Mapping() { CardName = "Ace of Clubs", CardHex = "0413163DB92A81", CardDec = "0419226118542129", ImageName = "ka" }, // Ace of Clubs
                new Mapping() { CardName = "2 of Clubs", CardHex = "0412163DB92A81", CardDec = "0418226118542129", ImageName = "k2" }, // 2 of Clubs
                new Mapping() { CardName = "3 of Clubs", CardHex = "0411163DB92A81", CardDec = "0417226118542129", ImageName = "k3" }, // 3 of Clubs
                new Mapping() { CardName = "4 of Clubs", CardHex = "04FF153DB92A81", CardDec = "04255216118542129", ImageName = "k4" }, // 4 of Clubs
                new Mapping() { CardName = "5 of Clubs", CardHex = "04FA153DB92A81", CardDec = "04250216118542129", ImageName = "k5" }, // 5 of Clubs
                new Mapping() { CardName = "6 of Clubs", CardHex = "04F9153DB92A81", CardDec = "04249216118542129", ImageName = "k6" }, // 6 of Clubs
                new Mapping() { CardName = "7 of Clubs", CardHex = "04F8153DB92A81", CardDec = "04248216118542129", ImageName = "k7" }, // 7 of Clubs
                new Mapping() { CardName = "8 of Clubs", CardHex = "04F7153DB92A81", CardDec = "04247216118542129", ImageName = "k8" }, // 8 of Clubs
                new Mapping() { CardName = "9 of Clubs", CardHex = "04F2153DB92A81", CardDec = "04242216118542129", ImageName = "k9" }, // 9 of Clubs
                new Mapping() { CardName = "10 of Clubs", CardHex = "04F1153DB92A81", CardDec = "04241216118542129", ImageName = "k10" }, // 10 of Clubs
                new Mapping() { CardName = "Jack of Clubs", CardHex = "04EF153DB92A81", CardDec = "04239216118542129", ImageName = "kj" }, // Jack of Clubs
                new Mapping() { CardName = "Queen of Clubs", CardHex = "04A68B3EB92A81", CardDec = "041661396218542129", ImageName = "kq" }, // Queen of Clubs
                new Mapping() { CardName = "King of Clubs", CardHex = "04E9153DB92A81", CardDec = "04233216118542129", ImageName = "kk" }, // King of Clubs
                
                // Diamonds (l)
                new Mapping() { CardName = "Ace of Diamonds", CardHex = "04E8153DB92A81", CardDec = "04232216118542129", ImageName = "la" }, // Ace of Diamonds
                new Mapping() { CardName = "2 of Diamonds", CardHex = "04A58B3EB92A81", CardDec = "041651396218542129", ImageName = "l2" }, // 2 of Diamonds
                new Mapping() { CardName = "3 of Diamonds", CardHex = "04E6153DB92A81", CardDec = "04230216118542129", ImageName = "l3" }, // 3 of Diamonds
                new Mapping() { CardName = "4 of Diamonds", CardHex = "04E1153DB92A81", CardDec = "04225216118542129", ImageName = "l4" }, // 4 of Diamonds
                new Mapping() { CardName = "5 of Diamonds", CardHex = "04DF153DB92A81", CardDec = "04223216118542129", ImageName = "l5" }, // 5 of Diamonds
                new Mapping() { CardName = "6 of Diamonds", CardHex = "04DE153DB92A81", CardDec = "04222216118542129", ImageName = "l6" }, // 6 of Diamonds
                new Mapping() { CardName = "7 of Diamonds", CardHex = "04DD153DB92A81", CardDec = "04221216118542129", ImageName = "l7" }, // 7 of Diamonds
                new Mapping() { CardName = "8 of Diamonds", CardHex = "04D8153DB92A81", CardDec = "04216216118542129", ImageName = "l8" }, // 8 of Diamonds
                new Mapping() { CardName = "9 of Diamonds", CardHex = "04D7153DB92A81", CardDec = "04215216118542129", ImageName = "l9" }, // 9 of Diamonds
                new Mapping() { CardName = "10 of Diamonds", CardHex = "04D6153DB92A81", CardDec = "04214216118542129", ImageName = "l10" }, // 10 of Diamonds
                new Mapping() { CardName = "Jack of Diamonds", CardHex = "04D5153DB92A81", CardDec = "04213216118542129", ImageName = "lj" }, // Jack of Diamonds
                new Mapping() { CardName = "Queen of Diamonds", CardHex = "04CF153DB92A81", CardDec = "04207216118542129", ImageName = "lq" }, // Queen of Diamonds
                new Mapping() { CardName = "King of Diamonds", CardHex = "04CE153DB92A81", CardDec = "04206216118542129", ImageName = "lk" }, // King of Diamonds

                // Spades (p)
                new Mapping() { CardName = "Ace of Spades", CardHex = "04CD153DB92A81", CardDec = "04205216118542129", ImageName = "pa" }, // Ace of Spades
                new Mapping() { CardName = "2 of Spades", CardHex = "04CC153DB92A81", CardDec = "04204216118542129", ImageName = "p2" }, // 2 of Spades
                new Mapping() { CardName = "3 of Spades", CardHex = "04C7153DB92A81", CardDec = "04199216118542129", ImageName = "p3" }, // 3 of Spades
                new Mapping() { CardName = "4 of Spades", CardHex = "04C6153DB92A81", CardDec = "04198216118542129", ImageName = "p4" }, // 4 of Spades
                new Mapping() { CardName = "5 of Spades", CardHex = "04C5153DB92A81", CardDec = "04197216118542129", ImageName = "p5" }, // 5 of Spades
                new Mapping() { CardName = "6 of Spades", CardHex = "04C4153DB92A81", CardDec = "04196216118542129", ImageName = "p6" }, // 6 of Spades
                new Mapping() { CardName = "7 of Spades", CardHex = "04BE153DB92A81", CardDec = "04190216118542129", ImageName = "p7" }, // 7 of Spades
                new Mapping() { CardName = "8 of Spades", CardHex = "04BD153DB92A81", CardDec = "04189216118542129", ImageName = "p8" }, // 8 of Spades
                new Mapping() { CardName = "9 of Spades", CardHex = "04BC153DB92A81", CardDec = "04188216118542129", ImageName = "p9" }, // 9 of Spades
                new Mapping() { CardName = "10 of Spades", CardHex = "04BB153DB92A81", CardDec = "04187216118542129", ImageName = "p10" }, // 10 of Spades
                new Mapping() { CardName = "Jack of Spades", CardHex = "04B6153DB92A81", CardDec = "04182216118542129", ImageName = "pj" }, // Jack of Spades
                new Mapping() { CardName = "Queen of Spades", CardHex = "04B5153DB92A81", CardDec = "04181216118542129", ImageName = "pq" }, // Queen of Spades
                new Mapping() { CardName = "King of Spades", CardHex = "04B4153DB92A81", CardDec = "04180216118542129", ImageName = "pk" }, // King of Spades
                
                // Hearts (s)
                new Mapping() { CardName = "Ace of Hearts", CardHex = "04B3153DB92A81", CardDec = "04179216118542129", ImageName = "sa" }, // Ace of Hearts
                new Mapping() { CardName = "2 of Hearts", CardHex = "04AD153DB92A81", CardDec = "04173216118542129", ImageName = "s2" }, // 2 of Hearts
                new Mapping() { CardName = "3 of Hearts", CardHex = "04AC153DB92A81", CardDec = "04172216118542129", ImageName = "s3" }, // 3 of Hearts
                new Mapping() { CardName = "4 of Hearts", CardHex = "04AB153DB92A81", CardDec = "04171216118542129", ImageName = "s4" }, // 4 of Hearts
                new Mapping() { CardName = "5 of Hearts", CardHex = "04AA153DB92A81", CardDec = "04170216118542129", ImageName = "s5" }, // 5 of Hearts
                new Mapping() { CardName = "6 of Hearts", CardHex = "04A4153DB92A81", CardDec = "04164216118542129", ImageName = "s6" }, // 6 of Hearts
                new Mapping() { CardName = "7 of Hearts", CardHex = "04A3153DB92A81", CardDec = "04163216118542129", ImageName = "s7" }, // 7 of Hearts
                new Mapping() { CardName = "8 of Hearts", CardHex = "04A2153DB92A81", CardDec = "04162216118542129", ImageName = "s8" }, // 8 of Hearts
                new Mapping() { CardName = "9 of Hearts", CardHex = "049C153DB92A81", CardDec = "04156216118542129", ImageName = "s9" }, // 9 of Hearts
                new Mapping() { CardName = "10 of Hearts", CardHex = "049A153DB92A81", CardDec = "04154216118542129", ImageName = "s10" }, // 10 of Hearts
                new Mapping() { CardName = "Jack of Hearts", CardHex = "0499153DB92A81", CardDec = "04153216118542129", ImageName = "sj" }, // Jack of Hearts
                new Mapping() { CardName = "Queen of Hearts", CardHex = "04489A3AE94C81", CardDec = "04721545823376129", ImageName = "sq" }, // Queen of Hearts
                new Mapping() { CardName = "King of Hearts", CardHex = "0481983AE94C81", CardDec = "041291525823376129", ImageName = "sk" } // King of Hearts
            };

            return rfidMapping;
        }


    }
}
