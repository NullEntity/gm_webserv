using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;
using GarrysMod.Lua;
using GarrysMod.Lua.Interface;


namespace gmsv_webserv
{
    public static class WebServ
    {
        [DllExport("gmod13_open", CallingConvention = CallingConvention.Cdecl)]
        static int ModuleOpen(lua_State state)
        {
            ILuaBase LUA = state.luabase;

            LUA.PushSpecial(Special.SPECIAL_GLOB);
                LUA.PushCFunction(HelloWorld);
                LUA.SetField(-2, "HelloWorld");
            LUA.Pop();

            return 0;
        }

        [DllExport("gmod13_close", CallingConvention = CallingConvention.Cdecl)]
        static int ModuleClose(lua_State state)
        {
            return 0;
        }

        static int HelloWorld(lua_State state)
        {
            ILuaBase LUA = state.luabase;
            LUA.PushString("Hello World!");
            return 1;
        }
    }
}
