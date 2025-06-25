using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ArticulationDriveAxis : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ArticulationDriveAxis");
		addMember(l,0,"X");
		addMember(l,1,"Y");
		addMember(l,2,"Z");
		LuaDLL.lua_pop(l, 1);
	}
}
