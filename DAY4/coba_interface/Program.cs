// See https://aka.ms/new-console-template for more information
using System;

namespace CobaInterface
{
    class Program
    {
        static void Main()
        {   
            Console.WriteLine("Masukkan arah gerak (maju, mundur, geser) : ");
            string moveDirection = Console.ReadLine();

            Console.WriteLine("Masukkan jarak gerak (meter) : ");
            int distance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan arah belok (kanan, kiri) : ");
            string turnDirection = Console.ReadLine();

            Console.WriteLine("Masukkan teks pada layar robot: ");
            string screenText = Console.ReadLine();

            RobotSemut robotSemut1 = new RobotSemut();

            Console.WriteLine("==============================================================");
            robotSemut1.Move(ref moveDirection, ref distance);
            robotSemut1.Turn(ref turnDirection);
            robotSemut1.DisplayRobot(ref moveDirection, ref distance, ref turnDirection);
            robotSemut1.DisplayScreen(ref screenText);
            Console.WriteLine("==============================================================");

            RobotKuda robotKuda1 = new RobotKuda();

            Console.WriteLine("==============================================================");
            robotKuda1.Move(ref moveDirection, ref distance);
            robotKuda1.Turn(ref turnDirection);
            robotKuda1.DisplayRobot(ref moveDirection, ref distance, ref turnDirection);
            robotKuda1.DisplayScreen(ref screenText);
            Console.WriteLine("==============================================================");
        }
    }

    public interface IRobot
    {
        void Move(ref string moveDirection, ref int distance); // bergerak maju mundur geser
        void Turn(ref string turnDirection); // belok kanan kiri
    }

    public interface CommonRobot
    {
        void DisplayScreen(ref string screenText); // menampilkan teks pada layar robot
    }

    public class RobotSemut : IRobot, CommonRobot
    {
        public void Move(ref string moveDirection, ref int distance)
        {
            Console.WriteLine($"Robot bergerak {moveDirection} sejauh {distance} meter");
        }

        public void Turn(ref string turnDirection)
        {
            Console.WriteLine($"Robot berbelok {turnDirection}");
        }

        public void DisplayRobot(ref string moveDirection, ref int distance, ref string turnDirection)
        {
            Console.WriteLine($"Robot Semut bergerak {moveDirection} sejauh {distance} meter kemudian berbelok {turnDirection}");
        }

        public void DisplayScreen(ref string screenText)
        {
            Console.WriteLine($"{screenText}");
        }

    }

    public class RobotKuda : RobotSemut
    {
        public void DisplayRobot(ref string moveDirection, ref int distance, ref string turnDirection)
        {
            Console.WriteLine($"Robot Kuda bergerak {moveDirection} sejauh {distance} meter kemudian berbelok {turnDirection}");
        }
    }

}
