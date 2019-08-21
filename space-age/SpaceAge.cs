using System;
using System.Collections.Generic;

public class SpaceAge
{
    private readonly int seconds;

    public SpaceAge(int seconds) => this.seconds = seconds;

    private readonly double secondsEarthYear = 31557600;

    private readonly Dictionary<string, double> planets = new Dictionary<string, double>
    {
        {"Earth", 1},
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132},
    };

    public double OnEarth() => Math.Round(seconds / (planets["Earth"] * secondsEarthYear), 2);

    public double OnMercury() => Math.Round(seconds / (planets["Mercury"] * secondsEarthYear), 2);

    public double OnVenus() => Math.Round(seconds / (planets["Venus"] * secondsEarthYear), 2);

    public double OnMars() => Math.Round(seconds / (planets["Mars"] * secondsEarthYear), 2);

    public double OnJupiter() => Math.Round(seconds / (planets["Jupiter"] * secondsEarthYear), 2);

    public double OnSaturn() => Math.Round(seconds / (planets["Saturn"] * secondsEarthYear), 2);

    public double OnUranus() => Math.Round(seconds / (planets["Uranus"] * secondsEarthYear), 2);

    public double OnNeptune() => Math.Round(seconds / (planets["Neptune"] * secondsEarthYear), 2);
}