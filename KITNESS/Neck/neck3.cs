using Microsoft.Kinect;
using System;

namespace Kitness.Neck
{
    class neck3 // 통닭 자세
    {
        public static int Check() // 부처 핸썸
        {
            if (Kinect_Point.points[(int)JointType.ElbowLeft].Y - 50 > Kinect_Point.points[(int)JointType.WristLeft].Y &&
                Kinect_Point.points[(int)JointType.ElbowLeft].Y >= Kinect_Point.points[(int)JointType.ShoulderLeft].Y - 15 &&
                Kinect_Point.points[(int)JointType.ElbowLeft].Y <= Kinect_Point.points[(int)JointType.ShoulderLeft].Y + 15)
            {
                if (Kinect_Point.points[(int)JointType.ElbowRight].Y - 50 > Kinect_Point.points[(int)JointType.WristRight].Y &&
                Kinect_Point.points[(int)JointType.ElbowRight].Y >= Kinect_Point.points[(int)JointType.ShoulderRight].Y - 15 &&
                Kinect_Point.points[(int)JointType.ElbowRight].Y <= Kinect_Point.points[(int)JointType.ShoulderRight].Y + 15)
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
                return 2; // 오른쪽 자세 문제있음
            }
            else return 1; // 왼쪽 어깨 문제있음
        }
    }
}
