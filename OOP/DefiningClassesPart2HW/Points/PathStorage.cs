namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static string GetPathsFromFile()
        {
            StreamReader fileReader = new StreamReader("GetPaths.txt");

            string result = string.Empty;
            using (fileReader)
            {
                result = fileReader.ReadToEnd();
            }

            return result;
        }

        public static void SavePathsToFile(Point3D[] somePaths)
        {
            StreamWriter fileWriter = new StreamWriter("SavePaths.txt");

            using (fileWriter)
            {
                for (int i = 0; i < somePaths.Length; i++)
                {
                    fileWriter.WriteLine(somePaths[i]);
                }
            }
        }
    }
}