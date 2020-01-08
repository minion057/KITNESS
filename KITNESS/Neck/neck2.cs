using Microsoft.Kinect;
using System;

namespace Kitness.Neck
{
    class neck2
    {
        public static int Right()
        {
            //오른쪽 팔이 머리를 꺽고 있는지 확인
            //오른쪽 팔꿈치x가 오른쪽 손목x보다 크면 올바른 것
            if (Kinect_Point.points[(int)JointType.ElbowRight].X > Kinect_Point.points[(int)JointType.WristRight].X)
            {
                if (Kinect_Point.points[(int)JointType.Head].Y >= Kinect_Point.points[(int)JointType.HandRight].Y &&
                    Kinect_Point.points[(int)JointType.ElbowRight].Y > Kinect_Point.points[(int)JointType.WristRight].Y)
                { //오른쪽 손목이 머리보다 높고(혹시 몰라 편차10을 줌), 팔꿈치보다 손목이 더 높아야한다.
                    if (Kinect_Point.points[(int)JointType.WristLeft].Y > Kinect_Point.points[(int)JointType.ElbowLeft].Y &&
                        Kinect_Point.points[(int)JointType.ElbowLeft].Y > Kinect_Point.points[(int)JointType.ShoulderLeft].Y)
                    { //반대팔을 내리고 있다면
                        return 10; //자세가 옳다
                    }
                    return 1; //반대 팔도 들고 있다 > 틀림
                }
                return 2; //머리보다 손목이 높지 않거나, 손목과 팔꿈치가 동일선상에 있다. > 틀림
            }
            return 2; //오른쪽 팔을 꺽지 않은 것 > 틀림
        }

        public static int Left()
        {
            //왼쪽 팔이 머리를 꺽고 있는지 확인
            //왼쪽 팔꿈치x가 왼쪽 손목x보다 작으면 올바른 것
            if (Kinect_Point.points[(int)JointType.ElbowLeft].X < Kinect_Point.points[(int)JointType.WristLeft].X)
            {
                if (Kinect_Point.points[(int)JointType.Head].Y >= Kinect_Point.points[(int)JointType.HandLeft].Y &&
                    Kinect_Point.points[(int)JointType.ElbowLeft].Y > Kinect_Point.points[(int)JointType.WristLeft].Y)
                { //왼쪽 손목이 머리보다 높고(혹시 몰라 편차10을 줌), 팔꿈치보다 손목이 더 높아야한다.
                    if (Kinect_Point.points[(int)JointType.WristRight].Y > Kinect_Point.points[(int)JointType.ElbowRight].Y &&
                        Kinect_Point.points[(int)JointType.ElbowRight].Y > Kinect_Point.points[(int)JointType.ShoulderRight].Y)
                    { //반대팔을 내리고 있다면
                        return 10; //자세가 옳다
                    }
                    return 2; //반대 팔도 들고 있다 > 틀림
                }
                return 1; //머리보다 손목이 높지 않거나, 손목과 팔꿈치가 동일선상에 있다. > 틀림
            }
            return 1; //왼쪽 팔을 꺽지 않은 것 > 틀림
        }
    }
}
