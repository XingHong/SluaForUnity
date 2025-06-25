using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ApplicationMemoryUsage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ApplicationMemoryUsage");
		addMember(l,0,"Unknown");
		addMember(l,1,"Low");
		addMember(l,2,"Medium");
		addMember(l,3,"High");
		addMember(l,4,"Critical");
		LuaDLL.lua_pop(l, 1);
	}
}
