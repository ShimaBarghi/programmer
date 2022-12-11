using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyContacts2.Models;

namespace MyContacts2.Models
{
    public static class Repository
    {
        public static List<Person> people = new List<Person>() {
            new Person(){ID=1,FullName="elmira arjmand",Email="elmira@yahoo.com",Website="Toplearn.com",Mobail="09306438379" },
            new Person(){ID=2,FullName="setareh rezaei",Email="setareh@yahoo.com",Website="yalleoo.com",Mobail="09356438379" },
            new Person(){ID=3,FullName="mona bahrami",Email="mona@yahoo.com",Website="barnamenevisan.com",Mobail="09366438379" },
        };
        
        
        
            
        

    }
}