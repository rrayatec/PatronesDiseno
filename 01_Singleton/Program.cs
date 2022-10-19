// un solo logger para una actividad
//evitamos crear los New Singleton
namespace Patrones
{
    class MainApp
    {
        static void Main()
        {
            Singleton? s1 = Singleton.Instance();
            Singleton? s2 = Singleton.Instance();


            if (s1 == s2)
            {
                Console.WriteLine("Son iguales");
            }

            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?vi

            if (b1 == b2 && b2 == b3 && b3 == b4)

            {

                Console.WriteLine("Same instance\n");

            }



            // Load balance 15 server requests

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 5; i++)
            {
                string server = balancer.Server;

                Console.WriteLine("Pasar solicitud a : " + server);
            }

            //Console.ReadKey();
        }
    }
}