namespace Mediator;

public class Mediator : IMediator
{
    private List<IColega> _colegas;

    public Mediator()
    {
        _colegas = new List<IColega>();
    }

    public void AgregarColegas(IColega colega)
    {
        this._colegas.Add(colega);
    }

    public void Enviar(string mensaje, IColega _colega)
    {
        foreach (var c in this._colegas.Where(c => _colega != c))
        {
            _colega.Recibir(mensaje);
        }
    }
}