using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CustomMarkerCallbackFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.CustomMarkerCallbackFlags");
		addMember(l,0,"CustomMarkerCallbackDefault");
		addMember(l,4,"CustomMarkerCallbackForceInvalidateStateTracking");
		LuaDLL.lua_pop(l, 1);
	}
}
