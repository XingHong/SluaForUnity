using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_LightProbeOutsideHullStrategy : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.LightProbeOutsideHullStrategy");
		addMember(l,0,"kLightProbeSearchTetrahedralHull");
		addMember(l,1,"kLightProbeUseAmbientProbe");
		LuaDLL.lua_pop(l, 1);
	}
}
