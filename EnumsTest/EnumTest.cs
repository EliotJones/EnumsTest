namespace EnumsTest
{
    using EnumsTest.Entities;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Diagnostics;
    using System.Linq;

    public class EnumTest
    {
        public static void Main(string[] args)
        {
            var db = new EntityContext();

            db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

            //var trees = db.BonsaiTrees.Include().ToList();
            var trees = db.BonsaiTrees.Include("Owners").ToList();

            var tres = db.BonsaiTrees.Where(t => t.Ownerss.Count > 0).ToList();

            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
        }
    }
}
