namespace Mediator;

class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new Mediator();
        IColega oPepe = new User(mediator);
        IColega oAdmin = new UserAdmin(mediator);
        
        mediator.AgregarColegas(oPepe);
        mediator.AgregarColegas(oAdmin);

        oPepe.Comunicar("Hola admin");
        oAdmin.Comunicar("Hola admin");

    }
}

