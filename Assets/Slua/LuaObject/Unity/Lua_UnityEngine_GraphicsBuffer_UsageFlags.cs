using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_GraphicsBuffer_UsageFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.GraphicsBuffer.UsageFlags");
		addMember(l,0,"None");
		addMember(l,1,"LockBufferForWrite");
		LuaDLL.lua_pop(l, 1);
	}
}
