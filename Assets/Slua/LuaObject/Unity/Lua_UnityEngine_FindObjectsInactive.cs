using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_FindObjectsInactive : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.FindObjectsInactive");
		addMember(l,0,"Exclude");
		addMember(l,1,"Include");
		LuaDLL.lua_pop(l, 1);
	}
}
