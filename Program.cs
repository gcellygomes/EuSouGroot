//Exercicio EuSouGroot - GicellyGomes
﻿string FraseParaSair = "tchau";

Console.WriteLine("--- Groot Chatbot ---\n");

string pergunta;
do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;

    string resposta = ObtemRespostaGroot(pergunta);

    ExibeResposta(ObtemRespostaGroot(pergunta));

}
while (pergunta.Trim().ToLower() != FraseParaSair);

void ExibeResposta(string resposta)
{
    Console.WriteLine($"            Resposta: {resposta}");
}

string ObtemRespostaGroot(string pergunta)
{
    return pergunta.Trim().ToLower() == FraseParaSair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}