using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class AutoChangeTracking
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();

            Area newArea = new Area() { AreaName = "Oxford Street", CityId = 4, Pincode = "123456" };
            db.Areas.Add(newArea);
            Console.WriteLine("After Adding");
            foreach (var tracker in db.ChangeTracker.Entries<Area>())
            {
                Console.WriteLine(tracker.State);
            }



            Area modifiedArea = db.Areas.Find(3);
            if (modifiedArea != null)
            {
                modifiedArea.Pincode = "124522";
           

            Console.WriteLine("After Modification");
            foreach (var tracker in db.ChangeTracker.Entries<Area>())
            {
                Console.WriteLine(tracker.State);
            }
            }

            Area delArea = db.Areas.Find(1);
            if (delArea != null)
            {
                db.Areas.Remove(delArea);
            }


            Console.WriteLine("After Deletion");
            foreach (var tracker in db.ChangeTracker.Entries<Area>())
            {
                Console.WriteLine(tracker.State);
            }
            Console.ReadLine();
        }
    }
}
