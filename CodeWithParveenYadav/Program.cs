using CodeWithParveenYadav.DesignPattern;
using CodeWithParveenYadav.DesignPattern.Specification;
using CodeWithParveenYadav.Interfaces;
using CodeWithParveenYadav.Models;
using CodeWithParveenYadav.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWithParveenYadav
{
    public class Program
    {
        static void Main(string[] args)
        {

            var users = GetUsers();

            var userSpecification = new UserSpecification();

            if(userSpecification.IsSatisfiedBy(users.First()))
            {
                //
            }


        }

        static List<UserModel> GetUsers()
        {
            return new List<UserModel>()
             {
                   new UserModel { FirstName = "Parveen", LastName = "Yadav", FullName = "Parveen Yadav", Age = 20, Gender = "M" },
                   new UserModel { FirstName = "Vikas", LastName = "Yadav", FullName = "Vikas Yadav", Age = 20, Gender = "M"  },
                   new UserModel { FirstName = "Chandan", LastName = "Yadav", FullName = "Chandan Yadav", Age = 10, Gender = "M"  }
             };
        }

        internal class UserModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
        }
    }
}
