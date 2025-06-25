using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AudioSpatialExperience : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AudioSpatialExperience");
		addMember(l,0,"Bypassed");
		addMember(l,1,"HeadTracked");
		addMember(l,2,"Fixed");
		LuaDLL.lua_pop(l, 1);
	}
}
