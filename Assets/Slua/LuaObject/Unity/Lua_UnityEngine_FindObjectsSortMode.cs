using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_FindObjectsSortMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.FindObjectsSortMode");
		addMember(l,0,"None");
		addMember(l,1,"InstanceID");
		LuaDLL.lua_pop(l, 1);
	}
}
