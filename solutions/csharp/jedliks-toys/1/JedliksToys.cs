class RemoteControlCar
{
    public int distance;
    public int percentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if (percentage == 0)
        {
            return "Battery empty";
        }
        else 
        {
            return $"Battery at {percentage}%";
        }
    }

    public void Drive()
    {
        if (percentage > 0)
        {
            distance += 20;
            percentage -= 1;
        }
    }
}
