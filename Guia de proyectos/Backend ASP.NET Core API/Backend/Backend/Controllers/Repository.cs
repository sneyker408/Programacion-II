using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Backend.Controllers
{
    public class Repository
    {
        public static List<PersonaDatos> persona = new List<PersonaDatos> {
        new PersonaDatos()
        {
            id = 1,
            age = new DateTime(1994,08,03),
            name = "Erick Diaz"
        },
        new PersonaDatos()
        {
            id = 2,
            age = new DateTime(1994, 09, 03),
            name = "Erick Diaz"
        },
        new PersonaDatos()
        {
            id = 3,
            age = new DateTime(1994, 11, 03),
            name = "xd"
        }

        };
    }
    public class PersonaDatos
    {

        public int id { get; set; }
        public string name { get; set; }
        public DateTime age { get; set; }

    }
}
