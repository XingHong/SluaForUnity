using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CompressionLevel : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CompressionLevel");
		addMember(l,0,"None");
		addMember(l,1,"Fastest");
		addMember(l,2,"Fast");
		addMember(l,3,"Normal");
		addMember(l,4,"High");
		addMember(l,5,"Maximum");
		LuaDLL.lua_pop(l, 1);
	}
}
