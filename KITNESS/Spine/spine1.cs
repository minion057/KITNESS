using Microsoft.Kinect;
using System;

namespace Kitness.Spine
{
    class spine1 // 한쪽 다리 뻗기
    {
        public static int Left()
        {   
            Boolean test = Kinect_Point.points[(int)JointType.Spine].Y + 30 <= Kinect_Point.points[(int)JointType.ShoulderCenter].Y &&
                           Kinect_Point.points[(int)JointType.Spine].Y - 30 >= Kinect_Point.points[(int)JointType.ShoulderCenter].Y &&
                           Kinect_Point.points[(int)JointType.Spine].Y + 30 <= Kinect_Point.points[(int)JointType.KneeLeft].Y &&
                           Kinect_Point.points[(int)JointType.Spine].Y - 30 >= Kinect_Point.points[(int)JointType.KneeLeft].Y ? true : false;
                           //spine기준으로 어깨와 들고있는 왼쪽 다리 무릎의  y가 +-30인지 확인

            if (test) 
            {
                test = Kinect_Point.points[(int)JointType.KneeLeft].X > Kinect_Point.points[(int)JointType.AnkleLeft].X &&
                       Kinect_Point.points[(int)JointType.Spine].X > Kinect_Point.points[(int)JointType.KneeLeft].X &&
                       Kinect_Point.points[(int)JointType.ShoulderCenter].X > Kinect_Point.points[(int)JointType.Spine].X ? true : false;
                if (test)
                {
                    if(Kinect_Point.points[(int)JointType.HipRight].Y < Kinect_Point.points[(int)JointType.KneeRight].Y &&
                       Kinect_Point.points[(int)JointType.HipRight].X - 50 <= Kinect_Point.points[(int)JointType.KneeRight].X) return 10;
                    //오른쪽 발이 일직선
                    return 4; // 오른쪽 팔을 제대로 안했음
                }
                return 3; // 오른쪽 다리 제대로 안폈음
            }

            return 3;
        }

        public static int Right()
        {
            Boolean test = Kinect_Point.points[(int)JointType.Spine].Y + 30 <= Kinect_Point.points[(int)JointType.ShoulderCenter].Y &&
                           Kinect_Point.points[(int)JointType.Spine].Y - 30 >= Kinect_Point.points[(int)JointType.ShoulderCenter].Y &&
                           Kinect_Point.points[(int)JointType.Spine].Y + 30 <= Kinect_Point.points[(int)JointType.KneeRight].Y &&
                           Kinect_Point.points[(int)JointType.Spine].Y - 30 >= Kinect_Point.points[(int)JointType.KneeRight].Y ? true : false;
                           //spine기준으로 어깨와 들고있는 왼쪽 다리 무릎의  y가 +-30인지 확인

            if (test)
            {
                test = Kinect_Point.points[(int)JointType.KneeRight].X < Kinect_Point.points[(int)JointType.AnkleRight].X &&
                       Kinect_Point.points[(int)JointType.Spine].X < Kinect_Point.points[(int)JointType.KneeRight].X &&
                       Kinect_Point.points[(int)JointType.ShoulderCenter].X < Kinect_Point.points[(int)JointType.Spine].X ? true : false;
                if (test)
                {
                    if (Kinect_Point.points[(int)JointType.HipLeft].Y < Kinect_Point.points[(int)JointType.KneeLeft].Y &&
                       Kinect_Point.points[(int)JointType.HipLeft].X + 50 <= Kinect_Point.points[(int)JointType.KneeLeft].X) return 10;
                    //왼쪽 발이 일직선
                    return 3;
                }
                return 4; // 오른쪽 다리 제대로 안폈음
            }

            return 4;
        }
    }
}
