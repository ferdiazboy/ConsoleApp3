using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Ferdi"&& gamer.LastName=="Azboy"
                &&gamer.BirthYear==1989&&gamer.NationalityId==111111)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
