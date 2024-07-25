namespace DesignPatternsSamples.StructurePattern;

// Subsystem class for the TV
public class TV
{
    public void TurnOn() { Console.WriteLine("TV is on"); }
    public void TurnOff() { Console.WriteLine("TV is off"); }
}

// Subsystem class for the DVD
public class DVDPlayer
{
    public void Play() { Console.WriteLine("DVD is playing"); }
    public void Stop() { Console.WriteLine("DVD is stopped"); }
}

// Subsystem class for the sound system
public class SoundSystem
{
    public void SetVolume(int level) { Console.WriteLine($"Sound volume set to {level}"); }
}

// Facade class that simplifies the interface for the subsystems
public class HomeTheaterFacade
{
    private TV tv;
    private DVDPlayer dvd;
    private SoundSystem sound;

    public HomeTheaterFacade(TV tv, DVDPlayer dvd, SoundSystem sound)
    {
        this.tv = tv;
        this.dvd = dvd;
        this.sound = sound;
    }

    public void WatchMovie()
    {
        tv.TurnOn();
        dvd.Play();
        sound.SetVolume(10);
        Console.WriteLine("Movie is ready to watch");
    }

    public void EndMovie()
    {
        dvd.Stop();
        tv.TurnOff();
        Console.WriteLine("Movie is over");
    }
}
