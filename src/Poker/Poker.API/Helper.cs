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

        /// <summary>
        /// Mappings
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> Mappings()
        {
            // Mappings
            // k2.webp => Clubs
            // l2.webp => Diamonds
            // p2.webp => Spades
            // s2.webp => Hearts

            // TODO: Scan each sticker and add the value(s) here...

            List<KeyValuePair<string, string>> rfidMapping = new List<KeyValuePair<string, string>>
            {
                // Clubs (k)
                new KeyValuePair<string, string>("2c", "k2"), // 2 of Clubs
                new KeyValuePair<string, string>("3c", "k3"), // 3 of Clubs
                new KeyValuePair<string, string>("", "k4"), // 4 of Clubs
                new KeyValuePair<string, string>("", "k5"), // 5 of Clubs
                new KeyValuePair<string, string>("", "k6"), // 6 of Clubs
                new KeyValuePair<string, string>("", "k7"), // 7 of Clubs
                new KeyValuePair<string, string>("", "k8"), // 8 of Clubs
                new KeyValuePair<string, string>("", "k9"), // 9 of Clubs
                new KeyValuePair<string, string>("", "k4"), // 10 of Clubs
                new KeyValuePair<string, string>("", "kj"), // Jack of Clubs
                new KeyValuePair<string, string>("", "kq"), // Queen of Clubs
                new KeyValuePair<string, string>("", "kk"), // King of Clubs
                new KeyValuePair<string, string>("", "ka"), // Ace of Clubs

                // Diamonds (l)
                new KeyValuePair<string, string>("", "l2"), // 2 of Diamonds
                new KeyValuePair<string, string>("", "l3"), // 3 of Diamonds
                new KeyValuePair<string, string>("", "l4"), // 4 of Diamonds
                new KeyValuePair<string, string>("", "l5"), // 5 of Diamonds
                new KeyValuePair<string, string>("", "l6"), // 6 of Diamonds
                new KeyValuePair<string, string>("", "l7"), // 7 of Diamonds
                new KeyValuePair<string, string>("", "l8"), // 8 of Diamonds
                new KeyValuePair<string, string>("", "l9"), // 9 of Diamonds
                new KeyValuePair<string, string>("", "l4"), // 10 of Diamonds
                new KeyValuePair<string, string>("", "lj"), // Jack of Diamonds
                new KeyValuePair<string, string>("", "lq"), // Queen of Diamonds
                new KeyValuePair<string, string>("", "lk"), // King of Diamonds
                new KeyValuePair<string, string>("", "la"), // Ace of Diamonds

                // Spades (p)
                new KeyValuePair<string, string>("", "p2"), // 2 of Spades
                new KeyValuePair<string, string>("", "p3"), // 3 of Spades
                new KeyValuePair<string, string>("", "p4"), // 4 of Spades
                new KeyValuePair<string, string>("", "p5"), // 5 of Spades
                new KeyValuePair<string, string>("", "p6"), // 6 of Spades
                new KeyValuePair<string, string>("", "p7"), // 7 of Spades
                new KeyValuePair<string, string>("", "p8"), // 8 of Spades
                new KeyValuePair<string, string>("", "p9"), // 9 of Spades
                new KeyValuePair<string, string>("", "p4"), // 10 of Spades
                new KeyValuePair<string, string>("", "pj"), // Jack of Spades
                new KeyValuePair<string, string>("", "pq"), // Queen of Spades
                new KeyValuePair<string, string>("", "pk"), // King of Spades
                new KeyValuePair<string, string>("", "pa"), // Ace of Spades

                // Hearts (s)
                new KeyValuePair<string, string>("", "s2"), // 2 of Hearts
                new KeyValuePair<string, string>("", "s3"), // 3 of Hearts
                new KeyValuePair<string, string>("", "s4"), // 4 of Hearts
                new KeyValuePair<string, string>("", "s5"), // 5 of Hearts
                new KeyValuePair<string, string>("", "s6"), // 6 of Hearts
                new KeyValuePair<string, string>("", "s7"), // 7 of Hearts
                new KeyValuePair<string, string>("", "s8"), // 8 of Hearts
                new KeyValuePair<string, string>("", "s9"), // 9 of Hearts
                new KeyValuePair<string, string>("", "s4"), // 10 of Hearts
                new KeyValuePair<string, string>("", "sj"), // Jack of Hearts
                new KeyValuePair<string, string>("", "sq"), // Queen of Hearts
                new KeyValuePair<string, string>("", "sk"), // King of Hearts
                new KeyValuePair<string, string>("", "sa") // Ace of Hearts
            };

            return rfidMapping;
        }
    }
}
