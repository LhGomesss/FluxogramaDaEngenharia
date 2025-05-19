string caminho;

Console.WriteLine("O fluxograma da engenharia");

Console.WriteLine("Tá se movendo (use S para Sim e N para Não)?");
bool TaSeMovendo = Console.ReadLine()!.Substring(0, 1).Trim().ToUpper() == "S";

Console.WriteLine("Deveria se mover (use S para Sim e N para Não)?");
bool deveria = Console.ReadLine()!.Substring(0, 1).Trim().ToUpper() == "S";
// declare as variáveis e peça as infos necessárias


if (TaSeMovendo)
{
    if (deveria)
    { caminho = "Ótimo!!!!!"; }
    else
    { caminho = "Usa a fita silver tape!!!!!"; }
}
else
{
    if (deveria)
    { caminho = "Usa o WD40!!!!!"; }
    else
    { caminho = "Ótimo!!!!!"; }
}
// use if e else para todos os caminhos que são possíveis
// if1
//      if1.1
//      else1.1
// else2
//      if2.1
//      else2.1


Console.WriteLine();
Console.WriteLine(caminho);
// mensagem indicando o que a pessoa deve usar (se caso for necessário)