using System;
using System.IO;

namespace Milana1
{
    class Program
    {
        private static string fileOldPath;

        static void Main(string[] args)
        {
            //MoveApples();
            //MovePineapples();
            //MoveBananas();
            //MoveCucumbers();
            //MoveOnions();
            MovePotatos();
        }
        public static void MoveApples()
        {
            string filePath = @"C:\Users\opilane\samples\Friday";
            string newFilePath = @"C:\Users\opilane\samples\Friday\fruit";
            string fileName = @"apples.txt";

            string fileOldPath = Path.Combine(filePath, fileName);

            string newPath = Path.Combine(newFilePath, fileName);
            
                File.Move(fileOldPath, newPath);


        }
        public static void MovePineapples()
        {
            string filePath = @"C:\Users\opilane\samples\Friday";
            string newFilePath = @"C:\Users\opilane\samples\Friday\fruit";
            string fileName = @"pineapples.txt";

            string fileOldPath = Path.Combine(filePath, fileName);

            string newPath = Path.Combine(newFilePath, fileName);

            File.Move(fileOldPath, newPath);
        }

        public static void MoveBananas()
        {
            string filePath = @"C:\Users\opilane\samples\Friday";
            string newFilePath = @"C:\Users\opilane\samples\Friday\fruit";
            string fileName = @"bananas.txt";

            string fileOldPath = Path.Combine(filePath, fileName);

            string newPath = Path.Combine(newFilePath, fileName);

            File.Move(fileOldPath, newPath);
        }

        public static void MoveCucumbers()
        {
            string filePath = @"C:\Users\opilane\samples\Friday";
            string newFilePath = @"C:\Users\opilane\samples\Friday\vegetables";
            string fileName = @"cucumbers.txt";

            string fileOldPath = Path.Combine(filePath, fileName);

            string newPath = Path.Combine(newFilePath, fileName);

            File.Move(fileOldPath, newPath);
        }
        public static void MoveOnions()
        {
            string filePath = @"C:\Users\opilane\samples\Friday";
            string newFilePath = @"C:\Users\opilane\samples\Friday\vegetables";
            string fileName = @"onions.txt";

            string fileOldPath = Path.Combine(filePath, fileName);

            string newPath = Path.Combine(newFilePath, fileName);

            File.Move(fileOldPath, newPath);
        }

        public static void MovePotatos()
        {
            string filePath = @"C:\Users\opilane\samples\Friday";
            string newFilePath = @"C:\Users\opilane\samples\Friday\vegetables";
            string fileName = @"potatos.txt";

            string fileOldPath = Path.Combine(filePath, fileName);

            string newPath = Path.Combine(newFilePath, fileName);

            File.Move(fileOldPath, newPath);
        }

    }
}
