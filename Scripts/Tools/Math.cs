using System.Runtime.CompilerServices;

namespace NeonTanto.Tools.AtlasPacking
{
    public struct Vector2Int
    {
        public int x, y;

        public Vector2Int(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public static readonly Vector2Int one = new Vector2Int(1, 1);
        public static readonly Vector2Int zero = new Vector2Int(0, 0);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int operator * (int a, Vector2Int b) => new Vector2Int(a * b.x, a * b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int operator * (Vector2Int a, int b) => new Vector2Int(a.x * b, a.y * b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int operator + (Vector2Int a, Vector2Int b) => new Vector2Int(a.x + b.x, a.y + b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int operator - (Vector2Int a, Vector2Int b) => new Vector2Int(a.x - b.x, a.y - b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Vector2Int lhs, Vector2Int rhs) => lhs.x == rhs.x && lhs.y == rhs.y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Vector2Int lhs, Vector2Int rhs) => !(lhs == rhs);
    }

    public struct RectInt
    {
        public int xMin, yMin, width, height;

        public RectInt(Vector2Int pos, Vector2Int size) 
        {
            xMin = pos.x;
            yMin = pos.y;
            width = size.x;
            height = size.y;
        }

        public Vector2Int size 
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2Int(width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector2Int position) => position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
        
        public int xMax
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => System.Math.Max(this.xMin, this.xMin + this.width);
        }
        
        public int yMax
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => System.Math.Max(this.yMin, this.yMin + this.height);
        }
        
        public Vector2Int position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2Int(this.xMin, this.yMin);
        }
    }
}