namespace EnumsTest.Entities
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class BonsaiTree
    {
        private BonsaiTree()
        {
            this.Owners = new List<Owner>();
        }

        public int Id { get; private set; }

        private string Name { get; set; }

        public Genus Genus { get; private set; }

        private IList<Owner> Owners { get; set; }

        public ICollection<Owner> Ownerss 
        { 
            get
            {
                return new ReadOnlyCollection<Owner>(Owners);
            }            
        }
    }
}
