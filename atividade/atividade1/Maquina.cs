public class Maquina{
    public int id {get; set;}
    public string marca {get; set;}
    public string modelo {get; set;}

    public List<Produto> produto = new List<Produto>();

    public void IniciarProd(Produto p){
        this.produto.Add(p);
    }
}