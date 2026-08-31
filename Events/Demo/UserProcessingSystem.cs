namespace _Demo
{
    public class UserProcessor
    {
        public static event EventHandler<UserArgs> userProcessorEvent;

        public static void ProcessUser(string name , int age)
        {
            // 1st we need to create UserArgs
            UserArgs args =  new UserArgs();
            args.Name =  name;
            args.Age =  age;

            userProcessorEvent?.Invoke(null, args);
        }
    }
    
}