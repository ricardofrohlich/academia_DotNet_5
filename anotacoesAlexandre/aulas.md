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
        4) arquivo secretos.csv (com nome de um amigo e seu respectivo amigo secreto, separados por ;)


3) Conteúdo da aula:
    - Classe StreamReader para ler de arquivos
    - Classe StreamWriter para escrever em arquivos
    - Polimorfismo de reescrita de métodos herdados (Equals, ToString, GetHash, ...)
    - Ordenação e embaralhamento de listas


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