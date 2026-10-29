/*
==================================================
AULA 03 — EXERCÍCIO 03
SOMA DOS NÚMEROS PARES
==================================================

OBJETIVO:
Compreender o conceito de acumulador.

REQUISITOS:

1. Aproveite o código do exercício anterior.

2. Continue exibindo todos os números pares.

3. Continue contando quantos números pares
   foram encontrados.

4. Crie uma variável para acumular a soma
   de todos os números pares encontrados.

5. Ao final, exiba:
   - Quantidade de números pares.
   - Soma dos números pares.

EXEMPLO:

Digite um número: 10

2
4
6
8
10

Quantidade de pares: 5
Soma dos pares: 30

REGRAS:

- Utilize for.
- Utilize if.
- Não utilize arrays ou listas.
- Não utilize fórmulas matemáticas prontas.
- Realize a soma durante a repetição.

TESTES:

Entrada: 1
Quantidade: 0
Soma: 0

Entrada: 6
Quantidade: 3
Soma: 12

Entrada: 10
Quantidade: 5
Soma: 30

==================================================
*/

Console.WriteLine("Digite um número de 1 a 100");
string numTexto = Console.ReadLine();
bool conversao = int.TryParse(numTexto, out int num);

if (conversao && num >= 1 && num <= 100)
{
   int c = 0;
   int soma = 0;
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0) 
        {
            Console.WriteLine(i);
            c++;
			soma += i;
        }
    }
   Console.WriteLine($"Total de numeros pares: {c}\nSoma: {soma}");
}
else
{
    Console.WriteLine("Numero invalido ou fora do valor previsto!");
}