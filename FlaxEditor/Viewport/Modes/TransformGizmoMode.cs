// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.

namespace FlaxEditor.Viewport.Modes
{
    /// <summary>
    /// The default editor mode that uses <see cref="FlaxEditor.Gizmo.TransformGizmo"/> for objects transforming.
    /// </summary>
    /// <seealso cref="FlaxEditor.Viewport.Modes.EditorGizmoMode" />
    public class TransformGizmoMode : EditorGizmoMode
    {
        /// <inheritdoc />
        public override void OnActivated()
        {
            base.OnActivated();

            Viewport.Gizmos.Active = Viewport.TransformGizmo;
        }
    }
}