using System;
using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color) => Array.FindIndex(colorArray, s => s == color);

    //Needed to pass the last test
    public static string[] Colors() => colorArray; 

    private static readonly string[] colorArray = new string[]{
                                                    "black",
                                                    "brown",
                                                    "red",
                                                    "orange",
                                                    "yellow",
                                                    "green",
                                                    "blue",
                                                    "violet",
                                                    "grey",
                                                    "white"
                                                    };
}