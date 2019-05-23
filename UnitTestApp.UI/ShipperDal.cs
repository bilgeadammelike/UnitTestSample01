using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestApp.UI.Model;

namespace UnitTestApp.UI
{
    public class ShipperDal
    {
        public List<Shippers> Select()
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Shippers.ToList();
        }

        public int Insert(Shippers s)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            db.Shippers.Add(s);
            return db.SaveChanges();
        }
    }
}
