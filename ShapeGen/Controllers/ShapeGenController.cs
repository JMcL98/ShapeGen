using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace ShapeGen.Controllers;

[ApiController]
public class ShapeGenController : ControllerBase
{
    private readonly ILogger<ShapeGenController> _logger;
    private readonly GenerateShapes _shapeGen;

    public ShapeGenController(ILogger<ShapeGenController> logger)
    {
        _logger = logger;
        _shapeGen = new GenerateShapes(new GenerateFeatures1());
    }

    [HttpGet]
    [Route("/ShapeGen")]
    public IEnumerable<ReturnedShape> Get(int min, int max)
    {
        var shapes = _shapeGen.GetRandomShapes(min, max);
        var returnedShapes = new List<ReturnedShape>();
        foreach (var shape in shapes)
        {
            returnedShapes.Add(new ReturnedShape(shape.GetAllPoints())
            {
                Aliased = shape.GetAliased()
            });
        }

        return returnedShapes;
    }
}
