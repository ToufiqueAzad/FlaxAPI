// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FlaxEngine;

namespace FlaxEditor
{
    /// <summary>
    /// Editor viewports icons rendering service.
    /// </summary>
    public static partial class ViewportIconsRenderer
    {
        /// <summary>
        /// Draws the icons for the actors in the given scene.
        /// </summary>
        /// <param name="context">The GPU commands context.</param>
        /// <param name="task">The scene rendering task.</param>
        /// <param name="target">The output texture.</param>
        /// <param name="targetDepth">The output depth texture.</param>
        /// <param name="scene">The scene.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawIcons(GPUContext context, RenderTask task, GPUTexture target, GPUTexture targetDepth, Scene scene)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawIcons(FlaxEngine.Object.GetUnmanagedPtr(context), FlaxEngine.Object.GetUnmanagedPtr(task), FlaxEngine.Object.GetUnmanagedPtr(target), FlaxEngine.Object.GetUnmanagedPtr(targetDepth), FlaxEngine.Object.GetUnmanagedPtr(scene));
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawIcons(IntPtr context, IntPtr task, IntPtr target, IntPtr targetDepth, IntPtr scene);
#endif

        #endregion
    }
}
