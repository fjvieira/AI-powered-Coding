using System;

namespace com.fjvieira.aipoweredcoding.unittesting;

public enum FuelType
{
    GASOLINE,
    ALCOHOL
}

public enum TripType
{
    CITY,
    HIGHWAY
}


    public class CarRules
    {

        // Based on the current odometer value and the last revision date, write code that determines if it is time to schedule a new revision.
        // Revision rule: Every 12 months or 10,000 kilometers, whichever comes first
        public bool ShouldScheduleReview(int currentOdometer, int lastRevisionOdometer, DateTime lastRevisionDate)
        {
            // KM difference
            int kilometers = currentOdometer - lastRevisionOdometer;
            // Check if is older than 12 months
            int months = (DateTime.Now.Year - lastRevisionDate.Year) * 12 + DateTime.Now.Month - lastRevisionDate.Month;

            return months >= 12 || kilometers >= 10000;
        }

        // Calculate true efficiency based on distance traveled, fuel consumed, fuel type, and trip type
        public double CalculateTrueEfficiency(double distanceTraveled, double fuelConsumed, FuelType fuelType, TripType tripType)
        {
            if (fuelConsumed <= 0)
            {
                throw new ArgumentException("Fuel consumed must be greater than zero.");
            }

            double baseEfficiency = GetBaseEfficiency(fuelType, tripType);

            double actualEfficiency = distanceTraveled / fuelConsumed;
            return actualEfficiency / baseEfficiency;
        }

        // Calculate autonomy based on fuel in tank, fuel type, and trip type
        public double CalculateAutonomy(double fuelInTank, FuelType fuelType, TripType tripType)
        {
            double efficiency = GetBaseEfficiency(fuelType, tripType);

            return fuelInTank * efficiency;
        }

        private static double GetBaseEfficiency(FuelType fuelType, TripType tripType)
        {
            return fuelType switch
            {
                FuelType.GASOLINE => (tripType == TripType.CITY) ? 12 : 15,
                FuelType.ALCOHOL => (tripType == TripType.CITY) ? 8 : 10,
                _ => throw new ArgumentOutOfRangeException(nameof(fuelType), fuelType, null)
            };
        }
    }
