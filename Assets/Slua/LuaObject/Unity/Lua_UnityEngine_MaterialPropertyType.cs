using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MaterialPropertyType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.MaterialPropertyType");
		addMember(l,0,"Float");
		addMember(l,1,"Int");
		addMember(l,2,"Vector");
		addMember(l,3,"Matrix");
		addMember(l,4,"Texture");
		addMember(l,5,"ConstantBuffer");
		addMember(l,6,"ComputeBuffer");
		LuaDLL.lua_pop(l, 1);
	}
}
