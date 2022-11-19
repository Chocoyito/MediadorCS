namespace Mediator;

public abstract class Colega : IColega
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

    public abstract void Recibir(string mensaje);
}