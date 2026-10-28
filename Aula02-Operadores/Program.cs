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

/*
==================================================
AULA 02 — OPERADORES
EXERCÍCIO 04 — CALCULADORA ARITMÉTICA
==================================================

OBJETIVO:
Praticar operadores matemáticos, conversão
de tipos e entrada de dados.

REQUISITOS:

1. Solicite dois números inteiros ao usuário.

2. Utilize int.TryParse() para converter
   os valores recebidos.

3. Se algum valor for inválido, apresente
   uma mensagem de erro.

4. Se ambos forem válidos, calcule:

   - Soma
   - Subtração
   - Multiplicação
   - Divisão
   - Resto da divisão

5. Exiba os resultados no console.

EXEMPLO:

Digite o primeiro número: 10
Digite o segundo número: 3

Soma: 13
Subtração: 7
Multiplicação: 30
Divisão: 3.3333...
Resto: 1

REGRAS:

- Utilize int.TryParse().
- Utilize if/else.
- Utilize interpolação de strings.
- A divisão deve preservar as casas decimais.
- Considere o que acontece se o segundo
  número for zero.

DESAFIO EXTRA:

Descubra como converter um dos operandos
para double antes de realizar a divisão.

==================================================
*/
/*
Console.WriteLine("Digite seu primeiro numero");
string num1Texto = Console.ReadLine()??"Invalido";
bool num1bool = int.TryParse(num1Texto, out int num1);
if (!num1bool)
{
   Console.WriteLine("Numero invalido!");
   return;
}
Console.WriteLine("Digite seu segundo numero");
string num2Texto = Console.ReadLine()??"Invalido";
bool num2bool = int.TryParse(num2Texto, out int num2);
if (!num2bool)
{
   Console.WriteLine("Numero invalido");
   return;
}
int soma = num1 + num2;
int subtracao = num1-num2;
int multiplicacao = num1 * num2;
var divisao = "nao eh possivel dividir por 0";
var resto = "nao eh possivel dividir por 0";
if (num2 != 0) 
{
double resultadoDivisao = (double)num1 / num2;
divisao = Convert.ToString(resultadoDivisao);
int resultadoResto= num1 % num2;
resto = Convert.ToString(resultadoResto);

}

Console.WriteLine($"Soma: {soma}\nSubtracao: {subtracao}\nMultiplicacao: {multiplicacao}\nDivisao: {divisao}\nResto divisao: {resto}");
*/
/*
==================================================
AULA 02 — OPERADORES
EXERCÍCIO 05 — VALIDAÇÃO DE ACESSO
==================================================

OBJETIVO:
Praticar operadores lógicos e condicionais.

CENÁRIO:

Um sistema permite o acesso somente quando
o usuário atende a duas condições:

- Possui 18 anos ou mais.
- Possui autorização de acesso.

REQUISITOS:

1. Crie uma variável int chamada idade.

2. Crie uma variável bool chamada
   possuiAutorizacao.

3. Utilize um if para verificar se
   o usuário atende às duas condições.

4. Caso atenda, exiba:
   "Acesso permitido"

5. Caso contrário, exiba:
   "Acesso negado"

TESTES:

Caso 1:
idade = 20
possuiAutorizacao = true
Resultado: Acesso permitido

Caso 2:
idade = 16
possuiAutorizacao = true
Resultado: Acesso negado

Caso 3:
idade = 25
possuiAutorizacao = false
Resultado: Acesso negado

REGRAS:

- Utilize o operador lógico adequado.
- Não utilize múltiplos ifs.
- Não utilize Console.ReadLine() ainda.
- Faça os três testes alterando as variáveis.

==================================================
*/
/*
int idade;
bool possuiAutorizacao;
idade = 25;
possuiAutorizacao = false;
if(idade >= 18 && possuiAutorizacao)
{
   Console.WriteLine("Resultado: acesso permitido");
}
else
{
   Console.WriteLine("Resultado: acesso negado");
}
*/