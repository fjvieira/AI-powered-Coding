namespace com.fjvieira.aipoweredcoding.tdd;

public enum PedestrianLight
{
    Red,
    Green
}

public enum TrafficLight
{
    Red,
    Green,
    Yellow
}

public class SingleStreetController
{


    private TrafficLight _currentLight = TrafficLight.Red;

    private PedestrianLight _pedestrianLight = PedestrianLight.Red;

    public TrafficLight CurrentLight => _currentLight;

    public PedestrianLight PedestrianLight => _pedestrianLight;


}