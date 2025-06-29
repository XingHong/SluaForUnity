﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Object : LuaObject {
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
			UnityEngine.Object o;
			o=new UnityEngine.Object();
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInstanceID(IntPtr l) {
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
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			var ret=self.GetInstanceID();
			pushValue(l,true);
			pushValue(l,ret);
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
	static public int InstantiateAsync_s(IntPtr l) {
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
			if(argc==1){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.InstantiateParameters a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.InstantiateParameters a3;
				checkValueType(l,3,out a3);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(System.ReadOnlySpan<UnityEngine.Vector3>),typeof(System.ReadOnlySpan<UnityEngine.Quaternion>))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.ReadOnlySpan<UnityEngine.Vector3> a3;
				UnityEngine.Vector3[] a3_temp;
				checkArray(l, 3, out a3_temp);
				a3=a3_temp.AsSpan();
				System.ReadOnlySpan<UnityEngine.Quaternion> a4;
				UnityEngine.Quaternion[] a4_temp;
				checkArray(l, 4, out a4_temp);
				a4=a4_temp.AsSpan();
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.InstantiateParameters a4;
				checkValueType(l,4,out a4);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(UnityEngine.Transform),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(UnityEngine.Transform),typeof(System.ReadOnlySpan<UnityEngine.Vector3>),typeof(System.ReadOnlySpan<UnityEngine.Quaternion>))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				System.ReadOnlySpan<UnityEngine.Vector3> a4;
				UnityEngine.Vector3[] a4_temp;
				checkArray(l, 4, out a4_temp);
				a4=a4_temp.AsSpan();
				System.ReadOnlySpan<UnityEngine.Quaternion> a5;
				UnityEngine.Quaternion[] a5_temp;
				checkArray(l, 5, out a5_temp);
				a5=a5_temp.AsSpan();
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				UnityEngine.InstantiateParameters a5;
				checkValueType(l,5,out a5);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(int),typeof(System.ReadOnlySpan<UnityEngine.Vector3>),typeof(System.ReadOnlySpan<UnityEngine.Quaternion>),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.ReadOnlySpan<UnityEngine.Vector3> a3;
				UnityEngine.Vector3[] a3_temp;
				checkArray(l, 3, out a3_temp);
				a3=a3_temp.AsSpan();
				System.ReadOnlySpan<UnityEngine.Quaternion> a4;
				UnityEngine.Quaternion[] a4_temp;
				checkArray(l, 4, out a4_temp);
				a4=a4_temp.AsSpan();
				UnityEngine.InstantiateParameters a5;
				checkValueType(l,5,out a5);
				var ret=UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function InstantiateAsync to call");
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
	static public int Instantiate_s(IntPtr l) {
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
			if(matchType(l,argc,1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.Instantiate(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.SceneManagement.Scene))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.SceneManagement.Scene a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.Object.Instantiate(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.InstantiateParameters a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Object.Instantiate(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Object.Instantiate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(bool))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Object.Instantiate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(bool))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Transform a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Object.Instantiate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.InstantiateParameters))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.InstantiateParameters a4;
				checkValueType(l,4,out a4);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Transform a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Instantiate to call");
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
	static public int Destroy_s(IntPtr l) {
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
			if(argc==1){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object.Destroy(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Object.Destroy(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Destroy to call");
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
	static public int DestroyImmediate_s(IntPtr l) {
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
			if(argc==1){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object.DestroyImmediate(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Object.DestroyImmediate(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function DestroyImmediate to call");
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
	static public int FindObjectsOfType_s(IntPtr l) {
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
			if(argc==0){
				var ret=UnityEngine.Object.FindObjectsOfType<UnityEngine.Object>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.FindObjectsOfType(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(bool))){
				System.Boolean a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.FindObjectsOfType<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Type a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Object.FindObjectsOfType(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function FindObjectsOfType to call");
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
	static public int FindObjectsByType_s(IntPtr l) {
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
			if(argc==1){
				UnityEngine.FindObjectsSortMode a1;
				a1 = (UnityEngine.FindObjectsSortMode)LuaDLL.luaL_checkinteger(l, 1);
				var ret=UnityEngine.Object.FindObjectsByType<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(System.Type),typeof(UnityEngine.FindObjectsSortMode))){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.FindObjectsSortMode a2;
				a2 = (UnityEngine.FindObjectsSortMode)LuaDLL.luaL_checkinteger(l, 2);
				var ret=UnityEngine.Object.FindObjectsByType(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.FindObjectsInactive),typeof(UnityEngine.FindObjectsSortMode))){
				UnityEngine.FindObjectsInactive a1;
				a1 = (UnityEngine.FindObjectsInactive)LuaDLL.luaL_checkinteger(l, 1);
				UnityEngine.FindObjectsSortMode a2;
				a2 = (UnityEngine.FindObjectsSortMode)LuaDLL.luaL_checkinteger(l, 2);
				var ret=UnityEngine.Object.FindObjectsByType<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.FindObjectsInactive a2;
				a2 = (UnityEngine.FindObjectsInactive)LuaDLL.luaL_checkinteger(l, 2);
				UnityEngine.FindObjectsSortMode a3;
				a3 = (UnityEngine.FindObjectsSortMode)LuaDLL.luaL_checkinteger(l, 3);
				var ret=UnityEngine.Object.FindObjectsByType(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function FindObjectsByType to call");
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
	static public int DontDestroyOnLoad_s(IntPtr l) {
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
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object.DontDestroyOnLoad(a1);
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FindObjectOfType_s(IntPtr l) {
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
			if(argc==0){
				var ret=UnityEngine.Object.FindObjectOfType<UnityEngine.Object>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(bool))){
				System.Boolean a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.FindObjectOfType<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.FindObjectOfType(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Type a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Object.FindObjectOfType(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function FindObjectOfType to call");
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
	static public int FindFirstObjectByType_s(IntPtr l) {
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
			if(argc==0){
				var ret=UnityEngine.Object.FindFirstObjectByType<UnityEngine.Object>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.FindObjectsInactive))){
				UnityEngine.FindObjectsInactive a1;
				a1 = (UnityEngine.FindObjectsInactive)LuaDLL.luaL_checkinteger(l, 1);
				var ret=UnityEngine.Object.FindFirstObjectByType<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.FindFirstObjectByType(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.FindObjectsInactive a2;
				a2 = (UnityEngine.FindObjectsInactive)LuaDLL.luaL_checkinteger(l, 2);
				var ret=UnityEngine.Object.FindFirstObjectByType(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function FindFirstObjectByType to call");
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
	static public int FindAnyObjectByType_s(IntPtr l) {
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
			if(argc==0){
				var ret=UnityEngine.Object.FindAnyObjectByType<UnityEngine.Object>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.FindObjectsInactive))){
				UnityEngine.FindObjectsInactive a1;
				a1 = (UnityEngine.FindObjectsInactive)LuaDLL.luaL_checkinteger(l, 1);
				var ret=UnityEngine.Object.FindAnyObjectByType<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Object.FindAnyObjectByType(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.FindObjectsInactive a2;
				a2 = (UnityEngine.FindObjectsInactive)LuaDLL.luaL_checkinteger(l, 2);
				var ret=UnityEngine.Object.FindAnyObjectByType(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function FindAnyObjectByType to call");
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
	static public int op_Equality(IntPtr l) {
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
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
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
	static public int op_Inequality(IntPtr l) {
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
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
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
	static public int get_name(IntPtr l) {
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
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
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
	static public int set_name(IntPtr l) {
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
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.name=v;
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hideFlags(IntPtr l) {
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
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.hideFlags);
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
	static public int set_hideFlags(IntPtr l) {
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
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			UnityEngine.HideFlags v;
			v = (UnityEngine.HideFlags)LuaDLL.luaL_checkinteger(l, 2);
			self.hideFlags=v;
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
		getTypeTable(l,"UnityEngine.Object");
		addMember(l,GetInstanceID);
		addMember(l,InstantiateAsync_s);
		addMember(l,Instantiate_s);
		addMember(l,Destroy_s);
		addMember(l,DestroyImmediate_s);
		addMember(l,FindObjectsOfType_s);
		addMember(l,FindObjectsByType_s);
		addMember(l,DontDestroyOnLoad_s);
		addMember(l,FindObjectOfType_s);
		addMember(l,FindFirstObjectByType_s);
		addMember(l,FindAnyObjectByType_s);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"hideFlags",get_hideFlags,set_hideFlags,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Object));
	}
}
