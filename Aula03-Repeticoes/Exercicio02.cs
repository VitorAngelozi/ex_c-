/*
==================================================
AULA 03 — ESTRUTURAS DE REPETIÇÃO
EXERCÍCIO 02 — CONTADOR DE NÚMEROS PARES
==================================================

OBJETIVO:
Combinar estruturas de repetição com
operadores aritméticos e condicionais.

REQUISITOS:

1. Solicite um número inteiro entre 1 e 100.

2. Utilize int.TryParse() para validar
   a entrada.

3. Utilize um laço for para percorrer
   todos os números de 1 até o número
   informado.

4. Exiba somente os números pares.

5. Ao final, apresente a quantidade
   total de números pares encontrados.

EXEMPLO:

Digite um número: 10

2
4
6
8
10

Total de números pares: 5

REGRAS:

- Utilize obrigatoriamente for.
- Utilize o operador %.
- Utilize if para identificar números pares.
- Não utilize arrays ou listas.
- Não utilize métodos próprios.
- Não utilize while.

DESAFIO EXTRA:

Além de contar os números pares,
calcule a soma de todos eles.

Exemplo:
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
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0) 
        {
            Console.WriteLine(i);
            c++;
        }
    }
   Console.WriteLine($"Total de numeros pares: {c}");
}
else
{
    Console.WriteLine("Numero invalido ou fora do valor previsto!");
}