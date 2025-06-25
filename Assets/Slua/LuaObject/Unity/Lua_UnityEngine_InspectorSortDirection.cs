using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_InspectorSortDirection : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.InspectorSortDirection");
		addMember(l,0,"Ascending");
		addMember(l,1,"Descending");
		LuaDLL.lua_pop(l, 1);
	}
}
