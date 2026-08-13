using System;

class CircularTourProblem
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int totalPetrol = 0;
        int totalDistance = 0;

        int start = 0;
        int currentPetrol = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            totalPetrol += petrol[i];
            totalDistance += distance[i];

            currentPetrol += petrol[i] - distance[i];

            if (currentPetrol < 0)
            {
                start = i + 1;
                currentPetrol = 0;
            }
        }

        if (totalPetrol >= totalDistance)
        {
            return start;
        }

        return -1;
    }
}