﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_SimulationMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.SimulationMode");
		addMember(l,0,"FixedUpdate");
		addMember(l,1,"Update");
		addMember(l,2,"Script");
		LuaDLL.lua_pop(l, 1);
	}
}
