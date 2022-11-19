namespace Mediator;

public class UserAdmin : IColega
{
    public UserAdmin(IMediator mediator) : base(mediator)
    {
        
    }
    public override void Recibir(string mensaje)
    {
        Console.WriteLine("Un administrador recibi: " + mensaje);
    }
}