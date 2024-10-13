package com.fjvieira.aipoweredcoding.unittesting;


import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class CarRules {

    public enum FuelType {
        GASOLINE,
        ALCOHOL
    }

    public enum TripType {
        CITY,
        HIGHWAY
    }

    //Based on the current odometer value and the last revision date, write code that determines if it is time to schedule a new revision.
    //Revision rule: Every 12 months or 10,000 kilometers, whichever comes first
    public boolean shouldScheduleReview(int currentOdometer, int lastRevisionOdometer, LocalDate lastRevisionDate) {
        //KM difference
        int kilometers = currentOdometer - lastRevisionOdometer;
        //Check if is older than 12 months
        long months = ChronoUnit.MONTHS.between(lastRevisionDate, LocalDate.now());

        return months >= 12 || kilometers >= 10000;
    }

    // Calculate true efficiency based on distance traveled, fuel consumed, fuel type, and trip type
    public double calculateTrueEfficiency(double distanceTraveled, double fuelConsumed, FuelType fuelType, TripType tripType) {
        if (fuelConsumed <= 0) {
            throw new IllegalArgumentException("Fuel consumed must be greater than zero.");
        }

        double baseEfficiency = getBaseEfficiency(fuelType, tripType);

        double actualEfficiency = distanceTraveled / fuelConsumed;
        return actualEfficiency / baseEfficiency;
    }

    // Calculate autonomy based on fuel in tank, fuel type, and trip type
    public double calculateAutonomy(double fuelInTank, FuelType fuelType, TripType tripType) {
        double efficiency = getBaseEfficiency(fuelType, tripType);

        return fuelInTank * efficiency;
    }

    private static double getBaseEfficiency(FuelType fuelType, TripType tripType) {
        return switch (fuelType) {
            case GASOLINE -> (tripType == TripType.CITY) ? 12 : 15;
            case ALCOHOL -> (tripType == TripType.CITY) ? 8 : 10;
        };
    }

}
