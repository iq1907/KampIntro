using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        private IUserValidateService _userValidateService;

        public GamerManager(IUserValidateService userValidateService)
        {
            _userValidateService = userValidateService;
        }

        public void Add(Gamer gamer)
        {

            Console.WriteLine("Kullanıcı Eklendi");
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Updated(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public bool Validate(Gamer gamer)
        {
            if (_userValidateService.Validate(gamer))
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
