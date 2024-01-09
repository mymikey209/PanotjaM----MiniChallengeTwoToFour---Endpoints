using Microsoft.AspNetCore.Mvc;

namespace TwoNumber.controller;


[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    int number1;
    int number2;
    public List<string> adding = new();
    [HttpGet]
    [Route("returm/{number1}/{number2}")]
    public List<string> Hello(int number1 , int number2)
    {
        
        int sum = number1 + number2;
        adding.Add($"the sum of, {number1} and {number2} = {sum}");
        return adding;
    }

}
