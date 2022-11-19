namespace Mediator;
public class Program
{
    public static void Main(string[] args)
    {
        Mediator mediator = new Mediator();
        Colega usuario = new User(mediator);
        Colega admin = new UserAdmin(mediator);
        
        mediator.AgregarColegas(usuario);
        mediator.AgregarColegas(admin);

        usuario.Comunicar("Hola admin");
        admin.Comunicar("Hola usuario, que tal");
        usuario.Comunicar("Tengo un problema, podria solucionarmelo?");

    }
}

