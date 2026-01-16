class RemoteControlCar
{
    public int distanceTravelled;
    public int speed;
    public int batteryDrain;
    public int currentBattery = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if ((currentBattery <= 0) || (batteryDrain > currentBattery))
        {
            return true;
        }

        return false;
    }

    public int DistanceDriven()
    {
        return distanceTravelled;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceTravelled += speed;
            currentBattery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    public int distance;
    
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var reachedDistance = false;
        var enoughBattery = true;

        while (!reachedDistance)
        {
            if (car.distanceTravelled == distance)
            {
                reachedDistance = true;
            }
            else if (car.BatteryDrained())
			{
				enoughBattery = false;
                reachedDistance = true;
			}
            else 
            {
                car.Drive();
            }
        
        }
        return enoughBattery;
    }
}
