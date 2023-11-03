# Organização das aulas do Alexandre

## Aula 03/11/2023

1) Chamada
2) Desafio do amigo secreto
    - Criar um menu para gerenciar amigos (nomes e email)
        - Cadastrar amigo
        - Listar amigos
        - Gerar amigo secreto
    
    - Para o desafio usar ou criar:
        1) classe Amigo: nome e email (getter e setter); método construtor;
        2) lista de amigos
        3) arquivo amigos.csv (com dados dos amigos, linha a linha, com os dados separados por ;)
            Gustavo Castagna;gus.castagna@ufn.edu.br
            Alexandre Nonato;alex.nonato@ufn.edu.br
        4) arquivo secretos.csv (com nome de um amigo e seu respectivo amigo secreto, separados por ;)
            Gustavo Castagna;gus.castagna@ufn.edu.br;Alexandre Nonato;alex.nonato@ufn.edu.br

        [gustavo, alexandre, caroline, hugo, davi, jose] -> lista
        [alexandre, gustavo, hugo, davi, jose, carolina] -> embaralha lista -> 

        Sort() - ordenação
        shuffle -> OrderBy.Random


3) Conteúdo da aula:
    - Classe StreamReader para ler de arquivos
    - Classe StreamWriter para escrever em arquivos
        Abrir para escrever do zero
        Abrir para appendar no final
    - Polimorfismo de reescrita de métodos herdados (Equals, ToString, GetHash, ...)
    - Ordenação e embaralhamento de listas


4)
    DESENVOLVIMENTO DE SISTEMAS
    Memória
        - Principal - processamento de dados - armazenamento trasiente
            variável ou atributo ou objeto: nome, tipo, endereço

        - Secundárias (HD, SSD, Flash, ...) - armazenamento persistente
            arquivo: nome, tipo, endereço



        Programando sistemas que manipulam arquivos (variados' banco de dados; csv; json; xml, ...)
            - Na memória principal é necessário um procurador (variável) que represente o arquivo em memória




## Aula 27/10/2023

1) Chamada
2) Atividade desafio/exercícios do Ricardo
3) Atividade Alexandre (opcional)
    Classe Pessoa
        nome string
        email string
        dataNascimento Date 
        construtor()
        getters/setters
        idade()

    Classe AtletaPadel : Pessoa
        posicaoQuadra string (esquerda ou direita)
        categoria string (open, 2a, 3a, 4a, 5a)
        getters/setters

    Classe TreinadorPadel : Pessoa
        registroConselho : string
        clube : string

    


    Necessidade de 2 listas. Uma para atletas, outra para treinadores.
        
4) Teoria da Orientação a Objetos: classe, objeto, atributo, metodos, encapsulamento, herança, polimorfismo