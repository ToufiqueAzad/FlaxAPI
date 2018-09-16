// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using System.Linq;
using FlaxEditor.Content;
using FlaxEditor.CustomEditors.Elements;
using FlaxEditor.GUI;
using FlaxEngine;

namespace FlaxEditor.CustomEditors.Editors
{
    /// <summary>
    /// Default implementation of the inspector used to edit reference to the <see cref="AssetItem"/>.
    /// </summary>
    [CustomEditor(typeof(AssetItem)), DefaultEditor]
    public sealed class AssetItemRefEditor : AssetRefEditor
    {
    }

    /// <summary>
    /// Default implementation of the inspector used to edit reference to the <see cref="SceneReference"/>.
    /// </summary>
    [CustomEditor(typeof(SceneReference)), DefaultEditor]
    public sealed class SceneRefEditor : AssetRefEditor
    {
    }

    /// <summary>
    /// Default implementation of the inspector used to edit reference to the <see cref="FlaxEngine.Asset"/>.
    /// </summary>
    /// <remarks>Supports editing reference to the asset using various containers: <see cref="Asset"/> or <see cref="AssetItem"/> or <see cref="Guid"/>.</remarks>
    [CustomEditor(typeof(Asset)), DefaultEditor]
    public class AssetRefEditor : CustomEditor
    {
        private CustomElement<AssetPicker> _element;
        private Type _type;

        /// <inheritdoc />
        public override DisplayStyle Style => DisplayStyle.Inline;

        /// <inheritdoc />
        public override void Initialize(LayoutElementsContainer layout)
        {
            if (!HasDifferentTypes)
            {
                _type = Values.Type != typeof(object) || Values[0] == null ? Values.Type : Values[0].GetType();

                float height = 48;
                if (Values.Info != null)
                {
                    var attributes = Values.Info.GetCustomAttributes(true);
                    var assetReference = (AssetReferenceAttribute)attributes.FirstOrDefault(x => x is AssetReferenceAttribute);
                    if (assetReference != null)
                    {
                        if (assetReference.UseSmallPicker)
                            height = 32;

                        if (!string.IsNullOrEmpty(assetReference.TypeName))
                        {
                            var customType = Utilities.Utils.GetType(assetReference.TypeName);
                            if (customType != null)
                                _type = customType;
                            else
                                Debug.LogWarning(string.Format("Unknown asset type '{0}' to use for asset picker filter.", assetReference.TypeName));
                        }
                    }
                }

                _element = layout.Custom<AssetPicker>();
                _element.CustomControl.AssetType = _type;
                _element.CustomControl.Height = height;
                _element.CustomControl.SelectedItemChanged += OnSelectedItemChanged;
            }
        }

        private void OnSelectedItemChanged()
        {
            if (typeof(AssetItem).IsAssignableFrom(_type))
                SetValue(_element.CustomControl.SelectedItem);
            else if (_type == typeof(Guid))
                SetValue(_element.CustomControl.SelectedID);
            else if (_type == typeof(SceneReference))
                SetValue(new SceneReference(_element.CustomControl.SelectedID));
            else
                SetValue(_element.CustomControl.SelectedAsset);
        }

        /// <inheritdoc />
        public override void Refresh()
        {
            base.Refresh();

            if (!HasDifferentValues)
            {
                if (Values[0] is AssetItem assetItem)
                    _element.CustomControl.SelectedItem = assetItem;
                else if (Values[0] is Guid guid)
                    _element.CustomControl.SelectedID = guid;
                else if (Values[0] is SceneReference sceneAsset)
                    _element.CustomControl.SelectedItem = Editor.Instance.ContentDatabase.FindAsset(sceneAsset.ID);
                else
                    _element.CustomControl.SelectedAsset = Values[0] as Asset;
            }
        }
    }
}
