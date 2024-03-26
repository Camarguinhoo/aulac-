public class LinhaProducao{
    public int numero {get; set;}
    public string tipo_produto {get; set;}
    public int capacidade {get; set;}

    public List<Maquina> maquina = new List<Maquina>();

    public void AdicionarMaquina(Maquina m){
        this.maquina.Add(m);
    }
}