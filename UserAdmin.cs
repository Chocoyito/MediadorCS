namespace Mediator;

public class UserAdmin : Colega
{
    public UserAdmin(IMediator mediator) : base(mediator) { }
    public override void Recibir(string mensaje)
    {
        Console.WriteLine("Un administrador dice: " + mensaje);
    }
}