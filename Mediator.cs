namespace Mediator;

public class Mediator : IMediator
{
    private List<Colega> _colegas;

    public Mediator()
    {
        _colegas = new List<Colega>();
    }

    public void AgregarColegas(Colega colega)
    {
        this._colegas.Add(colega);
    }

    public void Enviar(string mensaje, Colega _colega)
    {
        foreach (var c in 
                 this._colegas.Where(c => _colega != c))
        {
            _colega.Recibir(mensaje);
        }
    }
}