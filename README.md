# Sistemas Distribuídos

Para rodar, basta usar um "docker-compose up" no terminal.

Cada atividade possui um vídeo na pasta Videos.

## Atividade 03

Com base no que vimos sobre sockets, desenvolvam as aplicações abaixo, se sintam livres de usar a tecnologia que preferir, caso não seja uma das que estamos trabalhando em sala, será necessário explicação do funcionamento na linguagem escolhida.

### 1 - Echo Server e Cliente
Crie um servidor que recebe mensagens de um cliente e retorna a mesma mensagem (eco).

GitHub não exibe vídeos acima de 10Mb -> https://github.com/ZaqueuCavalcante/nr-distributed-systems/raw/refs/heads/master/Videos/03_01_echo.mp4

<p align="center">
  <video src="./Videos/03_01_echo.mp4" height="600" style="display: block; margin: 0 auto" />
</p>

### 2 - Chat Simples entre Dois Usuários
Desenvolva um chat básico onde dois clientes podem trocar mensagens por meio de um servidor intermediário.

GitHub não exibe vídeos acima de 10Mb -> https://github.com/ZaqueuCavalcante/nr-distributed-systems/raw/refs/heads/master/Videos/03_02_chat.mp4

<p align="center">
  <video src="./Videos/03_02_chat.mp4" height="600" style="display: block; margin: 0 auto" />
</p>

### 3 - Transferência de Arquivos Simples
Um cliente envia um arquivo de texto para o servidor, que o salva localmente.

GitHub não exibe vídeos acima de 10Mb -> https://github.com/ZaqueuCavalcante/nr-distributed-systems/raw/refs/heads/master/Videos/03_03_files.mp4

<p align="center">
  <video src="./Videos/03_03_files.mp4" height="600" style="display: block; margin: 0 auto" />
</p>

### 4 - Servidor de Hora
Crie um servidor que retorna a data e hora atuais quando um cliente se conecta.

GitHub não exibe vídeos acima de 10Mb -> https://github.com/ZaqueuCavalcante/nr-distributed-systems/raw/refs/heads/master/Videos/03_04_now.mp4

<p align="center">
  <video src="./Videos/03_04_now.mp4" height="600" style="display: block; margin: 0 auto" />
</p>

---------------------------------------------------------------------------------------------------

## Atividade 04

Com base no que vimos sobre sockets, desenvolvam as aplicações abaixo, se sintam livres de usar a tecnologia que preferir, caso não seja uma das que estamos trabalhando em sala, será necessário explicação do funcionamento na linguagem escolhida

### 1 - Jogo da Forca
Faça um servidor que cria um jogo da forca e um cliente que tentará descobrir a palavra.

Conceitualmente é a mesma ideia da atividade "Echo Server e Cliente".

### 2 - Jogo Simples (Jogo da Velha)
Implemente um jogo da velha onde dois clientes jogam remotamente através de um servidor.

Conceitualmente é a mesma ideia da atividade "Chat Simples entre Dois Usuários".

### 3 - Chat de criptografia
Desenvolva um programa onde o cliente irá enviar mensagens criptografadas e o servidor receberá a mensagem e irá descriptografar. Como criptografia podem utilizar a cifra de césar com qualquer chave. No servidor é necessário mostrar a mensagem criptografada e descriptografada.

GitHub não exibe vídeos acima de 10Mb -> https://github.com/ZaqueuCavalcante/nr-distributed-systems/raw/refs/heads/master/Videos/04_03_decrypt.mp4

<p align="center">
  <video src="./Videos/04_03_decrypt.mp4" height="600" style="display: block; margin: 0 auto" />
</p>
