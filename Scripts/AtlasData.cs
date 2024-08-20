using System.Collections.Generic;

namespace NeonTanto.Tools.AtlasPacking
{
    public struct AtlasData
    {
        public Vector2Int size;
        public IReadOnlyList<AtlasRect> rects;
    }
}