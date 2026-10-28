/*
==================================================
AULA 03 — ESTRUTURAS DE REPETIÇÃO
EXERCÍCIO 01 — CONTADOR DE NÚMEROS
==================================================

OBJETIVO:
Compreender o funcionamento do laço for.

REQUISITOS:

1. Solicite um número inteiro ao usuário.

2. Utilize int.TryParse() para validar
   a entrada.

3. O número informado deve estar
   entre 1 e 100.

4. Utilize um laço for para exibir
   todos os números de 1 até o
   número informado.

EXEMPLO:

Digite um número: 5

1
2
3
4
5

REGRAS:

- Utilize obrigatoriamente for.
- Não utilize while.
- Não utilize arrays ou listas.
- Valide a entrada do usuário.
- Não escreva os números manualmente.

DESAFIO EXTRA:

Depois de concluir o exercício,
modifique o programa para exibir
somente os números pares.

==================================================
*/
Console.WriteLine("Digite um número de 1 a 100");
string numTexto = Console.ReadLine();
bool conversao = int.TryParse(numTexto, out int num);
if (conversao && num >= 1 && num <= 100){
   for (int i =1; i <= num; i++){
      Console.WriteLine(i);
   }
}else{
   Console.WriteLine("Numero invalido ou fora do valor previsto");
}
