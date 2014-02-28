using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarrysMod.Lua
{
    unsafe struct UserData
    {
        void* data;
        byte type;
    }
}
