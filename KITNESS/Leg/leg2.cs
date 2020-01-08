using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kitness.Leg
{

    class leg2 // 한쪽 무릎 옆으로 구부리기
    {
        public static int Left()
        {   // 왼쪽 무릎 X < 왼쪽 엉덩이 X 
            if (Kinect_Point.points[(int)JointType.KneeLeft].X < Kinect_Point.points[(int)JointType.HipLeft].X &&
                Kinect_Point.points[(int)JointType.AnkleLeft].X < Kinect_Point.points[(int)JointType.KneeLeft].X &&
                Kinect_Point.points[(int)JointType.KneeLeft].Y <= Kinect_Point.points[(int)JointType.HipLeft].Y + 130) // 왼쪽다리 ↙
            {
                if (Kinect_Point.points[(int)JointType.KneeRight].X > Kinect_Point.points[(int)JointType.HipRight].X &&
                    Kinect_Point.points[(int)JointType.AnkleRight].X < Kinect_Point.points[(int)JointType.KneeRight].X + 70 &&
                    Kinect_Point.points[(int)JointType.AnkleRight].X > Kinect_Point.points[(int)JointType.KneeRight].X - 70 &&
                    Kinect_Point.points[(int)JointType.KneeRight].Y <= Kinect_Point.points[(int)JointType.HipRight].Y + 70) return 10;//true; // 오른쪽 ㄱ
                return 4; //오른쪽 다리 틀림
            }
            return 3;//false; //왼쪽 다리 틀림
        }

        public static int Right()
        {
            // 오른쪽 무릎 X < 오른쪽 엉덩이 X 
            if (Kinect_Point.points[(int)JointType.KneeRight].X > Kinect_Point.points[(int)JointType.HipRight].X &&
                Kinect_Point.points[(int)JointType.AnkleRight].X > Kinect_Point.points[(int)JointType.KneeRight].X &&
                Kinect_Point.points[(int)JointType.KneeRight].Y <= Kinect_Point.points[(int)JointType.HipRight].Y + 130) // 오른쪽다리 ↙
            {
                if (Kinect_Point.points[(int)JointType.KneeLeft].X < Kinect_Point.points[(int)JointType.HipLeft].X &&
                    Kinect_Point.points[(int)JointType.AnkleLeft].X < Kinect_Point.points[(int)JointType.KneeLeft].X + 70 &&
                    Kinect_Point.points[(int)JointType.AnkleLeft].X > Kinect_Point.points[(int)JointType.KneeLeft].X - 70 &&
                    Kinect_Point.points[(int)JointType.KneeRight].Y <= Kinect_Point.points[(int)JointType.HipLeft].Y + 70) return 10;//true; // 왼쪽 ㄱ
                return 3; //왼쪽 다리 틀림
            }
            return 4;//false; //오른쪽 다리 틀림
        }
    }
}