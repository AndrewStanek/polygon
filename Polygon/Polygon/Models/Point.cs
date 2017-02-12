using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Models {

  /* Class defining point in cartesian coordinate system. */
  class Point {
    public double x;
    public double y;

    public Point(double x, double y) {
      this.x = x;
      this.y = y;
    }
  }
}
