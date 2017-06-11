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
	/// Skybox actor can render sky using custom cube texture or material
	/// </summary>
	public sealed partial class Skybox : Actor
	{
		/// <summary>
		/// Gets or sets value indicating if visual element affects the world
		/// </summary>
		[UnmanagedCall]
		public bool AffectsWorld
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetAffectsWorld(unmanagedPtr); }
			set { Internal_SetAffectsWorld(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets skybox color
		/// </summary>
		[UnmanagedCall]
		public Color Color
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { Color resultAsRef; Internal_GetColor(unmanagedPtr, out resultAsRef); return resultAsRef; }
			set { Internal_SetColor(unmanagedPtr, ref value); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetAffectsWorld(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetAffectsWorld(IntPtr obj, bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetColor(IntPtr obj, out Color resultAsRef);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetColor(IntPtr obj, ref Color val);
#endif
#endregion
	}
}

