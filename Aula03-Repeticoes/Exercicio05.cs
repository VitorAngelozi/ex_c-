/*
==================================================
AULA 03 — ESTRUTURAS DE REPETIÇÃO
EXERCÍCIO 05 — VALIDAÇÃO DE SENHA
==================================================

OBJETIVO:
Praticar o funcionamento do do while.

CENÁRIO:

Um sistema possui uma senha numérica fixa.
O usuário deve informar a senha correta
para conseguir acessar o sistema.

REQUISITOS:

1. Crie uma variável int contendo a senha 1234.

2. Solicite ao usuário que digite a senha.

3. Utilize int.TryParse() para converter
   a entrada.

4. Enquanto a senha estiver incorreta,
   solicite uma nova tentativa.

5. Quando a senha estiver correta,
   apresente:
   "Acesso autorizado!"

EXEMPLO:

Digite a senha: 1111
Senha incorreta!

Digite a senha: 9999
Senha incorreta!

Digite a senha: 1234
Acesso autorizado!

REGRAS:

- Utilize obrigatoriamente do while.
- Utilize int.TryParse().
- Não utilize for ou while isolado.
- Não utilize métodos próprios.
- Não utilize return para encerrar
  tentativas incorretas.

DESAFIO EXTRA:

Conte quantas tentativas foram realizadas
até o usuário acertar a senha.

==================================================
*/

int senha = 1234;
Console.WriteLine("Digite a senha");
string inputText = Console.ReadLine();
bool conversao = int.TryParse(inputText, out int inputSenha);

do{
    Console.WriteLine("Senha incorreta. Digite novamente!");
    inputText = Console.ReadLine();
    conversao = int.TryParse(inputText, out inputSenha);
}
while(senha != inputSenha);
Console.WriteLine("Acesso autorizado!");