////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Box Brush actor
	/// </summary>
	public sealed partial class BoxBrush : Actor
	{
		/// <summary>
		/// Gets or sets brush surfaces scale in lightmap parameter.
		/// </summary>
		[UnmanagedCall]
		public float UsePerspective
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetScaleInLightmap(unmanagedPtr); }
			set { Internal_SetScaleInLightmap(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets brush size.
		/// </summary>
		[UnmanagedCall]
		public Vector3 Size
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { Vector3 resultAsRef; Internal_GetSize(unmanagedPtr, out resultAsRef); return resultAsRef; }
			set { Internal_SetSize(unmanagedPtr, ref value); }
#endif
		}

		/// <summary>
		/// Gets or sets CSG brush mode.
		/// </summary>
		[UnmanagedCall]
		public BrushMode Mode
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetMode(unmanagedPtr); }
			set { Internal_SetMode(unmanagedPtr, value); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetScaleInLightmap(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetScaleInLightmap(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetSize(IntPtr obj, out Vector3 resultAsRef);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetSize(IntPtr obj, ref Vector3 val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern BrushMode Internal_GetMode(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetMode(IntPtr obj, BrushMode val);
#endif
#endregion
	}
}

