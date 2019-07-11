using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class EagerLoading
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();
            foreach (City cobj in db.Cities.Include("Areas"))
            {
                Console.WriteLine("{0}\t{1}", cobj.CityId, cobj.CityName);
                foreach (Area aobj in cobj.Areas)
                {
                    Console.WriteLine(aobj.AreaName);
                }
            }
            Console.ReadLine();
        }
    }
}
