using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_FoveatedRenderingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.FoveatedRenderingMode");
		addMember(l,0,"Disabled");
		addMember(l,1,"Enabled");
		LuaDLL.lua_pop(l, 1);
	}
}
