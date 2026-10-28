/*
AULA 02 — EXERCÍCIO 06
SISTEMA DE APROVAÇÃO DE ALUNOS

OBJETIVO:
Praticar operadores relacionais e lógicos,
entrada de dados e estruturas condicionais.

CENÁRIO:

Uma escola utiliza duas condições para
aprovar um estudante:

- Média final maior ou igual a 7.
- Frequência maior ou igual a 75%.

REQUISITOS:

1. Solicite o nome do estudante.

2. Solicite duas notas.
   As notas podem conter casas decimais.

3. Solicite a frequência do estudante
   (um número de 0 a 100).

4. Calcule a média das duas notas.

5. Verifique se o estudante atende
   às duas condições de aprovação.

6. Exiba:
   - Nome
   - Média
   - Frequência
   - Situação: Aprovado ou Reprovado

EXEMPLO:

Nome: Carlos
Nota 1: 8
Nota 2: 7
Frequência: 80

Média: 7.5
Frequência: 80%
Situação: Aprovado

REGRAS:

- Utilize Console.ReadLine().
- Utilize double.TryParse() para as notas.
- Utilize if/else.
- Utilize operadores lógicos.
- Não utilize métodos próprios ou classes.
- Considere inválidos valores fora das
  faixas permitidas (notas de 0 a 10
  e frequência de 0 a 100).

TESTES:

1. Média 8 e frequência 90: Aprovado.
2. Média 8 e frequência 60: Reprovado.
3. Média 5 e frequência 90: Reprovado.
4. Média 7 e frequência 75: Aprovado.

==================================================
*/

string nomeAluno;
double nota1;
double nota2;
double media;
int frequencia;
string situacao = "Pendente";

Console.WriteLine("Digite o nome do aluno(a)");
nomeAluno = Console.ReadLine();
Console.WriteLine("Digite a nota 1");
string nota1Texto = Console.ReadLine();
bool conversao = double.TryParse(nota1Texto, out nota1);
if (!conversao || nota1 < 0 || nota1 > 10)
{
    Console.WriteLine("Valor invalido!");
    return;
}
Console.WriteLine("Digite a nota 2");
string nota2Texto = Console.ReadLine();
conversao = double.TryParse(nota2Texto, out nota2);
if (!conversao || nota2 < 0 || nota2 > 10)
{
    Console.WriteLine("Valor invalido!");
    return;
}
Console.WriteLine("Digite a frequencia 0 - 100");
string frequenciaTexto = Console.ReadLine();
conversao = int.TryParse(frequenciaTexto, out frequencia);
if (!conversao || frequencia < 0 || frequencia > 100)
{
    Console.WriteLine("Valor invalido!");
    return;
}

media = (nota1 + nota2) / 2;
if (media >= 7 && frequencia >= 75)
{
    situacao = "Aprovado";
}
else
{
    situacao = "Reprovado";
}
Console.WriteLine($"Nome: {nomeAluno}\nMedia: {media}\nFrequencia: {frequencia}\nSituacao: {situacao}");
