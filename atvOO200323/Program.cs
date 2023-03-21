


using atvOO200323;
using System.Reflection.PortableExecutable;

Cliente cliente = new Cliente()
{
    Id = 1,
    Nome = "Thiago",
    Telefone = "16 89898578",
    Endereco = new Endereco()
    {
        Rua = "Nove de julho",
        Num = 158,
        Bairro = "Centro"
    },

    Segmento = new Segmento()
    {
        Id = 1,
        Descricao = "Chupetinha"
    },


};
TipoMoeda usd = new TipoMoeda()
{
    Id = 1,
    Descricao = "USD"
};
Bonus bonus = new Bonus()
{
    Id = 1 ,
    Descricao = "Bonus"
};
TipoConta pessoal = new TipoConta() 
{ 
    Id=1,
    Descricao = "Conta mamal",

};
ContaCorrente contaCorrente = new ContaCorrente()
{
    Id = 1,
    Descricao = "Seila",
    TipoMoeda = usd,
    Saldo = 12.50m,
    TipoConta  = pessoal

};