using System;

public class Television
{
    // * required fields
    private static string manufacturer;
    private static int screenSize;
    private bool powerOn;
    private int channel;
    private int volume;

// * Constructor: Television
    // ! The constructor accepts two arguments: a string containing the brand name and an integer containing the screen size.
    public Television(string brand, int size)
    {
        manufacturer = brand;
        screenSize = size;
        powerOn = false;
        volume = 20;
        channel = 2;
    }

// * Accessors
    public int GetVolume()
    {
        return volume; //returns the value of the field volume
    }

    public int GetChannel()
    {
        return channel;     //returns the value of the field channel
    }

    public string GetManufacturer()
    {
        return manufacturer; //returns the value of the field manufacturer
    }

    public int GetScreenSize()
    {
        return screenSize; //returns the value of the field screenSize
    }

// * Mutators
    public void SetChannel(int station)
    {
        channel = station; //channel is set to the value of station
    }

    public void Power()
    {
        powerOn = !powerOn; //boolean value is flipped
    }

    public void IncreaseVolume()
    {
        volume++;   //volume is increased by 1
    }

    public void DecreaseVolume()
    {
        volume--;  //volume is decreased by 1
    }

    public override string ToString()
    {
        if (powerOn)
        {
            return "A " + screenSize + " inch " + manufacturer + " has been turned on";
        }
        else
        {
            return "A " + screenSize + " inch " + manufacturer + " has been turned off";
        }
    }
}
