// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Renders model on the screen.
    /// </summary>
    [Serializable]
    public sealed partial class StaticModel : Actor
    {
        /// <summary>
        /// Creates new <see cref="StaticModel"/> object.
        /// </summary>
        private StaticModel() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="StaticModel"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static StaticModel New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(StaticModel)) as StaticModel;
#endif
        }

        /// <summary>
        /// Gets or sets model scale in lightmap parameter.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(10), DefaultValue(1.0f), EditorDisplay("Model", "Scale In Lightmap"), Tooltip("Model meshes master scale in lightmap"), Limit(0, 1000.0f, 0.1f)]
        public float ScaleInLightmap
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetScaleInLightmap(unmanagedPtr); }
            set { Internal_SetScaleInLightmap(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the model bounds scale. It is useful when using Position Offset to animate the vertices of the object outside of its bounds.
        /// </summary>
        /// <remarks>
        /// Increasing the bounds of an object will reduce performance and shadow quality.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(12), DefaultValue(1.0f), EditorDisplay("Model"), Tooltip("Model bounds scale parameter. It is useful when using Position Offset to animate the vertices of the object outside of its bounds."), Limit(0, 10.0f, 0.1f)]
        public float BoundsScale
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetBoundsScale(unmanagedPtr); }
            set { Internal_SetBoundsScale(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the draw passes to use for rendering this object.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(15), DefaultValue(DrawPass.Default), EditorDisplay("Model"), Tooltip("The draw passes to use for rendering this object.")]
        public DrawPass DrawModes
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDrawModes(unmanagedPtr); }
            set { Internal_SetDrawModes(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets model asset to draw.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(20), DefaultValue(null), EditorDisplay("Model"), Tooltip("Model asset to draw")]
        public Model Model
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetModel(unmanagedPtr); }
            set { Internal_SetModel(unmanagedPtr, FlaxEngine.Object.GetUnmanagedPtr(value)); }
#endif
        }

        /// <summary>
        /// Gets or sets the model Level Of Detail bias value. Allows to increase or decrease rendered model quality.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(40), DefaultValue(0), Limit(-100, 100, 0.1f), EditorDisplay("Model", "LOD Bias"), Tooltip("Model Level Of Detail bias value. Allows to increase or decrease rendered model quality.")]
        public int LODBias
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetLODBias(unmanagedPtr); }
            set { Internal_SetLODBias(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the model forced Level Of Detail index. Allows to bind the given model LOD to show. Value -1 disables this feature.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(50), DefaultValue(-1), Limit(-1, 100, 0.1f), EditorDisplay("Model", "Forced LOD"), Tooltip("Model forced Level Of Detail index. Allows to bind the given model LOD to show. Value -1 disables this feature.")]
        public int ForcedLOD
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetForcedLOD(unmanagedPtr); }
            set { Internal_SetForcedLOD(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets material used to render mesh at given index (overriden by model instance buffer or model default).
        /// </summary>
        /// <param name="meshIndex">Mesh index</param>
        /// <param name="lodIndex">Level of Detail index</param>
        /// <returns>Material or null if not assigned.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public MaterialBase GetMaterial(int meshIndex, int lodIndex = 0)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_GetMaterial(unmanagedPtr, meshIndex, lodIndex);
#endif
        }

        /// <summary>
        /// Resets all meshes local transformations.
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void ResetMeshTransformations()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_ResetMeshTransformations(unmanagedPtr);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetScaleInLightmap(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetScaleInLightmap(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetBoundsScale(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetBoundsScale(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern DrawPass Internal_GetDrawModes(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDrawModes(IntPtr obj, DrawPass val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Model Internal_GetModel(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetModel(IntPtr obj, IntPtr val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetLODBias(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetLODBias(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetForcedLOD(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetForcedLOD(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MaterialBase Internal_GetMaterial(IntPtr obj, int meshIndex, int lodIndex);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_ResetMeshTransformations(IntPtr obj);
#endif

        #endregion
    }
}
