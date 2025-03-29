<div align="center">
  <img src="https://github.com/user-attachments/assets/127a05b6-b9cc-47d5-a63f-8ad4f15daa7c" width="50%">
</div>

- [Por que foi feito isso?](#por-que-foi-feito)
- [Explicando o Processo de Criação](#explicando-o-processo-de-criação)
  - [Criando as Tabelas](#criando-as-tabelas)
  - [Criando as Telas](#criando-as-telas)
- [Explicando o Processo de Criação (Código)](#explicando-o-processo-de-criação-código)
  - [Variáveis utilizadas no projeto](#variáveis-utilizadas-no-projeto)

# Projeto CRUD - Sistema BR

## Por que foi feito?

<p align="justify">Para conseguir um <strong>Estágio, PJ, Jovem Aprendiz</strong>na Area de Programação WEB/DESKTOP</p>

## Explicando o Processo de Criação:
### Criando as Tabelas:

<p align="justify">&emsp; Para a criação das tabelas utilizei o banco de dados da Microsoft, <strong>SQL SERVER MANAGEMENT STUDIO 2.0</strong>, nele criei as tabelas Estado e Cidade, possuindo as seguintes colunas como podemos ver na imagem abaixo:<p> <br>

<div align="center">
  <img src="https://github.com/user-attachments/assets/29cb22f7-1a4c-4f76-b79f-092e2f500761" width="90%">
</div>

<br>

<p align="justify">&emsp;Testei inserindo valores no mesmo, para restar se estava realmente interligas e funcionando perfeitamente:</p>

<br>

<div align="center">
  <img src="https://github.com/user-attachments/assets/819ece5a-89b9-45af-8c6b-5e6845e08084" width="90%">
</div>

### Criando as Telas:

<p align="justify">&emsp;No meu caso resolvi fazer uma única tela, mas contendo <strong>tudo</strong> que foi relatado pela empresa SISTEMAS BR</p>

<p align="justify">&emsp;A primeira coisa que fiz foi cirar o visual da aplicação, fundo cinza + uma PictureBox vazio com a cor branca (White) para dar um constraste e realçar o que é importante na aplicação.</p>

<p align="justify">&emsp;A segunda parte foi criar as labels (que irá descrever o que os TextBoxs irão fazer), aproveitei e coloquei a logo da SISTEMAS BR no lado superior esquerdo para dar identidade ao projeto que estou realizando, como podemos ver abaixo:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/921c34ed-4f6d-4cff-80f6-d93466117e47" width="90%">
</div>
<br>

<p align="justify">&emsp;Após eu ter feito isso inserir os botões que será as ações que o usuário poderá fazer no programa desktop, elas são <strong>"Cadastrar, Listar, Deletar</strong>, veja a imagem abaixo: ilustrando isso:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/71c5fc48-952f-4fb2-bb20-ea7d549f1a28" width="90%">
</div>
<br>

<p align="jusitfy">&emsp;Agora entra a parte do elemento que irá exibir as tabelas o famoso dataGridView, inseri ele logo abaixo no centro do programa, que podemos ver abaixo:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/b5f6b4ca-d19c-4229-b188-e76be19e04c7" width="90%">
</div>

<p align="justify">&emsp;O ícone do programa eu peguei de um site gratuitos de ícones, o nome do title text eu coloquei <strong>"Cadastro de Cidade & Estado</strong>, como podemos ver logo abaixo (olhe para o lado superior canto esquerdo da aplicação):</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/74791962-f299-41f4-9f1c-865c0609ae51" width="90%">  
</div>

## Explicando o Processo de Criação (Código)
### Variáveis utilizadas no projeto:
<p align="justify">&emsp;Criei as seguintes variáveis no projeto, sendo a principal a string de conexão do banco de dados,, veja abaixo:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/dbd54cc6-d088-496f-873b-64aac774f518" width="90%">
</div>

<p align="justify">&emsp;Todos foram criados fora da classe de elementos, fazendo assim <strong>variáveis globais</strong></p>

### private void TestarConexao()

<p align="justify">&emsp;Aqui a primeira classe do programa, testando a conexão do banco de dados/abrindo o mesmo, resolvi fazer desse jeito para ficar melhor na leitura e manutenção do código depois (por isso e o primeiro que aparece, a instancia <span>public Cidade()</span> nela está chamando a classe)</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/314f95a8-88f8-4b3d-a61f-0c8ef73e00c2" width="90%">
</div>

### txtCidade, txtBoxEstado, txtBoxEstadoSigla

<p align="justify">&emsp;Essa parte são os TextBox citadfos na parte "<a href="#criando-as-telas">Criando as Telas</a>" aqui usarei as variáveis usadas para guardar as informações digitadas pelo usuário para cadastrar e deletar:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/b041028a-7c2b-41d9-9669-20a358218dce" width="90%">
</div>

<p align="justify">&emsp;Coloquei um tratamento de string no <mark><strong>txtBoxEstadoSigla</strong></mark> usando o método <strong>.ToUpper()</strong> para que qualquer coisa que o usuário escreva seja convertida para letras maiúsculas (por ser SIGLAS de ESTADOS isso e extremamanete importante)</p>

### btnCadastrar()

<p align="justify">&emsp;Aqui já começamos a entrar nas partes das funções dos botões, sendo o primeiro de cadastrar o que foi inserido pelo usuário, fiz tratamento caso o usuário tente inserir nada no banco de dados, além de exibir em uma MessageBox se a Cidade e Estado foram cadastrados com sucesso ou não:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/20505dab-a5a7-4466-bc9e-9e6702020a70" width="70%">
  
  <img src="https://github.com/user-attachments/assets/03ab0dd1-4015-4a4c-8dfa-38ea13359777" width="70%">

</div>

### bntListar()

<p align="justify">&emsp;Aqui entra o botão para listar toda alteração do banco de dados, irá exibir nome da cidade, nome do estado e principalmente a sigla do mesmo:</p>

<div align="center">
  <img src="https://github.com/user-attachments/assets/d4977f14-e417-4e72-8f5a-81d6166126f4" width="90%">
</div>

### bntDeletar()

Aqui temos o botão que pode fazer duas ações quando clicar no mesmo:

<ol>
  <li><p align="justify">O primeiro clique no botão os labels que estavam escritos "<strong>Cadatre uma Cidade:</strong>" "<strong>Cadastre um Estado</strong>" iram mudar para "<strong>Deletar Cidade</strong>" "<strong>Deletar Estado</strong>", logo depois pega as variáveis criadas e atribui novamente os valores digitados pelo usuário:</p></li>
  <div align="center">
    <img src="https://github.com/user-attachments/assets/44cadc08-e708-4892-a490-854917768643" width="90%">
  </div>

  <li><p align="justify">O segundo clique já faz ação que o botão foi feito, deletar o que já esta escrito no banco de Dados (para isso precisa clicar no botão listar para ver o que já esta no banco de dados):</p></li>

  <div align="center">
    <img src="https://github.com/user-attachments/assets/7e714faa-793c-438d-bbe6-2b5b4eb0abdf" width="90%">
    <img src="https://github.com/user-attachments/assets/e009553b-9bf6-4920-a1bd-7352c74fd8c2" width="90%">
  </div>
</ol>
