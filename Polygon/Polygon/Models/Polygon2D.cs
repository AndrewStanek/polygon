using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Models {
  class Polygon2D {
    private List<Point> points;
    public double SurfaceArea {
      get {
        return this.PolygonArea();
      }
      private set {

      }
    }

    public Polygon2D(List<Point> points) {
      this.points = points;
    }

    private double PolygonArea() {
      int i, j;
      double area = 0;

      for (i = 0; i < this.points.Count; i++) {
        j = (i + 1) % points.Count;
        area += points[i].x * points[j].y;
        area -= points[i].y * points[j].x;
      }
      area /= 2;
      return (area < 0 ? -area : area);
    }
  }
}
