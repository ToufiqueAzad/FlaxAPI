////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using System;
using FlaxEditor.Windows;
using FlaxEditor.Windows.Assets;
using FlaxEngine;

namespace FlaxEditor.Content
{
	/// <summary>
	/// A <see cref="SkeletonMask"/> asset proxy object.
	/// </summary>
	/// <seealso cref="FlaxEditor.Content.BinaryAssetProxy" />
	public class SkeletonMaskProxy : BinaryAssetProxy
	{
		/// <inheritdoc />
		public override string Name => "Skeleton Mask";

		/// <inheritdoc />
		public override EditorWindow Open(Editor editor, ContentItem item)
		{
			return new SkeletonMaskWindow(editor, item as AssetItem);
		}

		/// <inheritdoc />
		public override Color AccentColor => Color.FromRGB(0x00B31C);

		/// <inheritdoc />
		public override ContentDomain Domain => ContentDomain.SkeletonMask;

		/// <inheritdoc />
		public override string TypeName => typeof(SkeletonMask).FullName;

		/// <inheritdoc />
		public override bool CanCreate(ContentFolder targetLocation)
		{
			return targetLocation.CanHaveAssets;
		}

		/// <inheritdoc />
		public override void Create(string outputPath)
		{
			if (Editor.CreateAsset(Editor.NewAssetType.SkeletonMask, outputPath))
				throw new Exception("Failed to create new asset.");
		}
	}
}
