using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Profiling_Memory_MemoryProfiler : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TakeSnapshot_s(IntPtr l) {
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.Action<System.String,System.Boolean> a2;
				checkDelegate(l,2,out a2);
				Unity.Profiling.Memory.CaptureFlags a3;
				a3 = (Unity.Profiling.Memory.CaptureFlags)LuaDLL.luaL_checkinteger(l, 3);
				Unity.Profiling.Memory.MemoryProfiler.TakeSnapshot(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				System.String a1;
				checkType(l,1,out a1);
				System.Action<System.String,System.Boolean> a2;
				checkDelegate(l,2,out a2);
				System.Action<System.String,System.Boolean,Unity.Profiling.DebugScreenCapture> a3;
				checkDelegate(l,3,out a3);
				Unity.Profiling.Memory.CaptureFlags a4;
				a4 = (Unity.Profiling.Memory.CaptureFlags)LuaDLL.luaL_checkinteger(l, 4);
				Unity.Profiling.Memory.MemoryProfiler.TakeSnapshot(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function TakeSnapshot to call");
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TakeTempSnapshot_s(IntPtr l) {
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
			System.Action<System.String,System.Boolean> a1;
			checkDelegate(l,1,out a1);
			Unity.Profiling.Memory.CaptureFlags a2;
			a2 = (Unity.Profiling.Memory.CaptureFlags)LuaDLL.luaL_checkinteger(l, 2);
			Unity.Profiling.Memory.MemoryProfiler.TakeTempSnapshot(a1,a2);
			pushValue(l,true);
			return 1;
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
		getTypeTable(l,"Unity.Profiling.Memory.MemoryProfiler");
		addMember(l,TakeSnapshot_s);
		addMember(l,TakeTempSnapshot_s);
		createTypeMetatable(l,null, typeof(Unity.Profiling.Memory.MemoryProfiler));
	}
}
