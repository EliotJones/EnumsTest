namespace EnumsTest
{
    public class Genus : Enumeration
    {
        public static readonly Genus Leafy = new Genus(0, "Leafy");

        public static readonly Genus Twiggy = new Genus(1, "Twiggy");

        private Genus() { }

        private Genus(int value, string displayName) : base(value, displayName) { }
    }
}
