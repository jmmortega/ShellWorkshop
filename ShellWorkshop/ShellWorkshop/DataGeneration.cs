using System;
using System.Collections.Generic;
using System.Text;

namespace ShellWorkshop
{
    public static class DataGeneration
    {
        public static List<Actor> CreateActors()
        {
            var rnd = new Random();
            var actors = new List<Actor>();
            for(int i = 0; i < 100; i ++)
            {                
                actors.Add(new Actor()
                {
                    Name = GenerateName(rnd.Next(10)),
                    ImageUrl = $"https://randomuser.me/api/portraits/thumb/men/{i +1}.jpg"
                });
                
            }
            return actors;
        }

        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
    }
}
