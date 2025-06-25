using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchCullingProjectionType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BatchCullingProjectionType");
		addMember(l,0,"Unknown");
		addMember(l,1,"Perspective");
		addMember(l,2,"Orthographic");
		LuaDLL.lua_pop(l, 1);
	}
}
