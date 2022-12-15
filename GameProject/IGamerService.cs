using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService
    {
        bool Validate(Gamer gamer);
        void Add(Gamer gamer);
        void Updated(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
