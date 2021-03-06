// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// The audio service used for music and sound effects playback.
    /// </summary>
    public static partial class Audio
    {
        /// <summary>
        /// Gets or sets the master volume applied to all the audio sources (normalized to range 0-1).
        /// </summary>
        [UnmanagedCall]
        public static float MasterVolume
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMasterVolume(); }
            set { Internal_SetMasterVolume(value); }
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetMasterVolume();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMasterVolume(float val);
#endif

        #endregion
    }
}
