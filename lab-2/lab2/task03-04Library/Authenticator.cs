namespace task03Library
{
    public sealed class Authenticator
    {
        private static readonly object lockObject = new object();
        private static Authenticator instance;

        private Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Authenticator();
                        }
                    }
                }
                return instance;
            }
        }

        public void AuthenticateUser(string username, string password)
        {
            Console.WriteLine($"Authenticating user: {username} with password: {password}");
        }
    }
}
