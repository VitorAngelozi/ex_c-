/*
==================================================
AULA 03 — ESTRUTURAS DE REPETIÇÃO
EXERCÍCIO 04 — VALIDAÇÃO COM WHILE
==================================================

OBJETIVO:
Compreender como utilizar while para repetir
uma operação até que uma condição seja atendida.

CENÁRIO:

Um sistema precisa receber um número inteiro
entre 1 e 10.

REQUISITOS:

1. Solicite um número ao usuário.

2. Utilize int.TryParse() para verificar
   se a entrada representa um inteiro.

3. Se o valor não estiver entre 1 e 10,
   informe que a entrada é inválida.

4. Continue solicitando outro número
   enquanto a entrada for inválida.

5. Quando o usuário informar um número
   válido, exiba:

   "Número aceito: X"

6. Encerre a repetição após receber
   um número válido.

EXEMPLO:

Digite um número: 20
Número inválido.

Digite um número: abc
Número inválido.

Digite um número: 5
Número aceito: 5

REGRAS:

- Utilize obrigatoriamente while.
- Utilize int.TryParse().
- Não utilize for.
- Não utilize métodos próprios.
- Não utilize arrays ou listas.
- Não utilize return para encerrar
  o programa após uma entrada inválida.

==================================================
*/
Console.Write("Digite um número: ");
string numTexto = Console.ReadLine();
bool conversao = int.TryParse(numTexto, out int num);

string numTexto = Console.ReadLine();
bool conversao = int.TryParse(numTexto, out int num);

while(num < 1 || num > 10 || !conversao)
{
    Console.WriteLine("Número inválido.");
    Console.WriteLine();
    
    Console.Write("Digite um número: ");
    numTexto = Console.ReadLine();
    conversao = int.TryParse(numTexto, out num);

}
Console.WriteLine($"numero aceito: {num}");