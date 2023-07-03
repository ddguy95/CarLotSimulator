using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator;

internal class Car
{
    public Car() 
    {

    }
    public Car(string make, string model, int year, string engineNoise, string honkNoise)
    {
        Make = make;
        Model = model;
        Year = year;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
    }

    public int Year { get; set; } = 2023;
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise {get; set;}
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }


    public void MakeEngineNoise()
    {
        Console.WriteLine($"My engine noise sounds like this: {EngineNoise}");

    }
    
    public void MakeHonkNoise(string noise)
    {
        Console.WriteLine($"My honk noise sounds like this: {noise}!!!");

    }



}
