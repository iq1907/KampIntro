using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidateManager : IUserValidateService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
