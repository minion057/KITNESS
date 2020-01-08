using Microsoft.Kinect;
using System;

namespace Kitness.Leg
{
    class leg1
    {
        public static int Left()
        {
            Boolean test = Kinect_Point.points[(int)JointType.AnkleLeft].X < Kinect_Point.points[(int)JointType.KneeLeft].X &&
                            Kinect_Point.points[(int)JointType.KneeLeft].X < Kinect_Point.points[(int)JointType.HipLeft].X ? true : false;
            if (test)
            {
                //왼쪽 다리가 쭉 펴져있는 상태라면
                //중간지점인 Knee를 기준으로 다른쪽 knee보다 y가 높고 ankle과 hip y편차가 +-30인지 확인
                if (Kinect_Point.points[(int)JointType.KneeLeft].Y < Kinect_Point.points[(int)JointType.KneeRight].Y)
                {
                    test = Kinect_Point.points[(int)JointType.KneeLeft].Y + 80 >= Kinect_Point.points[(int)JointType.HipLeft].Y && Kinect_Point.points[(int)JointType.KneeLeft].Y - 80 <= Kinect_Point.points[(int)JointType.HipLeft].Y ?
                          (Kinect_Point.points[(int)JointType.KneeLeft].Y + 80 >= Kinect_Point.points[(int)JointType.AnkleLeft].Y && Kinect_Point.points[(int)JointType.KneeLeft].Y - 80 <= Kinect_Point.points[(int)JointType.AnkleLeft].Y ? true : false) : false;
                    if (test)
                    {
                        //test = Kinect_Point.points[(int)JointType.KneeRight].X + 70 >= Kinect_Point.points[(int)JointType.HipRight].X && Kinect_Point.points[(int)JointType.KneeRight].X - 70 <= Kinect_Point.points[(int)JointType.HipRight].X ?
                        //     (Kinect_Point.points[(int)JointType.KneeRight].X + 70 >= Kinect_Point.points[(int)JointType.AnkleRight].X && Kinect_Point.points[(int)JointType.KneeRight].X - 70 <= Kinect_Point.points[(int)JointType.AnkleRight].X ? true : false) : false;
                        //반대쪽 다리 x좌표를 knee기준으로 ankle과 hip이 +-20이고, y좌표가 hip보다 ankle과 knee가 아래라면 옳게 서있는 것
                        if (Kinect_Point.points[(int)JointType.HipRight].Y < Kinect_Point.points[(int)JointType.KneeRight].Y &&
                            Kinect_Point.points[(int)JointType.KneeRight].Y < Kinect_Point.points[(int)JointType.AnkleRight].Y) return 10;//true;
                        //반대쪽 다리(오른쪽)가 제대로 서있다
                        return 4;
                    }
                    return 3; //왼쪽 다리가 너무 내려가 있거나 너무 올라가있는 경우
                }
                return 3;//false; //왼쪽 다리를 쭉 펴고 있으나, 다른쪽 knee보다 높게 들지 않은 상태
            }
            return 3;//false; //왼쪽 다리를 쭉 펴고있지 않은 상태
        }

        public static int Right()
        {
            Boolean test = Kinect_Point.points[(int)JointType.AnkleRight].X > Kinect_Point.points[(int)JointType.KneeRight].X &&
                            Kinect_Point.points[(int)JointType.KneeRight].X > Kinect_Point.points[(int)JointType.HipRight].X ? true : false;
            if (test)
            {
                //오른쪽 다리가 쭉 펴져있는 상태라면
                //중간지점인 Knee를 기준으로 다른쪽 knee보다 y가 높고 ankle과 hip y편차가 +-30인지 확인
                if (Kinect_Point.points[(int)JointType.KneeRight].Y < Kinect_Point.points[(int)JointType.KneeLeft].Y)
                {
                    test = Kinect_Point.points[(int)JointType.KneeRight].Y + 80 >= Kinect_Point.points[(int)JointType.HipRight].Y && Kinect_Point.points[(int)JointType.KneeRight].Y - 80 <= Kinect_Point.points[(int)JointType.HipRight].Y ?
                          (Kinect_Point.points[(int)JointType.KneeRight].Y + 80 >= Kinect_Point.points[(int)JointType.AnkleRight].Y && Kinect_Point.points[(int)JointType.KneeRight].Y - 80 <= Kinect_Point.points[(int)JointType.AnkleRight].Y ? true : false) : false;
                    if (test)
                    {
                        //test = Kinect_Point.points[(int)JointType.KneeLeft].X + 70 >= Kinect_Point.points[(int)JointType.HipLeft].X && Kinect_Point.points[(int)JointType.KneeLeft].X - 70 <= Kinect_Point.points[(int)JointType.HipLeft].X ?
                        //     (Kinect_Point.points[(int)JointType.KneeLeft].X + 70 >= Kinect_Point.points[(int)JointType.AnkleLeft].X && Kinect_Point.points[(int)JointType.KneeLeft].X - 70 <= Kinect_Point.points[(int)JointType.AnkleLeft].X ? true : false) : false;
                        //반대쪽 다리 x좌표를 knee기준으로 ankle과 hip이 +-20이고, y좌표가 hip보다 ankle과 knee가 아래라면 옳게 서있는 것
                        if (Kinect_Point.points[(int)JointType.HipLeft].Y < Kinect_Point.points[(int)JointType.KneeLeft].Y &&
                            Kinect_Point.points[(int)JointType.KneeLeft].Y < Kinect_Point.points[(int)JointType.AnkleLeft].Y) return 10;//true;
                        //반대쪽 다리가 제대로 서있다
                        return 3;
                    }
                    return 4;
                }
                return 4;//false;
            }
            return 4;//false;
        }
    }
}
