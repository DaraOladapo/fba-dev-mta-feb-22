namespace Statics{
    class Program{
        static void Main(string[] args){
            Register();
            ResetPassword();
        }
        static void Register(){
            //call method
            EmailService.SendEmail("someone@example.com", "some@example.com", "Hello", "Hello World");
        }
        static void ResetPassword(){
            //call method
            EmailService.SendEmail("someone@example.com", "some@example.com", "Hello", "Hello World");
        }
    }
}