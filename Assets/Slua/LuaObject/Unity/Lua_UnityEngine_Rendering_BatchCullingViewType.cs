using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchCullingViewType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BatchCullingViewType");
		addMember(l,0,"Unknown");
		addMember(l,1,"Camera");
		addMember(l,2,"Light");
		addMember(l,3,"Picking");
		addMember(l,4,"SelectionOutline");
		LuaDLL.lua_pop(l, 1);
	}
}
