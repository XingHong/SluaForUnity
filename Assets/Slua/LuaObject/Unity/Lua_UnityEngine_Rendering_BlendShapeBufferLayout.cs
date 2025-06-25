using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BlendShapeBufferLayout : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BlendShapeBufferLayout");
		addMember(l,0,"PerShape");
		addMember(l,1,"PerVertex");
		LuaDLL.lua_pop(l, 1);
	}
}
