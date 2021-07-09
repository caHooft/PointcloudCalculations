using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointcloudCalculations
{
    /// <summary>
    /// Make a cone from the camera position
    /// Take all points within the where te angle is less than angle tollerance(2-5 degrees)
    /// Sort all of these points based on the shortest distance to the camera position
    /// build a selection based on distance based on x,y,z distance to camera positiom
    /// Than sort selection with the shortest distance at the start of the array/ list/ collection/ other way to safe information'
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Point cameraPoint = new Point();
            cameraPoint.X = 131453.074;
            cameraPoint.Y = 398786.554;
            cameraPoint.Z = 16.889;

            Vector ClickedPointVector = new Vector(1,1,1);

            Vector CenterCameraVector = new Vector(1,1,1);

        }
    }
}
