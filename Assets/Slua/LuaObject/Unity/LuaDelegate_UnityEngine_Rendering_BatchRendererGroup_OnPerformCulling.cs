﻿
using System;
using System.Collections.Generic;
namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal Unity.Jobs.JobHandle Lua_UnityEngine_Rendering_BatchRendererGroup_OnPerformCulling(LuaFunction ld ,UnityEngine.Rendering.BatchRendererGroup a1,UnityEngine.Rendering.BatchCullingContext a2,UnityEngine.Rendering.BatchCullingOutput a3,System.IntPtr a4) {
            IntPtr l = ld.L;
            int error = pushTry(l);

			pushValue(l,a1);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			ld.pcall(4, error);
			Unity.Jobs.JobHandle ret;
			checkValueType(l,error+1,out ret);
			LuaDLL.lua_settop(l, error-1);
			return ret;
		}
	}
}
