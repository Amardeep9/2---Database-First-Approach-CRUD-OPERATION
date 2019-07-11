using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class CRUD
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();
            Area areaObj = new Area();

            int opt, id;
            do
            {
                Console.WriteLine("1:New Record\n 2:Display\n3:Update Record \n4:Delete Record\n 5:Exit");
                Console.Write("Enter Your Option");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:// add new Record
                        Console.WriteLine("Enter Area Name, CityId and Pincode:");
                        areaObj.AreaName = Console.ReadLine();
                        areaObj.CityId = Convert.ToInt32(Console.ReadLine());
                        areaObj.Pincode= Console.ReadLine();

                        db.Areas.Add(areaObj);
                        db.SaveChanges();

                        break;

                    case 2:// read all Records

                    

                        foreach(Area a in db.SelectArea())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", a.AreaId, a.AreaName, a.Pincode,a.City.CityName);
                        }
                        break;

                    case 3:// update Records
                        Console.Write("Enter Id to Update:");
                        id = Convert.ToInt32(Console.ReadLine());
                        areaObj=db.Areas.Find(id);
                        if (areaObj == null)
                        {
                            Console.WriteLine("Invalid Area Id, Try Again");
                        }
                        else
                            {
                                Console.WriteLine("Enter Modified  Area Name, CityId and Pincode:");
                                areaObj.AreaName = Console.ReadLine();
                                areaObj.CityId = Convert.ToInt32(Console.ReadLine());
                                areaObj.Pincode = Console.ReadLine();
                                db.SaveChanges();

                            }
                        
                        break;

                    case 4:// delete Records
                        Console.Write("Enter Id to Delete:");
                        id = Convert.ToInt32(Console.ReadLine());
                        areaObj = db.Areas.Find(id);
                        if (areaObj == null)
                        { 
                            Console.WriteLine("Invalid Area Id, Try Again");
                        }
                        else
                        {
                            db.Areas.Remove(areaObj);
                            db.SaveChanges();
                        }
                        break;

                    case 5:break;
                    default:Console.WriteLine("Invalid Option ");break;
                }
            }while(opt!=5);
        }
    }
}

