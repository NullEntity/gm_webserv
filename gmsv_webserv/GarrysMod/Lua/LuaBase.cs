using GarrysMod.Lua;
using GarrysMod.Lua.Interface;

namespace GarrysMod.Lua
{
    interface ILuaBase
    {
        int Top();
        void Push(int StackPos);
        void Pop(int Amt = 1);
        void GetTable(int StackPos);
        void GetField(int StackPos, string Name);
        void SetField(int StackPos, string Name);
        void CreateTable();
        void SetTable(int i);
        void SetMetaTable(int i);
        bool GetMetaTable(int i);
        void Call(int Args, int Results);
        int PCall(int Args, int Results, int ErrorFunc);
        int Equal(int A, int B);
        int RawEqual(int A, int B);
        void Insert(int StackPos);
        void Remove(int StackPos);
        int Next(int StackPos);
        UserData NewUserdata(uint Size);
        void ThrowError(string Error);
        void CheckType(int StackPos, int Type);
        void ArgError(int ArgNum, string Message);
        void RawGet(int StackPos);
        void RawSet(int StackPos);
        
        string GetString(int StackPos = -1, uint OutLen = 0);
        double GetNumber(int StackPos = -1);
        bool GetBool(int StackPos = -1);
        CFunc GetCFunction(int StackPos = -1);
        UserData GetUserdata(int StackPos = -1);

        void PushNil();
        void PushString(string Val, uint Len = 0);
        void PushNumber(double Val);
        void PushBool(bool Val);
        void PushCFunction(CFunc Val);
        void PushCClosure(CFunc Val, int Vars);
        void PushUserdata(UserData Val);

        int ReferenceCreate();
        void ReferenceFree(int i);
        void ReferencePush(int i);

        void PushSpecial(int Type);

        bool IsType(int StackPos, int Type);
        int GetType(int StackPos);
        string GetTypeName(int Type);

        void CreateMetaTableType(string Name, int Type);
        string CheckString(int StackPos);
        double CheckNumber(int StackPos);
    }

    static class Special
    {
        public static readonly int SPECIAL_GLOB = 0;
        public static readonly int SPECIAL_ENV = 1;
        public static readonly int SPECIAL_REG = 2;
    }
}
