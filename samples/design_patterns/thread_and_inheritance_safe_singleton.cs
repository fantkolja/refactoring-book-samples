sealed class Singleton
{
  private static Singleton? _instance;
  private static object _refObj = new object();

  private Singleton()
  {
    Console.WriteLine("Initializing Singleton");
  }

  public static Singleton GetInstance()
  {
    if (Singleton._instance == null) {
      lock(Singleton._refObj)
      {
        if (Singleton._instance == null) {
          Singleton._instance = new Singleton();
        }
      }
    }
    return Singleton._instance;
  }
}