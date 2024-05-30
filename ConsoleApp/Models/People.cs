using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class People
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Nationality { get; set; }
        public string? Job { get; set; }
        public string? Interests { get; set; }

        public People() { }
        public People(string sor)
        {
            var a = sor.Split(";");
            Name = a[0];
            Age = Convert.ToInt32(a[1]);
            Nationality = a[2];
            Job = a[3];
            Interests = a[4];
        }

        public override string? ToString()
        {
            return $"Név: {Name}, Életkor: {Age}, Nemzetiség: {Nationality}, Foglalkozás: {Job}, Érdeklődési kör: {Interests}";
        }
    }
}