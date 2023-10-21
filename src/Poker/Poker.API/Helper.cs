using Poker.API.Models;

namespace Poker.API
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
                new Mapping() { CardName = "Ace of Clubs", CardHex = "04 13 16 3D B9 2A 81", CardDec = "04 19 22 61 185 42 129", ImageName = "ka" }, // Ace of Clubs
                new Mapping() { CardName = "2 of Clubs", CardHex = "04 12 16 3D B9 2A 81", CardDec = "04 18 22 61 185 42 129", ImageName = "k2" }, // 2 of Clubs
                new Mapping() { CardName = "3 of Clubs", CardHex = "04 11 16 3D B9 2A 81", CardDec = "04 17 22 61 185 42 129", ImageName = "k3" }, // 3 of Clubs
                new Mapping() { CardName = "4 of Clubs", CardHex = "04 FF 15 3D B9 2A 81", CardDec = "04 255 21 61 185 42 129", ImageName = "k4" }, // 4 of Clubs
                new Mapping() { CardName = "5 of Clubs", CardHex = "04 FA 15 3D B9 2A 81", CardDec = "04 250 21 61 185 42 129", ImageName = "k5" }, // 5 of Clubs
                new Mapping() { CardName = "6 of Clubs", CardHex = "04 F9 15 3D B9 2A 81", CardDec = "04 249 21 61 185 42 129", ImageName = "k6" }, // 6 of Clubs
                new Mapping() { CardName = "7 of Clubs", CardHex = "04 F8 15 3D B9 2A 81", CardDec = "04 248 21 61 185 42 129", ImageName = "k7" }, // 7 of Clubs
                new Mapping() { CardName = "8 of Clubs", CardHex = "04 F7 15 3D B9 2A 81", CardDec = "04 247 21 61 185 42 129", ImageName = "k8" }, // 8 of Clubs
                new Mapping() { CardName = "9 of Clubs", CardHex = "04 F2 15 3D B9 2A 81", CardDec = "04 242 21 61 185 42 129", ImageName = "k9" }, // 9 of Clubs
                new Mapping() { CardName = "10 of Clubs", CardHex = "04 F1 15 3D B9 2A 81", CardDec = "04 241 21 61 185 42 129", ImageName = "k10" }, // 10 of Clubs
                new Mapping() { CardName = "Jack of Clubs", CardHex = "04 EF 15 3D B9 2A 81", CardDec = "04 239 21 61 185 42 129", ImageName = "kj" }, // Jack of Clubs
                new Mapping() { CardName = "Queen of Clubs", CardHex = "04 A6 8B 3E B9 2A 81", CardDec = "04 166 139 62 185 42 129", ImageName = "kq" }, // Queen of Clubs
                new Mapping() { CardName = "King of Clubs", CardHex = "04 E9 15 3D B9 2A 81", CardDec = "04 233 21 61 185 42 129", ImageName = "kk" }, // King of Clubs
                
                // Diamonds (l)
                new Mapping() { CardName = "Ace of Diamonds", CardHex = "04 E8 15 3D B9 2A 81", CardDec = "04 232 21 61 185 42 129", ImageName = "la" }, // Ace of Diamonds
                new Mapping() { CardName = "2 of Diamonds", CardHex = "04 A5 8B 3E B9 2A 81", CardDec = "04 165 139 62 185 42 129", ImageName = "l2" }, // 2 of Diamonds
                new Mapping() { CardName = "3 of Diamonds", CardHex = "04 E6 15 3D B9 2A 81", CardDec = "04 230 21 61 185 42 129", ImageName = "l3" }, // 3 of Diamonds
                new Mapping() { CardName = "4 of Diamonds", CardHex = "04 E1 15 3D B9 2A 81", CardDec = "04 225 21 61 185 42 129", ImageName = "l4" }, // 4 of Diamonds
                new Mapping() { CardName = "5 of Diamonds", CardHex = "04 DF 15 3D B9 2A 81", CardDec = "04 223 21 61 185 42 129", ImageName = "l5" }, // 5 of Diamonds
                new Mapping() { CardName = "6 of Diamonds", CardHex = "04 DE 15 3D B9 2A 81", CardDec = "04 222 21 61 185 42 129", ImageName = "l6" }, // 6 of Diamonds
                new Mapping() { CardName = "7 of Diamonds", CardHex = "04 DD 15 3D B9 2A 81", CardDec = "04 221 21 61 185 42 129", ImageName = "l7" }, // 7 of Diamonds
                new Mapping() { CardName = "8 of Diamonds", CardHex = "04 D8 15 3D B9 2A 81", CardDec = "04 216 21 61 185 42 129", ImageName = "l8" }, // 8 of Diamonds
                new Mapping() { CardName = "9 of Diamonds", CardHex = "04 D7 15 3D B9 2A 81", CardDec = "04 215 21 61 185 42 129", ImageName = "l9" }, // 9 of Diamonds
                new Mapping() { CardName = "10 of Diamonds", CardHex = "04 D6 15 3D B9 2A 81", CardDec = "04 214 21 61 185 42 129", ImageName = "l10" }, // 10 of Diamonds
                new Mapping() { CardName = "Jack of Diamonds", CardHex = "04 D5 15 3D B9 2A 81", CardDec = "04 213 21 61 185 42 129", ImageName = "lj" }, // Jack of Diamonds
                new Mapping() { CardName = "Queen of Diamonds", CardHex = "04 CF 15 3D B9 2A 81", CardDec = "04 207 21 61 185 42 129", ImageName = "lq" }, // Queen of Diamonds
                new Mapping() { CardName = "King of Diamonds", CardHex = "04 CE 15 3D B9 2A 81", CardDec = "04 206 21 61 185 42 129", ImageName = "lk" }, // King of Diamonds

                // Spades (p)
                new Mapping() { CardName = "Ace of Spades", CardHex = "04 CD 15 3D B9 2A 81", CardDec = "04 205 21 61 185 42 129", ImageName = "pa" }, // Ace of Spades
                new Mapping() { CardName = "2 of Spades", CardHex = "04 CC 15 3D B9 2A 81", CardDec = "04 204 21 61 185 42 129", ImageName = "p2" }, // 2 of Spades
                new Mapping() { CardName = "3 of Spades", CardHex = "04 C7 15 3D B9 2A 81", CardDec = "04 199 21 61 185 42 129", ImageName = "p3" }, // 3 of Spades
                new Mapping() { CardName = "4 of Spades", CardHex = "04 C6 15 3D B9 2A 81", CardDec = "04 198 21 61 185 42 129", ImageName = "p4" }, // 4 of Spades
                new Mapping() { CardName = "5 of Spades", CardHex = "04 C5 15 3D B9 2A 81", CardDec = "04 197 21 61 185 42 129", ImageName = "p5" }, // 5 of Spades
                new Mapping() { CardName = "6 of Spades", CardHex = "04 C4 15 3D B9 2A 81", CardDec = "04 196 21 61 185 42 129", ImageName = "p6" }, // 6 of Spades
                new Mapping() { CardName = "7 of Spades", CardHex = "04 BE 15 3D B9 2A 81", CardDec = "04 190 21 61 185 42 129", ImageName = "p7" }, // 7 of Spades
                new Mapping() { CardName = "8 of Spades", CardHex = "04 BD 15 3D B9 2A 81", CardDec = "04 189 21 61 185 42 129", ImageName = "p8" }, // 8 of Spades
                new Mapping() { CardName = "9 of Spades", CardHex = "04 BC 15 3D B9 2A 81", CardDec = "04 188 21 61 185 42 129", ImageName = "p9" }, // 9 of Spades
                new Mapping() { CardName = "10 of Spades", CardHex = "04 BB 15 3D B9 2A 81", CardDec = "04 187 21 61 185 42 129", ImageName = "p10" }, // 10 of Spades
                new Mapping() { CardName = "Jack of Spades", CardHex = "04 B6 15 3D B9 2A 81", CardDec = "04 182 21 61 185 42 129", ImageName = "pj" }, // Jack of Spades
                new Mapping() { CardName = "Queen of Spades", CardHex = "04 B5 15 3D B9 2A 81", CardDec = "04 181 21 61 185 42 129", ImageName = "pq" }, // Queen of Spades
                new Mapping() { CardName = "King of Spades", CardHex = "04 B4 15 3D B9 2A 81", CardDec = "04 180 21 61 185 42 129", ImageName = "pk" }, // King of Spades
                
                // Hearts (s)
                new Mapping() { CardName = "Ace of Hearts", CardHex = "04 B3 15 3D B9 2A 81", CardDec = "04 179 21 61 185 42 129", ImageName = "sa" }, // Ace of Hearts
                new Mapping() { CardName = "2 of Hearts", CardHex = "04 AD 15 3D B9 2A 81", CardDec = "04 173 21 61 185 42 129", ImageName = "s2" }, // 2 of Hearts
                new Mapping() { CardName = "3 of Hearts", CardHex = "04 AC 15 3D B9 2A 81", CardDec = "04 172 21 61 185 42 129", ImageName = "s3" }, // 3 of Hearts
                new Mapping() { CardName = "4 of Hearts", CardHex = "04 AB 15 3D B9 2A 81", CardDec = "04 171 21 61 185 42 129", ImageName = "s4" }, // 4 of Hearts
                new Mapping() { CardName = "5 of Hearts", CardHex = "04 AA 15 3D B9 2A 81", CardDec = "04 170 21 61 185 42 129", ImageName = "s5" }, // 5 of Hearts
                new Mapping() { CardName = "6 of Hearts", CardHex = "04 A4 15 3D B9 2A 81", CardDec = "04 164 21 61 185 42 129", ImageName = "s6" }, // 6 of Hearts
                new Mapping() { CardName = "7 of Hearts", CardHex = "04 A3 15 3D B9 2A 81", CardDec = "04 163 21 61 185 42 129", ImageName = "s7" }, // 7 of Hearts
                new Mapping() { CardName = "8 of Hearts", CardHex = "04 A2 15 3D B9 2A 81", CardDec = "04 162 21 61 185 42 129", ImageName = "s8" }, // 8 of Hearts
                new Mapping() { CardName = "9 of Hearts", CardHex = "04 9C 15 3D B9 2A 81", CardDec = "04 156 21 61 185 42 129", ImageName = "s9" }, // 9 of Hearts
                new Mapping() { CardName = "10 of Hearts", CardHex = "04 9A 15 3D B9 2A 81", CardDec = "04 154 21 61 185 42 129", ImageName = "s10" }, // 10 of Hearts
                new Mapping() { CardName = "Jack of Hearts", CardHex = "04 99 15 3D B9 2A 81", CardDec = "04 153 21 61 185 42 129", ImageName = "sj" }, // Jack of Hearts
                new Mapping() { CardName = "Queen of Hearts", CardHex = "04 48 9A 3A E9 4C 81", CardDec = "04 72 154 58 233 76 129", ImageName = "sq" }, // Queen of Hearts
                new Mapping() { CardName = "King of Hearts", CardHex = "04 81 98 3A E9 4C 81", CardDec = "04 129 152 58 233 76 129", ImageName = "sk" } // King of Hearts
            };

            return rfidMapping;
        }


    }
}
