namespace Mediator;

public class Colega : IColega
{
    private IMediator _mediator;

    protected Colega(IMediator mediator)
    {
        this._mediator = mediator;
    }

    public void Comunicar(string mensaje)
    {
        this._mediator.Enviar(mensaje, this);
    }

    public virtual void Recibir(string mensaje)
    {
        Console.WriteLine("Mensaje del usuario: " + mensaje);
    }
}