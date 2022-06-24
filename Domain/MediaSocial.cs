
namespace Domain
{
    public class MediaSocial
    {
        private readonly string _nomeRedeSocial;

        public MediaSocial(string nomeRedeSocial, ConsoleColor color)
        {
            _nomeRedeSocial = nomeRedeSocial;
            Console.ForegroundColor = color;
        }

        public void Post(string title, string body)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine(this._nomeRedeSocial);
            Console.WriteLine(title);
            Console.WriteLine(body);
            
        }

        public void Like(string publicacao)
        {
            Console.WriteLine($"A {publicacao} foi curtida no {this._nomeRedeSocial}");
            Console.WriteLine("=====================================");
        }
    }
}
