////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

namespace FlaxEngine
{
    public sealed partial class MaterialInstance
    {
        /// <summary>
        /// The material asset type unique ID.
        /// </summary>
        public const int TypeID = 4;

        /// <summary>
        /// The asset type content domain.
        /// </summary>
        public const ContentDomain Domain = ContentDomain.Material;

        /// <inheritdoc />
        public override MaterialInstance CreateVirtualInstance()
        {
            WaitForLoaded();

            var instance = Content.CreateVirtualAsset<MaterialInstance>();
            var baseMaterial = BaseMaterial;
            if (baseMaterial)
                baseMaterial.WaitForLoaded();
            instance.BaseMaterial = baseMaterial;
            
            // Copy parameters
            var src = Parameters;
            var dst = instance.Parameters;
            if (src != null && dst != null && src.Length == dst.Length)
            {
                for (int i = 0; i < src.Length; i++)
                {
                    if (src[i].IsPublic)
                        dst[i].Value = src[i].Value;
                }
            }

            return instance;
        }
    }
}
