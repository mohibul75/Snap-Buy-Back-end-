using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerApp.Model;

namespace ServerApp.Repository
{
    public class AdminRepository : DatabaseRepository
    {
        public Admin Add(Admin admin)
        {
            //if (admin != null)
          //  {
                DatabaseContext.Admin.Add(admin);
                DatabaseContext.SaveChanges();
                return admin;
          //  }

        //    var obj = new Admin();

       //     return obj;

        }

        public List<Admin> GetAll()
        {
            return DatabaseContext.Admin.ToList();
        }

        public Admin GetById(int adminId)
        {
            return DatabaseContext.Admin.SingleOrDefault(admin => admin.id == adminId);
        }

        public Admin Update(Admin admin)
        {
            DatabaseContext.Admin.Update(admin);
            DatabaseContext.SaveChanges();
            return admin;
        }

        public bool Delete(Admin admin)
        {
            DatabaseContext.Admin.Remove(admin);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
