using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace ConsoleApp
{
    public class ReadJsonFile : IFileReader
    {
        public ShapesDto GetFileData()
        {
            string filePath = "C:/Users/Feng/Downloads/SEAMS Full Stack Interview Exercise/";
            ShapesDto shapes = JsonConvert.DeserializeObject<ShapesDto>(File.ReadAllText(filePath + "Shapes.json"));
            Console.WriteLine(shapes);
            return shapes;
        }
    }
}
