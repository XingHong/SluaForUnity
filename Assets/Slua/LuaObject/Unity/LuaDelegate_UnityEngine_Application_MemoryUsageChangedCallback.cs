
using System;
using System.Collections.Generic;
namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal void Lua_UnityEngine_Application_MemoryUsageChangedCallback(LuaFunction ld ,ref UnityEngine.ApplicationMemoryUsageChange a1) {
            IntPtr l = ld.L;
            int error = pushTry(l);

			pushValue(l,a1);
			ld.pcall(1, error);
			checkValueType(l,error+1,out a1);
			LuaDLL.lua_settop(l, error-1);
		}
	}
}
