using System;
using System.Collections.Generic;

public class GestorBlocos
{
    private List<Bloco> blocos;

    // Construtor para inicializar a lista de blocos
    public GestorBlocos()
    {
        blocos = new List<Bloco>();
    }

    // Método para adicionar um bloco à lista
    public void AdicionarBloco(Bloco bloco)
    {
        blocos.Add(bloco);
    }

    // Método para remover um bloco da lista
    public void RemoverBloco(Bloco bloco)
    {
        blocos.Remove(bloco);
    }

    // Método para listar todos os blocos
    public List<Bloco> ListarBlocos()
    {
        return blocos;
    }
}
