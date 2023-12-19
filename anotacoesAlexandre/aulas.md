# Organização das aulas do Alexandre

## Aula 19/12/2023
    - Chamada
    - Descrição do projeto final
    - Windows Forms + Serialização (SOAP, XML  e JSON)

## Aula 15/12/2023
    - Chamada
    - Exercicios

### Passos para instalar e usar Xamarin no VS 2022

1) Na aba Tools -> Get Tools and Features
2) Se necessário atualizar o instalador
3) No instalador, Habilitar Desenvolvimento Mobile com .Net (se atual - Desenvolvimento Mobile Multiplataforma, lembrar de marcar no detalhes de instalação o Xamarin)

### Ativar o acelerador Hipervisor no Windows
1) Na barra de pesquisa do Windows -> digitar -> ativar ou desativar recursos do windows
2) Habilitar dois itens
    - Hyper V
    - Windows Hypervisor Plataform
3) Reinicializar o VS 2022 (algumas vezes, a máquina)

# Passos para criar primeiro projeto Xamarin no VS 2022
1) Na aba File -> New Project -> Cross Plataform -> Mobile App Xamarin.Forms
2) Opção Blank

3) Na barra de ferramentas do projeto criado -> Open Android SDK
4) Habilitar os SDKs Androids, no mínimo 8.0
5) Caso não possua um celular Android, habilitar o emulador dentro do VS 2022 -> Na barra de ferramentas -> Open Android Device Manager
6) Criar um emulador -> Nexus 5 com versão Android instalada
7) Executar o emulador -> Direto no Play ou na aba Open Android Device Manager


### Primeiro projeto Multi plataforma (Android, IOS, Windows)

https://youtu.be/-j3oBvCZwfc

### Entendendo uma Page em Xamarin.Forms

https://youtu.be/ClechSZyiHQ - layouts e componentes
https://youtu.be/NssXwauykQM - tratando eventos em botões
https://youtu.be/qpp0pPXAw7I - melhorando a organização de layouts
https://youtu.be/lPl2C8Nyp78 - tratando evento diretamento XAML

### Documentação MS para Pages

https://learn.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/controls/pages

    - No IOS, uma page é um View Controller
    - No Windows, uma page é uma Page
    - No Android, uma page é uma Activity

## Aula 01/12/2023
    - Chamada
    - Desafio
    - Xamarin
        - Conhecendo Xamarin - https://youtu.be/rtuywS2fG2Y
        - Como instalar Xamarin no Windows e MacOS - https://learn.microsoft.com/en-us/xamarin/get-started/installation/?pivots=windows-vs2022
        - Tutoriais Xamarin (básico ao avançado) - https://youtube.com/playlist?list=PLfvOpw8k80WqDChdm1cdlWx0FIR9ILtcm 
        
        - Site da Microsoft - https://learn.microsoft.com/pt-br/xamarin/get-started/what-is-xamarin
        - Documentação Xamarin - https://learn.microsoft.com/pt-br/xamarin/

        - Foco
            Xamarin.Android
            Xamarin.Forms
                - Multiplataforma
                - SDK 12 e/ou 33
                - Emulador de Celular/tablet - Genérico
                - Ativação do Hyper V
                - Organização das pastas
                    - App.xaml.cs -> gestor principal da aplicação (independente de plataforma)
                - Page - https://learn.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/controls/pages
            Xamarin.Essentials


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