class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] count = new [] {0,2,5,3,7,8,4};
        return count;
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        int newCount = Today() + 1;
        birdsPerDay[^1] = newCount;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount == 0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++){
            total = total + birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int busyDaysCount = 0;
        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount >= 5){
                busyDaysCount += 1;
            }
        }
        return busyDaysCount;
    }
}
