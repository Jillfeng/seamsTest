using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class TransformShapes
    {
        IFileReader shapeData;
        public void ShapeTransform()
        {
            var shapes = shapeData.GetFileData();
            var transforms = GetTransformsData();
            var xValue = Math.Sqrt(transforms.Translate1.OffSetX * transforms.Translate1.OffSetX
                                    + transforms.Translate1.OffSetY * transforms.Translate1.OffSetX)
                                    * Math.Cos(Math.Atan(transforms.Translate2.OffSetY / transforms.Translate2.OffSetX)
                                    + transforms.Rotate.Angle);

            var yValue = Math.Sqrt(transforms.Translate1.OffSetX * transforms.Translate1.OffSetX
                                    + transforms.Translate1.OffSetY * transforms.Translate1.OffSetY)
                                    * Math.Sin(Math.Atan(transforms.Translate2.OffSetY / transforms.Translate2.OffSetX)
                                    + transforms.Rotate.Angle);
            var circle = new CircleOutDto()
            {
                ShapeType = shapes.Circle.ShapeType,
                CenterX = shapes.Circle.CenterX,
                CenterY = shapes.Circle.CenterY,
                Radius = shapes.Circle.Radius,
                XValue = xValue,
                YValue = yValue
            };
            Console.WriteLine(circle);
            foreach(var rec in shapes.Rectangle)
            {
                var rectangle = new RectangleOutDto()
                {
                    ShapeType = rec.ShapeType,
                    Top = rec.Top,
                    Left = rec.Left,
                    Bottom = rec.Bottom,
                    Right = rec.Right,
                    XValue = xValue,
                    YValue = yValue
                };
                Console.WriteLine(rectangle);
            }
            var triangle = new TriangleOutDto()
            {
                ShapeType = shapes.Triangle.ShapeType,
                X1 = shapes.Triangle.X1,
                Y1 = shapes.Triangle.Y1,
                X2 = shapes.Triangle.X2,
                Y2 = shapes.Triangle.Y2,
                X3 = shapes.Triangle.X3,
                Y3 = shapes.Triangle.Y3,
                XValue = xValue,
                YValue = yValue
            };
            Console.WriteLine(triangle);
        }
        private TransformsDto GetTransformsData()
        {
            string filePath = "C:/Users/Feng/Downloads/SEAMS Full Stack Interview Exercise/";
            TransformsDto transforms = JsonConvert.DeserializeObject<TransformsDto>(File.ReadAllText(filePath + "transforms.json"));
            return transforms;
        }
    }
}
