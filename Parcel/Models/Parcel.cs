using System.Collections.Generic;

namespace Parcel.Models
{
  public class Package
  {
   
    private int[] Dimensions { get; set; }
    private int Weight { get; set; }

    private int Volume { get; set; }
    private static List<Package> _cart = new List<Package>{};

    public Package(int[] dimensions, int weight)
    {
      Weight = weight;
      Volume = VolumeCalc(dimensions);
      _cart.Add(this);
    }

    public int VolumeCalc(int[] sides)
    {
      return sides[0]*sides[1]*sides[2];
    }

    public float CostToShip()
    {
      if (Weight >= 2 || Volume >= 204)
      {
        return 4;
      }
      else if (Weight >= 5 || Volume >= 408)
      {
        return 10;
      }
      else if (Weight >= 10 || Volume >= 916)
      {
        return 20;
      }
      else
      {
        return 40;
      }
    }

    public static List<Package> GetAll()
    {
      return _cart;
    }

    public int GetWeight()
    {
      return Weight;
    }

    public int GetVolume()
    {
      return Volume;
    }
  }
}