// . /turma.cs
public class Turma{
    public int anoformacao{get; set;}

    public string turno{get; set;}

    public string sala{get; set;}

    public List<Estudante> estudantes = new List<Estudante>();

    //Metodo adicionar estudante
    //Recebe um estudante
    //Adiciona o estudante na lista estudantes
    public void AdicionarEstudante(Estudante e){
        this.estudantes.Add(e);
    }
}