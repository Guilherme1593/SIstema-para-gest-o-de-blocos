using System;

public class Bloco
{
    // Propriedades para armazenar informações sobre o bloco
    public string Nome { get; set; }
    public double Comprimento { get; set; }
    public double Largura { get; set; }
    public double Espessura { get; set; }
    public string Material { get; set; }
    public string? Numero { get; internal set; }
    public double ValorCompra { get; internal set; }
    public double ValorVenda { get; internal set; }

    // Construtor para criar um objeto Bloco com dados iniciais
    public Bloco(string nome, double comprimento, double largura, double espessura, string material)
    {
        Nome = nome;
        Comprimento = comprimento;
        Largura = largura;
        Espessura = espessura;
        Material = material;
    }

    // Método para calcular o volume do bloco
    public double CalcularVolume()
    {
        return Comprimento * Largura * Espessura;
    }

    // Sobrescrevendo o método ToString para exibir informações do bloco
    public override string ToString()
    {
        double lucro = CalcularLucro();
        return $"{Nome} - Material: {Material}, Dimensões: {Comprimento}x{Largura}x{Espessura} mm, Lucro de Venda: {lucro:C}";
    }
   

    // Dentro da classe Bloco
    public double CalcularLucro()
    {
        // Calcula o lucro subtraindo o custo de compra do valor de venda
        return ValorVenda - ValorCompra;
    }

}
