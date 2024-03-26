public class Industria{
    public string nome {get; set;}
    public string localizacao {get; set;}
    public int ano_fundacao {get; set;}

    public List<LinhaProducao> producao = new List<LinhaProducao>();

    public void NovaLinha(LinhaProducao l){
        this.producao.Add(l);
    }

}