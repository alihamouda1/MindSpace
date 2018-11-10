using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;


namespace DATA
{
  public  class MyContext : IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {


        
        public static MyContext Create()
        {
            return new MyContext();
        }

        static MyContext()
        {
            Database.SetInitializer<MyContext>(null);
        }

        public MyContext() : base("name=EpioneDB")
        {

        }


 
    

    }
}
