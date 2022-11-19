namespace Mediator;

public abstract class IColega
{
    private IMediator mediator;

    public IColega(IMediator mediator)
    {
        this.mediator = mediator;
    }
    
    public void Comunicar(string mensaje)
    {
        this.mediator.Enviar(mensaje, this);
    }

    public abstract void Recibir(string mensaje);
}