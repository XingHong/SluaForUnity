﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_PlayerLoop_PreLateUpdate_PhysicsLateUpdate : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			#if UNITY_5_5_OR_NEWER
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#else
			Profiler.BeginSample(methodName);
			#endif
			#endif
			UnityEngine.PlayerLoop.PreLateUpdate.PhysicsLateUpdate o;
			o=new UnityEngine.PlayerLoop.PreLateUpdate.PhysicsLateUpdate();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			#if UNITY_5_5_OR_NEWER
			UnityEngine.Profiling.Profiler.EndSample();
			#else
			Profiler.EndSample();
			#endif
		}
		#endif
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlayerLoop.PreLateUpdate.PhysicsLateUpdate");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlayerLoop.PreLateUpdate.PhysicsLateUpdate),typeof(System.ValueType));
	}
}
