
namespace BnqLib;

public struct DisplaceVectors
{
    public int X;
    public int Y;

    public DisplaceVectors(int x, int y)
    {
        X = x; Y = y;
    }

    public static DisplaceVectors operator +(DisplaceVectors d1, DisplaceVectors d2)
    {
        return new DisplaceVectors(d1.X + d2.X, d1.Y + d2.Y);
    }
}
