namespace Mediator;

public class User : Colega
{
    public User(IMediator mediator) : base(mediator) { }
    public override void Recibir(string mensaje)
    {
        Console.WriteLine("Un usuario dice: " + mensaje);
    }
}

