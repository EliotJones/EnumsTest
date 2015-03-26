namespace EnumsTest.Entities
{
    using System;
    using System.Collections.Generic;

    public class Owner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Born { get; set; }

        public ICollection<BonsaiTree> Trees { get; set; }
    }
}
