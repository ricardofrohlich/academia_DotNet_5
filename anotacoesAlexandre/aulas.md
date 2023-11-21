# Organização das aulas do Alexandre

## Aula 21/11/2023
1) Chamada
2) Certificado Digital, Assinatura Digital e Criptografia
        
        Certificação digital( Assinatura Digital( Criptografia() ) )
            - entidade de reconhecimento de assinaturas digitais
            - assinatura digital é um código ou um símbolo
            - criptografia -> chave hash -> número que garante que um documento ou um texto ou um arquivo é assinado

            chave - skrcsbftr
                    alexandre
            funcao(chave) - shift da mao esquerda uma tecla para direita
                            shift da mao direita uma tecla para esquerda

        principio da criptografia é embaralhar/codificar a mensagem original -> enviar -> desembaralha/decodifica a mensagem original
            codificar -> decodificar
                 função matemática - 8 bits, 16 bits, 32 bits, 64 bits, 128 bits, 256 bits 

    - criptografia simétrica: chave única e privada - melhor desempenho 
        DES
        3DES
        AES: Winzip, WhatsApp, ...

    - criptografia assimétrica: chave privada e chave pública - mais segura, porém mais lenta
        RSA

3) Códigos exemplos: Códigos com criptografia simétrica e assimétrica

4) Assinatura Digital
- https://www.youtube.com/watch?v=UlRCVihN3pE
- https://www.youtube.com/watch?v=rBa1kj6K_5M


## Aula 14/11/2023
1) Chamada
2) Vídeo auxiliar para a construção do desafio (windows forms + OO + lista + arquivos)
    - https://www.youtube.com/watch?v=JgBqsIffWdU
3) Trabalhar no desafio



## Aula 10/11/2023
1) Chamada
2) Desafio: Windows Form + Listas + Arquivo
    Tendo como base o programa do Amigo Secreto, refatorá-lo para que funcione em um ambiente gráfico Windows Forms
        A interface de comunicação é livre, ou seja, cada um pode organizar a forma de se comunicar com o usuário. Porém, todas
        as funcionalidades precisam estar presentes.
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

3) Conteúdo da aula
    - Windows Forms
        - Componentes gráficos são classes e objetos: propriedades (atributos) e eventos (métodos)
        - Principais componentes: label, textBox, button, listView, menu

        - Propriedades de um componente: nome, texto, posição, tamanho (largura x altura), cores, editavel, visibilidade, ...
        - Eventos de um componente: mouse (passar, clicar, ...) e teclado (pressionar, soltar,)


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
v
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