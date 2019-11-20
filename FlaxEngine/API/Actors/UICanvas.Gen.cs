// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;

namespace FlaxEngine
{
    /// <summary>
    /// Root of the UI structure. Renders GUI and handles input events forwarding.
    /// </summary>
    [Serializable]
    public sealed partial class UICanvas : Actor
    {
        /// <summary>
        /// Creates new instance of <see cref="UICanvas"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static UICanvas New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(UICanvas)) as UICanvas;
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
#endif

        #endregion
    }
}
