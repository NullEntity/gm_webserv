#if ENTITY
#undef ENTITY
#endif 

#if VECTOR
#undef VECTOR
#endif 

using System;

namespace GarrysMod.Lua
{
    class Type
    {
        // Lua types
        public static readonly int INVALID = -1;
        public static readonly int NIL = 0;
        public static readonly int BOOL = 1;
        public static readonly int LIGHTUSERDATA = 2;
        public static readonly int NUMBER = 3;
        public static readonly int STRING = 4;
        public static readonly int TABLE = 5;
        public static readonly int FUNCTION = 6;
        public static readonly int USERDATA = 7;
        public static readonly int THREAD = 8;

        // UserData types
        public static readonly int ENTITY = 9;
        public static readonly int VECTOR = 10;
        public static readonly int ANGLE = 11;
        public static readonly int PHYSOBJ = 12;
        public static readonly int SAVE = 13;
        public static readonly int RESTORE = 14;
        public static readonly int DAMAGEINFO = 15;
        public static readonly int EFFECTDATA = 16;
        public static readonly int MOVEDATA = 17;
        public static readonly int RECIPIENTFILTER = 18;
        public static readonly int USERCMD = 17;
        public static readonly int SCRIPTEDVEHICLE = 18;

        // Client types
        public static readonly int MATERIAL = 19;
        public static readonly int PANEL = 20;
        public static readonly int PARTICLE = 21;
        public static readonly int PARTICLEEMITTER = 22;
        public static readonly int TEXTURE = 23;
        public static readonly int USERMSG = 24;

        public static readonly int CONVAR = 25;
        public static readonly int IMESH = 26;
        public static readonly int MATRIX = 27;
        public static readonly int SOUND = 28;
        public static readonly int PIXELVISHANDLE = 29;
        public static readonly int DLIGHT = 30;
        public static readonly int VIDEO = 31;
        public static readonly int FILE = 32;

        public static readonly int COUNT = 33;

        public static readonly String[] Name = {
            "nil",
            "bool",
            "lightuserdata",
            "number",
            "string",
            "table",
            "function",
            "userdata",
            "thread",

            "entity",
            "vector",
            "angle",
            "physobj",
            "save",
            "restore",
            "damageinfo",
            "effectdata",
            "movedata",
            "recipientfilter",
            "usercmd",
            "vehicle",

            "material",
            "panel",
            "particle",
            "particleemitter",
            "texture",
            "usermsg",

            "convar",
            "mesh",
            "matrix",
            "sound",
            "pixelvishandle",
            "dlight",
            "video",
            "file",

            ""
        };
    }
}
