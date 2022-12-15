using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 2;

            GamerManager gamerManager = new GamerManager(new UserValidateManager());
            var vValidate = gamerManager.Validate(gamer1);
            if (vValidate)
            {
                Console.WriteLine("Doğrulama Yapıldı");
                gamerManager.Add(gamer1);
            }

        }
    }
}
