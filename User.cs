namespace Mediator;

public class User : IColega
{
    public User(IMediator mediator) : base(mediator)
    {
        
    }
    public override void Recibir(string mensaje)
    {
        Console.WriteLine("Un usuario recibe: " + mensaje);
    }
}

