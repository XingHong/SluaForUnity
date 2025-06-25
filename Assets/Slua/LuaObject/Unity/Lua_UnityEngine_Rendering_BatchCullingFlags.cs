using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchCullingFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BatchCullingFlags");
		addMember(l,0,"None");
		addMember(l,1,"CullLightmappedShadowCasters");
		LuaDLL.lua_pop(l, 1);
	}
}
