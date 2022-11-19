namespace Mediator;
class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new Mediator();
        IColega usuario = new User(mediator);
        IColega admin = new UserAdmin(mediator);
        
        mediator.AgregarColegas(usuario);
        mediator.AgregarColegas(admin);

        usuario.Comunicar("Hola admin");
        admin.Comunicar("Hola usuario, que tal");

    }
}

