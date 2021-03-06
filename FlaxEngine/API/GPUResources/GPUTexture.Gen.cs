// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// The GPU texture resource object.
    /// </summary>
    public sealed partial class GPUTexture : GPUResource
    {
        /// <summary>
        /// Creates new <see cref="GPUTexture"/> object.
        /// </summary>
        private GPUTexture() : base()
        {
        }

        /// <summary>
        /// Gets texture dimensions.
        /// </summary>
        [UnmanagedCall]
        public TextureDimensions Dimensions
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDimensions(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets texture surface format.
        /// </summary>
        [UnmanagedCall]
        public PixelFormat Format
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFormat(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets texture surface multisample level.
        /// </summary>
        [UnmanagedCall]
        public MSAALevel MultiSampleLevel
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMultiSampleLevel(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets number of mipmap levels in the texture.
        /// </summary>
        [UnmanagedCall]
        public int MipLevels
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMipLevels(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the texture surface flags.
        /// </summary>
        [UnmanagedCall]
        public GPUTextureFlags Flags
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFlags(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets a value indicating whether this texture has been allocated.
        /// </summary>
        [UnmanagedCall]
        public bool IsAllocated
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsAllocated(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the native pointer to the underlying resource. It's a low-level platform-specific handle.
        /// </summary>
        [UnmanagedCall]
        public IntPtr NativePtr
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetNativePtr(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface width (in pixels).
        /// </summary>
        [UnmanagedCall]
        public int Width
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetWidth(unmanagedPtr); }
            set { Internal_SetWidth(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface height (in pixels).
        /// </summary>
        [UnmanagedCall]
        public int Height
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetHeight(unmanagedPtr); }
            set { Internal_SetHeight(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface depth (in pixels). Used only by volume textures. For 1D and 2D textures it defaults to 1.
        /// </summary>
        [UnmanagedCall]
        public int Depth
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDepth(unmanagedPtr); }
            set { Internal_SetDepth(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets texture array size.
        /// </summary>
        [UnmanagedCall]
        public int ArraySize
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetArraySize(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface size (in pixels).
        /// </summary>
        [UnmanagedCall]
        public Vector2 Size
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector2 resultAsRef; Internal_GetSize(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetSize(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets texture description structure.
        /// </summary>
        [UnmanagedCall]
        public GPUTextureDescription Description
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { GPUTextureDescription resultAsRef; Internal_GetDescription(unmanagedPtr, out resultAsRef); return resultAsRef; }
#endif
        }

        /// <summary>
        /// Initializes a texture resource (allocates the GPU memory and performs the resource setup).
        /// </summary>
        /// <param name="desc">The texture description.</param>
        /// <returns>True if cannot create texture, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public bool Init(ref GPUTextureDescription desc)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Init(unmanagedPtr, ref desc);
#endif
        }

        /// <summary>
        /// Releases GPU resource data.
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void ReleaseGPU()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_ReleaseGPU(unmanagedPtr);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TextureDimensions Internal_GetDimensions(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PixelFormat Internal_GetFormat(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MSAALevel Internal_GetMultiSampleLevel(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetMipLevels(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern GPUTextureFlags Internal_GetFlags(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsAllocated(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr Internal_GetNativePtr(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetWidth(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetWidth(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetHeight(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetHeight(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetDepth(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDepth(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetArraySize(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetSize(IntPtr obj, out Vector2 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSize(IntPtr obj, ref Vector2 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetDescription(IntPtr obj, out GPUTextureDescription resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_Init(IntPtr obj, ref GPUTextureDescription desc);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_ReleaseGPU(IntPtr obj);
#endif

        #endregion
    }
}
