using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_TextureMipmapLimitBiasMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TextureMipmapLimitBiasMode");
		addMember(l,0,"OffsetGlobalLimit");
		addMember(l,1,"OverrideGlobalLimit");
		LuaDLL.lua_pop(l, 1);
	}
}
