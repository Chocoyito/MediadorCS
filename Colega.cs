namespace Mediator;

public class Colega : IColega
{
    private IMediator mediator;

    protected Colega(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public void Comunicar(string mensaje)
    {
        this.mediator.Enviar(mensaje, this);
    }

    public virtual void Recibir(string mensaje)
    {
        Console.WriteLine("Mensaje del usuario: " + mensaje);
    }
}