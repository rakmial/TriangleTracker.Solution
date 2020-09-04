namespace TriangleTracker
{
  public class Triangle
  {
    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    public Triangle(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }

    public bool ValidTriangle(int X, int Y, int Z)
    {
      bool valid1 = (X + Y) / Z >= 1;
      bool valid2 = (Y + Z) / X >= 1;
      bool valid3 = (Z + X) / Y >= 1;

      return valid1;
    }
  }
}