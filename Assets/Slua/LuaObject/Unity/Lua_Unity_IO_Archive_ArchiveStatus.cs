using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_IO_Archive_ArchiveStatus : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"Unity.IO.Archive.ArchiveStatus");
		addMember(l,0,"InProgress");
		addMember(l,1,"Complete");
		addMember(l,2,"Failed");
		LuaDLL.lua_pop(l, 1);
	}
}
