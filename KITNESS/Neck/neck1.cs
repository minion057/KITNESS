using Microsoft.Kinect;
using System;

namespace Kitness.Neck
{
    class neck1 // 어깨 올리기
    {
        public static int Check()
        {
            if (Kinect_Point.points[(int)JointType.ShoulderLeft].Y < Kinect_Point.points[(int)JointType.ElbowLeft].Y &&
                Kinect_Point.points[(int)JointType.ElbowLeft].Y < Kinect_Point.points[(int)JointType.WristLeft].Y)
            {
                if (Kinect_Point.points[(int)JointType.ShoulderRight].Y < Kinect_Point.points[(int)JointType.ElbowRight].Y &&
                    Kinect_Point.points[(int)JointType.ElbowRight].Y < Kinect_Point.points[(int)JointType.WristRight].Y)
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
                else return 2; // 오른쪽 어깨 문제있음
            }
            return 1; // 왼쪽 어깨 문제있음
        }
    }
}