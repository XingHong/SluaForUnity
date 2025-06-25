using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WhitePoint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WhitePoint");
		addMember(l,0,"D65");
		addMember(l,-1,"Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
