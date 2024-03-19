
//Instanciar uma Universidade
Universidade objUniversidade = new Universidade();
objUniversidade.nome = "UP";
objUniversidade.localizacao = "Ecoville";
objUniversidade.anofundacao = 1990;

//Criar o curso ADS e adicionar na universidade
Curso objCurso = new Curso();
objCurso.nome = "Analise e Desenvolvimento de Sistemas";
objUniversidade.AdicionarCurso(objCurso);

//Criar o curso BSI e adicionar na universidade
objCurso = new Curso();
objCurso.nome = "BSI";
objUniversidade.AdicionarCurso(objCurso);


Console.WriteLine(objUniversidade.nome);
foreach(var curso in objUniversidade.cursos){
    Console.WriteLine(curso.nome);
}





