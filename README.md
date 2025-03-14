# Desafio Arrays e Loop - C#

Este repositório contém uma solução para um desafio de programação que envolve manipulação de arrays e loops em C#. O objetivo do desafio é implementar uma classe `Numeros` que permite inserir números inteiros, calcular o maior número, o menor número e a média dos números inseridos, utilizando a programação orientada a objetos e a classe `List<int>`.

## Funcionalidades

O projeto possui as seguintes funcionalidades:

- **Inserção de números:** Permite que o usuário insira quantos números quiser.
- **Maior número:** Calcula o maior número da lista inserida.
- **Menor número:** Calcula o menor número da lista inserida.
- **Média dos números:** Calcula a média dos números inseridos.

## Destaques

### Uso de Métodos LINQ

O projeto faz uso de **LINQ** (Language Integrated Query), uma poderosa ferramenta do C# que permite trabalhar com coleções de dados de forma mais concisa e eficiente. No código, são utilizados os seguintes métodos LINQ:

- **`Max()`**: Este método é utilizado para calcular o maior número na lista de números inseridos. Ele retorna o valor máximo encontrado na coleção.

   ```csharp
   return ListaNumeros.Max();
   
- **`Min()`**: Semelhante ao Max(), o método Min() retorna o menor número da lista de números inseridos.

  ```csharp
  return ListaNumeros.Min();

- **`Average()`**: O método Average() calcula a média aritmética dos números na lista. Ele é utilizado para fornecer a média dos valores inseridos, com uma precisão de duas casas decimais.

  ```csharp
  return ListaNumeros.Average();
  ```

Esses métodos são utilizados nas funções MaiorNumero(), MenorNumero() e MediaNumeros() para calcular rapidamente os valores desejados, sem a necessidade de escrever loops explícitos, tornando o código mais limpo e legível.

Os métodos LINQ fazem parte da biblioteca padrão do C# e são uma das maneiras mais eficientes de trabalhar com coleções de dados, oferecendo uma sintaxe fluida e poderosa para manipulação de listas e outras coleções.

## Como usar

1. Clone este repositório em sua máquina:

   ```bash
   git clone https://github.com/seu-usuario/Desafio_arrays_loop_GPT.git

2. Abra o projeto em sua IDE de preferência (recomenda-se o Visual Studio ou Visual Studio Code).

3. Compile e execute o programa. O programa solicitará ao usuário que insira números inteiros. Após a inserção, ele exibirá:
- **Maior número**
- **Menor número**
- **Média dos números**

4. Caso o usuário não insira um número válido, o programa emitirá uma mensagem de erro e pedirá para tentar novamente.

5. O programa continuará a solicitar números até que o usuário decida parar.

  ```
    Insira abaixo quantos números inteiros desejar:
  
    Insira um número: 5
    Deseja inserir mais um número? (S/N): S
    Insira um número: 10
    Deseja inserir mais um número? (S/N): N
  
    Resultados:
     - Maior: 10
     - Menor: 5
     - Média: 7.50
  ```

## Estrutura do código

### Classe **`Numeros`**
A classe **`Numeros`** é responsável por armazenar e processar os números inseridos. Ela contém os seguintes métodos:
- **InserirNumeros(int numero)**: Insere um número na lista.
- **MaiorNumero()**: Retorna o maior número da lista.
- **MenorNumero()**: Retorna o menor número da lista.
- **MediaNumeros()**: Retorna a média dos números na lista.
- **ToString()**: Retorna uma string formatada com os resultados.

### Classe **`Program`**
A classe **`Program`** é onde a execução do programa começa. Ela gerencia a interação com o usuário, permitindo a inserção de números e exibindo os resultados ao final.

## Requisitos

- **.NET 6 ou superior**

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.
