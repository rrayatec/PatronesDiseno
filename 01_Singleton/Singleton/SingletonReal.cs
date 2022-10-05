namespace Patrones
{
    class LoadBalancer
    {
        private static LoadBalancer? _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();
        // Lock synchronization object
        private static object syncLock = new object();
        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }
        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instance == null)
            {
                lock (syncLock)
                //https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/lock
                //La instrucción lock adquiere el bloqueo de exclusión mutua de un objeto determinado, ejecuta un bloque de instrucciones y luego libera el bloqueo. Mientras se mantiene un bloqueo, el subproceso que lo mantiene puede volver a adquirir y liberar el bloqueo. Ningún otro subproceso puede adquirir el bloqueo y espera hasta que se libera
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
                Console.WriteLine(syncLock.ToString());
            }
            return _instance;
        }
        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}