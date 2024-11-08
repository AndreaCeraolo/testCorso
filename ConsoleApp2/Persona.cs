public class Persona
{
    public Persona(string nome, string cognome)
    {
        Nome = nome;
        Cognome = cognome;
    }

    public Persona(){
        
    }

    public override string ToString() {
        return $"{Nome} {Cognome}";
    }

    public string Nome { get; set; }
    public string Cognome { get; set; }

}