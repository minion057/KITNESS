using Microsoft.Kinect;
using System;

namespace Kitness.Spine
{
    class spine3
    {
        public static int Right()
        {   
            //오른쪽 다리가 왼쪽 다리 뒤로 스윙하고 있는지 확인
            //오른쪽 발목x가 왼쪽 발목x보다 작으면 올바른 것
            if (Kinect_Point.points[(int)JointType.AnkleRight].X < Kinect_Point.points[(int)JointType.AnkleLeft].X)
            {
                if (Kinect_Point.points[(int)JointType.HipRight].X > Kinect_Point.points[(int)JointType.KneeRight].X &&
                        Kinect_Point.points[(int)JointType.KneeRight].X > Kinect_Point.points[(int)JointType.AnkleRight].X)
                { //오른쪽 다리가 스윙을 제대로 하고 있다면 오른쪽 hip > knee > ankle (x좌표 기준)
                    if (Kinect_Point.points[(int)JointType.Head].X > Kinect_Point.points[(int)JointType.WristLeft].X &&
                        Kinect_Point.points[(int)JointType.Head].X > Kinect_Point.points[(int)JointType.WristRight].X)
                    { //팔을 들고 있는 상태이니, 머리 y > 팔 y (y역순이니까 부등호도 반대로)
                        return 10;
                    }
                    return 1; //팔을 머리 위로 들고 있지 않음
                }
                return 4; //제대로 스윙하고 있지 않음
            }
            return 4;
        }

        public static int Left()
        {
            //왼쪽 다리가 오른쪽 다리 뒤로 스윙하고 있는지 확인
            //왼쪽 발목x가 오른쪽 발목x보다 작으면 올바른 것
            if (Kinect_Point.points[(int)JointType.AnkleRight].X > Kinect_Point.points[(int)JointType.AnkleLeft].X)
            {
                if (Kinect_Point.points[(int)JointType.HipLeft].X < Kinect_Point.points[(int)JointType.KneeLeft].X &&
                        Kinect_Point.points[(int)JointType.KneeLeft].X < Kinect_Point.points[(int)JointType.AnkleLeft].X)
                { //왼쪽 다리가 스윙을 제대로 하고 있다면 왼쪽 hip > knee > ankle (x좌표 기준)
                    if (Kinect_Point.points[(int)JointType.Head].X > Kinect_Point.points[(int)JointType.WristLeft].X &&
                        Kinect_Point.points[(int)JointType.Head].X > Kinect_Point.points[(int)JointType.WristRight].X)
                    { //팔을 들고 있는 상태이니, 머리 y > 팔 y (y역순이니까 부등호도 반대로)
                        return 10;
                    }
                    return 1; //팔을 머리 위로 들고 있지 않음
                }
                return 3; //제대로 스윙하고 있지 않음
            }
            return 3;
        }
    }
}
