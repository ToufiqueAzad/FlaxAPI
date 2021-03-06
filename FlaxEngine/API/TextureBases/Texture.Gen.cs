// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Texture asset contains an image that is usually stored on a GPU and is used during rendering graphics.
    /// </summary>
    public partial class Texture : TextureBase
    {
        /// <summary>
        /// Creates new <see cref="Texture"/> object.
        /// </summary>
        protected Texture() : base()
        {
        }

        /// <summary>
        /// Returns true if texture is a normal map, otherwise false.
        /// </summary>
        [UnmanagedCall]
        public bool IsNormalMap
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsNormalMap(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Saves asset to the file. It must be fully loaded.
        /// </summary>
        /// <remarks>
        /// Supported only in Editor.
        /// </remarks>
        /// <param name="path">The custom asset path to use for the saving. Use empty value to save this asset to its own storage location. Can be used to duplicate asset.</param>
        /// <returns>True if cannot save data, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public bool Save(string path = null)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Save(unmanagedPtr, path);
#endif
        }

        /// <summary>
        /// Loads the texture from the image file. Supported file formats depend on a runtime platform. All platform support loading PNG, BMP, TGA, HDR and JPEG files.
        /// </summary>
        /// <remarks>
        /// Valid only for virtual assets.
        /// </remarks>
        /// <param name="path">The source image file path.</param>
        /// <param name="generateMips">True if generate mipmaps for the imported texture.</param>
        /// <returns>True if fails, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public bool LoadFile(string path, bool generateMips = false)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_LoadFile(unmanagedPtr, path, generateMips);
#endif
        }

        /// <summary>
        /// Loads the texture from the image file and creates the virtual texture asset for it. Supported file formats depend on a runtime platform. All platform support loading PNG, BMP, TGA, HDR and JPEG files.
        /// </summary>
        /// <param name="path">The source image file path.</param>
        /// <param name="generateMips">True if generate mipmaps for the imported texture.</param>
        /// <returns>The loaded texture (virtual asset) or null if fails.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static Texture FromFile(string path, bool generateMips = false)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_FromFile(path, generateMips);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsNormalMap(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_Save(IntPtr obj, string path);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_LoadFile(IntPtr obj, string path, bool generateMips);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture Internal_FromFile(string path, bool generateMips);
#endif

        #endregion
    }
}
