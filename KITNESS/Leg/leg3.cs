using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kitness.Leg
{
    class leg3 // 무릎 벌려 엉덩이 내리고 앉기
    {
        public static int Check()
        {
            Boolean test = Kinect_Point.points[(int)JointType.KneeRight].X > Kinect_Point.points[(int)JointType.HipRight].X &&
                           Kinect_Point.points[(int)JointType.KneeLeft].X < Kinect_Point.points[(int)JointType.HipLeft].X ? true : false;
            if (test) // 왼쪽 다리 오른쪽 다리를 벌렸으면
            {
                test = Kinect_Point.points[(int)JointType.KneeLeft].Y  <= Kinect_Point.points[(int)JointType.HipCenter].Y + 200 &&
                       Kinect_Point.points[(int)JointType.KneeRight].Y <= Kinect_Point.points[(int)JointType.HipCenter].Y + 200 ? true : false;

                if (test) return 10;
                return 3;
            }
            return 3;
        }
    }
}