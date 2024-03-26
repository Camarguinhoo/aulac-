
Industria industria = new Industria();

industria.nome = "Bosch";
industria.localizacao = "Brasil";
industria.ano_fundacao = 1800;

LinhaProducao linha = new LinhaProducao();

linha.numero = 2;
linha.tipo_produto = "Carros";
linha.capacidade = 10;

Maquina maquina = new Maquina();

maquina.id = 1;
maquina.marca = "mocrimbas";
maquina.modelo = "premium";

Produto produto = new Produto();

produto.nome = "Caminhao v3";
produto.codigo = 69;
produto.preco = 1000000;

industria.NovaLinha(linha);

foreach(var l in industria.producao){
    Console.WriteLine(l.numero + " " + l.tipo_produto + " " + l.capacidade);
}









