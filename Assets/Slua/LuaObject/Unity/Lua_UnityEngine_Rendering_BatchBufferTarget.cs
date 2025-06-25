using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchBufferTarget : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BatchBufferTarget");
		addMember(l,0,"Unknown");
		addMember(l,1,"RawBuffer");
		addMember(l,2,"ConstantBuffer");
		addMember(l,-1,"UnsupportedByUnderlyingGraphicsApi");
		LuaDLL.lua_pop(l, 1);
	}
}
