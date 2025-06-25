using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ColorPrimaries : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ColorPrimaries");
		addMember(l,0,"Rec709");
		addMember(l,1,"Rec2020");
		addMember(l,2,"P3");
		addMember(l,-1,"Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
