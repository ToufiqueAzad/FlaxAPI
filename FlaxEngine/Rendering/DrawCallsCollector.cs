// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using System.Collections.Generic;

namespace FlaxEngine.Rendering
{
    /// <summary>
    /// Helper class to collect GPU drawing requests and send them back to the Engine.
    /// </summary>
    public sealed class DrawCallsCollector
    {
        private readonly List<RenderTask.DrawCall> _drawCalls = new List<RenderTask.DrawCall>();

        internal RenderTask.DrawCall[] DrawCalls => _drawCalls.Count > 0 ? _drawCalls.ToArray() : null;

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            _drawCalls.Clear();
        }

		/// <summary>
		/// Adds the draw call. Calculates target mesh level of detail and picks a proper meshes to draw (based on a material slot index).
		/// </summary>
		/// <param name="model">The model mesh to render. Cannot be null.</param>
		/// <param name="materialSlotIndex">The material slot index to draw.</param>
		/// <param name="material">The material to apply during rendering. Cannot be null.</param>
		/// <param name="bounds">The bounds of the model instance that is being drawn (model instance bounds).</param>
		/// <param name="world">The world matrix used to transform mesh geometry during rendering. Use <see cref="Matrix.Identity"/> to render mesh 'as is'.</param>
		/// <param name="flags">The static flags. Used to describe type of the geometry.</param>
		/// <param name="receiveDecals">True if rendered geometry can receive decals, otherwise false.</param>
		public void AddDrawCall(Model model, int materialSlotIndex, MaterialBase material, ref BoundingSphere bounds, ref Matrix world, StaticFlags flags = StaticFlags.None, bool receiveDecals = true)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            // Pick a proper LOD
            int lodIndex = RenderTask.Internal_ComputeModelLOD(model.unmanagedPtr, ref bounds, IntPtr.Zero);
            var lods = model.LODs;
            if (lods == null || lods.Length < lodIndex || lodIndex < 0)
                return;
            var lod = lods[lodIndex];

            // Draw meshes
            for (int i = 0; i < lod.Meshes.Length; i++)
            {
                if (lod.Meshes[i].MaterialSlotIndex == materialSlotIndex)
                {
                    AddDrawCall(lod.Meshes[i], material, ref world, flags);
                }
            }
        }

	    /// <summary>
	    /// Adds the draw call.
	    /// </summary>
	    /// <param name="mesh">The mesh to render. Cannot be null.</param>
	    /// <param name="material">The material to apply during rendering. Cannot be null.</param>
	    /// <param name="world">The world matrix used to transform mesh geometry during rendering. Use <see cref="Matrix.Identity"/> to render mesh 'as is'.</param>
	    /// <param name="flags">The static flags. Used to describe type of the geometry.</param>
	    /// <param name="receiveDecals">True if rendered geometry can receive decals, otherwise false.</param>
	    public void AddDrawCall(Mesh mesh, MaterialBase material, ref Matrix world, StaticFlags flags = StaticFlags.None, bool receiveDecals = true)
        {
            if (mesh == null)
                throw new ArgumentNullException(nameof(mesh));
            if (material == null)
                throw new ArgumentNullException(nameof(material));

            var drawCall = new RenderTask.DrawCall
            {
                Flags = flags,
                LodIndex = mesh._lodIndex,
                MeshIndex = mesh._meshIndex,
				ReceiveDecals = receiveDecals,
				AssetModel = Object.GetUnmanagedPtr(mesh.ParentModel),
                AssetMaterialBase = Object.GetUnmanagedPtr(material),
                World = world
            };

            _drawCalls.Add(drawCall);
        }

        /// <summary>
        /// Executes the draw calls.
        /// </summary>
        /// <param name="context">The GPU command context.</param>
        /// <param name="task">The render task.</param>
        /// <param name="output">The output texture.</param>
        /// <param name="pass">The rendering pass mode.</param>
        public void ExecuteDrawCalls(GPUContext context, RenderTask task, RenderTarget output, RenderPass pass)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (task == null)
                throw new ArgumentNullException(nameof(task));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            GPUContext.Internal_ExecuteDrawCalls(context.unmanagedPtr, task.unmanagedPtr, output.unmanagedPtr, DrawCalls, pass);
        }
    }
}
