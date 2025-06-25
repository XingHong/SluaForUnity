using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_JointBreakAction2D : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.JointBreakAction2D");
		addMember(l,0,"Ignore");
		addMember(l,1,"CallbackOnly");
		addMember(l,2,"Disable");
		addMember(l,3,"Destroy");
		LuaDLL.lua_pop(l, 1);
	}
}
