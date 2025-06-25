using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_TransferFunction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TransferFunction");
		addMember(l,0,"sRGB");
		addMember(l,1,"BT1886");
		addMember(l,2,"PQ");
		addMember(l,3,"Linear");
		addMember(l,4,"Gamma22");
		addMember(l,-1,"Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
