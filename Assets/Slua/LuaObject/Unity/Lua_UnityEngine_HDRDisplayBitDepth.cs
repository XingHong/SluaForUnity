using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_HDRDisplayBitDepth : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.HDRDisplayBitDepth");
		addMember(l,0,"BitDepth10");
		addMember(l,1,"BitDepth16");
		LuaDLL.lua_pop(l, 1);
	}
}
