using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PeopleLibrary
    {
        private static List<People> ListUsers = new List<People>();

        public static void RegisterUser(People people)
        {
            if (people != null)
                ListUsers.Add(people);
        }

        public static List<People> SearchUsers(string search)
        {
            List<People> user = new List<People>();
            foreach (var people in ListUsers)
            {
                if (people.Name.Contains(search) || people.Surname.Contains(search))
                    user.Add(people);
            }
            return user;
        }

        public static string DisplayRegisteredData(People people)
        {
            string personalData = $"\nNOME COMPLETO:: {people.Name} {people.Surname}" +
                $"\nDATA DE NASCIMENTO: {people.BirthDate.ToString("d")}" +
                $"\nFALTAM:: {people.CalculateNextBirthdayDate()} dias para seu próximo aniversário";
            return personalData;
        }
    }
}
