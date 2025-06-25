using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_InspectorSort : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.InspectorSort");
		addMember(l,0,"ByName");
		addMember(l,1,"ByValue");
		LuaDLL.lua_pop(l, 1);
	}
}
