using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarrysMod.Lua;
using GarrysMod.Lua.Interface;

namespace GarrysMod.Lua.Interface
{
    unsafe struct lua_State
    {
       public fixed byte _header[69];
       public ILuaBase luabase;
    }

    delegate int CFunc(lua_State L);
}
