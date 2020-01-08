using Microsoft.Kinect;
using System;
using System.Windows;

namespace Kitness
{
    public class Kinect_Point
    {
        public static Point[] points = new Point[20];
        public static string user_choice = "";
        public static string user_choice_name = "";
        public static Boolean kinect_c = false;
        public static Boolean start_open = false;

        public static int kinect_x = 0, kinect_y = 0;

        public static void point_set(Point[] point)
        {
            points = new Point[point.Length];
            int cnt = 0;
            foreach (Point tmp in point)
            {
                points[cnt++] = tmp;
            }
        }

        public static Boolean gostart()
        {
            Boolean test = points[(int)JointType.ShoulderRight].X < points[(int)JointType.ElbowRight].X && points[(int)JointType.ElbowRight].X < points[(int)JointType.WristRight].X ? true : false;
            if (test)
            {
                //오른쪽 팔이 쭉 펴져있는 상태라면
                //중간지점인 Elbow를 기준으로 spine보다 y가 높고 shoulder와 wrist y편차가 +-20인지 확인
                if (points[(int)JointType.Spine].Y > points[(int)JointType.ElbowRight].Y)
                {
                    test = points[(int)JointType.ElbowRight].Y + 20 >= points[(int)JointType.ShoulderRight].Y && points[(int)JointType.ElbowRight].Y - 20 <= points[(int)JointType.ShoulderRight].Y ?
                          (points[(int)JointType.ElbowRight].Y + 20 >= points[(int)JointType.WristRight].Y && points[(int)JointType.ElbowRight].Y - 20 <= points[(int)JointType.WristRight].Y ? true : false) : false;
                    if (test)
                    {
                        if (points[(int)JointType.Spine].Y < points[(int)JointType.ElbowLeft].Y) return true;
                        return false;
                        //spine의 y보다 왼쪽Elbow가 더 낮다면 모든게 옳다 넘어가자!
                    }
                    return false; //오른쪽 팔이 너무 내려가 있거나 너무 올라가있는 경우
                }
                return false; //오른쪽 팔을 쭉 펴고 있으나, spine보다 높게 들지 않은 상태
            }
            return false; //오른쪽 팔을 쭉 펴고있지 않은 상태
        }

        public static Boolean tutorial_check()
        { //튜토리얼 진행여부 확인 >> 안했으면튜토리얼창열어서진행
            try
            {
                string filepath = @"user_history\tutorial.txt"; //맨 앞에 \있으면 윈도우가 깔린 디스크 경로로 인식
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(@"user_history");
                System.IO.FileInfo file = new System.IO.FileInfo(filepath);
                if (!directory.Exists) directory.Create();
                if (!file.Exists)
                {
                    string text = "1. 원하는 운동 자세를 고릅니다.\n2. 키넥트 거리를 확보합니다.\n3. 캐릭터를 보고 자세를 따라합니다.\n";
                    text += "\n\n해당 파일은 튜토리얼을 하면 생성되는 파일입니다. 지우지 말아주세요.";
                    System.IO.File.WriteAllText(filepath, text, System.Text.Encoding.Default);
                    //파일 생성과 동시에 내용 작성
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }
            return true;
        }
    }
}
