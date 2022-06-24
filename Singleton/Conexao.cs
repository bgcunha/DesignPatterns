namespace Singleton;
public sealed class Conexao
{
    private static Conexao? _instance = null;
    private static readonly object SyncObj = new object();
    private Conexao()
    {

    }

    public static Conexao GetInstance()
    {
        if (_instance != null)
            return _instance;

        lock (SyncObj)
        {
            if (_instance == null)
                _instance =  new Conexao();

            return _instance;

        };


    }

}
