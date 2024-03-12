/*Instanciar um objeto aluno do tipo Estudante
Estudante aluno = 
    new Estudante("R123", "Pedro de Lara");

Estudante aluno2 =
    new Estudante("qwe", "Ariana Grande");

Console.WriteLine(aluno.Nome + " " + aluno.Rgm);
Console.WriteLine(aluno2.Nome + " " + aluno2.Rgm);*/








//Implementacao de listas de objetos

class Program{
    static void Main(){
        List <Estudante> estudantes = new List<Estudante>();
        //Construir 3 estudantes e adicionar na lista de estudantes
        Estudante aluno;
        for(int i = 0; i < 3; i++){
            aluno = new Estudante("R " + i, "Nome " + i);
            estudantes.Add(aluno);
            //Console.WriteLine(aluno.Rgm + " " + aluno.Nome);
        }
        
        //Imprimir os dados que estao dentro da lista estudantes 
        Console.WriteLine("Depois de adicionar os alunos na lista");
        Console.WriteLine("Iniciando a impressao dos dados dos alunos que estao na lista");
        foreach(var estudante in estudantes){
            Console.WriteLine(estudante.Rgm + " " + estudante.Nome);
        }
    }
}
