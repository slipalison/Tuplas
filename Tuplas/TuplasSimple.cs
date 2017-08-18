namespace Tuplas
{
    public class TuplasSimple
    {
        public static (string, string, string) LookupName(long id) {
         
            switch (id) {
                case 1:
                    return ("Primeiro", "Segundo", "Terceiro");
                case 2:
                    return ("123","Oliveira", "quatro");
                default:
                    return ("Sem","Nome","Aqui");

            }
        }
    }
}
