/*
AULA 02 — OPERADORES E ENTRADA DE DADOS
EXERCÍCIO 01 — CALCULADORA DE IDADE

OBJETIVO:
Praticar entrada de dados, conversão de tipos
e operações matemáticas.

REQUISITOS:

1. Solicite o nome do usuário.
2. Solicite o ano de nascimento.
3. Armazene as informações em variáveis.
4. Calcule a idade aproximada do usuário
   considerando o ano de 2026.
5. Exiba o nome e a idade calculada.

EXEMPLO DE EXECUÇÃO:

Digite seu nome: Carlos
Digite seu ano de nascimento: 2000

Olá, Carlos!
Você completa 26 anos em 2026.

REGRAS:

- Utilize Console.ReadLine() para receber os dados.
- Utilize tipos adequados para cada variável.
- Utilize interpolação de strings na saída.
- Não utilize valores fixos para o nome ou
  ano de nascimento.
- Não utilize inteligência artificial para
  gerar a solução.

OBSERVAÇÃO:
Ainda não é necessário validar entradas inválidas.
Aprenderemos isso posteriormente.
==================================================
*/
//Console.WriteLine("Digite seu nome");
//string nome = Console.ReadLine() ?? "Nome nao identificado";
//Console.WriteLine("Digite seu ano de nascimento");
//string anoNascimentoTexto = Console.ReadLine() ?? "Ano nao informada";
//int anoNascimento = Convert.ToInt32(anoNascimentoTexto);
//int idade = 2026 - anoNascimento;
//Console.WriteLine($"Ola, {nome}\nVoce completa {idade} em 2026");

/*
==================================================
AULA 02 — OPERADORES E ENTRADA DE DADOS
EXERCÍCIO 02 — INVESTIGANDO CONVERSÕES
==================================================

OBJETIVO:
Compreender diferentes formas de converter
uma string para um número inteiro.

PARTE 1 — CONVERT

1. Solicite um número ao usuário.
2. Receba o valor utilizando Console.ReadLine().
3. Converta utilizando Convert.ToInt32().
4. Exiba o resultado multiplicado por 2.

Execute o programa com as entradas:
- 10
- 25
- abc

Observe o comportamento em cada situação.

PARTE 2 — PARSE

5. Substitua Convert.ToInt32() por int.Parse().
6. Execute novamente os três testes.

Anote se encontrou alguma diferença.

PARTE 3 — TRYPARSE

7. Pesquise a assinatura de int.TryParse()
   utilizando o IntelliSense do Visual Studio.
8. Descubra qual é o tipo de retorno do método.
9. Investigue o significado do parâmetro out.

Não é necessário implementar TryParse ainda.

PERGUNTAS:

A. O que aconteceu ao digitar "abc"?
B. Qual exceção foi apresentada?
C. Por que uma entrada inválida pode comprometer
   a execução de um programa?
D. Qual é a principal diferença entre Parse()
   e TryParse()?

REGRAS:
- Escreva o código sozinho.
- Não utilize tratamento de exceções ainda.
- Registre suas observações.
==================================================
*/
//Console.WriteLine("digite um numero");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(n1 * 2);

/*
==================================================
AULA 02 — OPERADORES E ENTRADA DE DADOS
EXERCÍCIO 03 — CONVERSÃO SEGURA
==================================================

OBJETIVO:
Utilizar int.TryParse() para validar a entrada
de um número inteiro.

REQUISITOS:

1. Solicite um número ao usuário.
2. Leia o valor utilizando Console.ReadLine().
3. Utilize int.TryParse() para tentar converter
   o valor recebido.
4. Utilize if/else para verificar se a
   conversão foi bem-sucedida.

5. Se a conversão funcionar:
   - Multiplique o número por 2.
   - Exiba o resultado.

6. Se a conversão falhar:
   - Exiba "Você não digitou um número válido".

EXEMPLO 1:

Digite um número: 10
Resultado: 20

EXEMPLO 2:

Digite um número: abc
Você não digitou um número válido.

REGRAS:

- Não utilize Convert.ToInt32().
- Não utilize int.Parse().
- Utilize int.TryParse().
- Não utilize try/catch.
- O programa não deve encerrar com uma exceção
  de conversão para uma entrada inválida.

==================================================
*/
/*
Console.WriteLine("Digite um numero");
string numeroTexto = Console.ReadLine() ?? "Vazio";
bool conseguiuConverter = int.TryParse(numeroTexto, out int numero);
if (conseguiuConverter)
{
   Console.WriteLine(numero * 2);
}
else
{
   Console.WriteLine("Numero nao valido!");
}
*/
