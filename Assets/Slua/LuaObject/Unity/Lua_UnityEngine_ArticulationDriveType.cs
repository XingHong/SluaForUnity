using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ArticulationDriveType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ArticulationDriveType");
		addMember(l,0,"Force");
		addMember(l,1,"Acceleration");
		addMember(l,2,"Target");
		addMember(l,3,"Velocity");
		LuaDLL.lua_pop(l, 1);
	}
}
