using Microsoft.Kinect;
using System;

namespace Kitness.Spine
{
    class spine2 // 옆구리 늘이기
    {
        public static int Left()
        {
            if(Kinect_Point.points[(int)JointType.Spine].X < Kinect_Point.points[(int)JointType.Head].X)
            {
                if (Kinect_Point.points[(int)JointType.ShoulderCenter].Y > Kinect_Point.points[(int)JointType.ElbowLeft].Y)
                {
                    if(Kinect_Point.points[(int)JointType.HipLeft].Y < Kinect_Point.points[(int)JointType.KneeLeft].Y &&
                        Kinect_Point.points[(int)JointType.KneeLeft].Y < Kinect_Point.points[(int)JointType.AnkleLeft].Y)
                    {
                        if (Kinect_Point.points[(int)JointType.HipRight].Y < Kinect_Point.points[(int)JointType.KneeRight].Y &&
                            Kinect_Point.points[(int)JointType.KneeRight].Y < Kinect_Point.points[(int)JointType.AnkleRight].Y) return 10;
                        return 4;
                    }
                    return 3;
                }
                return 1;
            }return 0;
        }

        public static int Right()
        {
            if (Kinect_Point.points[(int)JointType.Spine].X > Kinect_Point.points[(int)JointType.Head].X)
            {
                if (Kinect_Point.points[(int)JointType.ShoulderCenter].Y > Kinect_Point.points[(int)JointType.ElbowRight].Y)
                {
                    if (Kinect_Point.points[(int)JointType.HipLeft].Y < Kinect_Point.points[(int)JointType.KneeLeft].Y &&
                        Kinect_Point.points[(int)JointType.KneeLeft].Y < Kinect_Point.points[(int)JointType.AnkleLeft].Y)
                    {
                        if (Kinect_Point.points[(int)JointType.HipRight].Y < Kinect_Point.points[(int)JointType.KneeRight].Y &&
                            Kinect_Point.points[(int)JointType.KneeRight].Y < Kinect_Point.points[(int)JointType.AnkleRight].Y) return 10;
                        return 4;
                    }
                    return 3;
                }
                return 1;
            }
            return 0;
        }
    }
}
