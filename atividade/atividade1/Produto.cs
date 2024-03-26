public class Produto{
    public string nome {get; set;}
    public int codigo {get; set;}
    public float preco {get; set;}

    public List<Produto> precos = new List<Produto>();

    public void NovoPreco(Produto p){
        this.precos.Add(p);
    }
}