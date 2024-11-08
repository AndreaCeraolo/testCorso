public class PersonaFactory {
    public static Persona getPersonaInstance(string nome, string cognome){
        return new Persona(nome, cognome);
    }
}