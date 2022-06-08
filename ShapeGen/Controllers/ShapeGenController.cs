using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace ShapeGen.Controllers;

[ApiController]
[Route("[controller]")]
public class ShapeGenController : ControllerBase
{
    private readonly ILogger<ShapeGenController> _logger;
    private readonly GenerateShapes _shapeGen;

    public ShapeGenController(ILogger<ShapeGenController> logger)
    {
        _logger = logger;
        _shapeGen = new GenerateShapes(new GenerateFeatures1());
    }

    [HttpGet(Name = "GetShapes")]
    public IEnumerable<ReturnedShape> Get(int min, int max)
    {
        var shapes = _shapeGen.GetRandomShapes(min, max);
        return Enumerable.Range(1, 3).Select(index => new ReturnedShape
        {
            points = shapes[index].GetAllPoints()
        }).ToArray();
        /*var returnedShapes = new List<ReturnedShape>();
        var returnedPoints = new List<List<ReturnedPoint>>();
        for (var i = 0; i < shapes.Count; i++)
        {
            var points = shapes[i].GetAllPoints();
            var returnedShape = new ReturnedShape();
            returnedPoints.Add(new List<ReturnedPoint>());
            for (var j = 0; j < points.Count; j++)
            {
               returnedShape.points.Add(new ReturnedPoint((decimal)points[j].GetX(), (decimal)points[j].GetY()));
               returnedPoints[i].Add(new ReturnedPoint((decimal)points[j].GetX(), (decimal)points[j].GetY()));
            }

            returnedShapes.Add(returnedShape);
        }

        return returnedPoints.ToArray();*/

        /*return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();*/
    }
}
