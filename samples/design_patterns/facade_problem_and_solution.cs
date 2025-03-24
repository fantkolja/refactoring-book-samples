class TV {
    public void TurnOn() => Console.WriteLine("TV is ON");
    public void SetInput(string input) => Console.WriteLine($"TV input set to {input}");
}

class SoundSystem {
    public void TurnOn() => Console.WriteLine("Sound System is ON");
    public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
}

class DVDPlayer {
    public void TurnOn() => Console.WriteLine("DVD Player is ON");
    public void PlayMovie(string movie) => Console.WriteLine($"Playing movie: {movie}");
}

class Lights {
    public void DimLights() => Console.WriteLine("Lights dimmed for movie experience");
}

// client code without Facade

TV tv = new TV();
SoundSystem sound = new SoundSystem();
DVDPlayer dvd = new DVDPlayer();
Lights lights = new Lights();

lights.DimLights();
tv.TurnOn();
tv.SetInput("HDMI");
sound.TurnOn();
sound.SetVolume(20);
dvd.TurnOn();
dvd.PlayMovie("Inception");


// solution with Facade
class HomeTheaterFacade {
    private TV _tv;
    private SoundSystem _sound;
    private DVDPlayer _dvd;
    private Lights _lights;

    public HomeTheaterFacade(TV tv, SoundSystem sound, DVDPlayer dvd, Lights lights) {
        _tv = tv;
        _sound = sound;
        _dvd = dvd;
        _lights = lights;
    }

    public void WatchMovie(string movie) {
        Console.WriteLine("Getting ready to watch a movie...");
        _lights.DimLights();
        _tv.TurnOn();
        _tv.SetInput("HDMI");
        _sound.TurnOn();
        _sound.SetVolume(20);
        _dvd.TurnOn();
        _dvd.PlayMovie(movie);
    }
}

class Program {
    static void Main() {
        var homeTheater = new HomeTheaterFacade(new TV(), new SoundSystem(), new DVDPlayer(), new Lights());
        homeTheater.WatchMovie("Inception");
    }
}
