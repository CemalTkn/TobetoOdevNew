﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirstName=="CEMAL"
                &&gamer.LastName=="TAŞKIN"&&gamer.IdentityNum==12345)
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
