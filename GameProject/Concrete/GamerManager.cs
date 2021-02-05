using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerSevice
    {
        //MicroSevice projenin içinde başka bir sevis kullanma

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer deleted.:" + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }

        public void Save(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer saved." +" "+ gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
           
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer updated." + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
           
        }
    }
}
