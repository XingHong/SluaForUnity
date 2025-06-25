using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CompressionType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CompressionType");
		addMember(l,0,"None");
		addMember(l,1,"Lzma");
		addMember(l,2,"Lz4");
		addMember(l,3,"Lz4HC");
		LuaDLL.lua_pop(l, 1);
	}
}
