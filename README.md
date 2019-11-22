# PiFoot

Um jogo de futebol com 4 times.

O usuário escolhe o nome do time, cor do uniforme, grito da torcida. Os outros 3 times podem já existir previamente no código. 

Com 4 times, com todos os times se enfrentando ao menos uma vez, um número determinado de partidas acontece.

A cada rodada, X partidas acontecem, de modo que cada time esteja enfrentando outro time. 

A cada partida, o resultado é exibido aleatoriamente. Podemos usar a classe random:
| Random geradorGols = new Random();
| int numeroGolsTimeAdversario = geradorGols.Next(1,5); // Numero entre 1 e 5
Ao final da partida, é mostrado o grito da torcida do time vencedor.

Ao final de cada rodada, a tabela do campeonato é atualizada: o time vencedor ganha 3 pontos, o empate dá 1 ponto, e a derrota 0 pontos. O número de gols tomado, o número de gols feitos, também é contabilizado. 

Em caso de empate, a ordenação favorece primeiro quem tem mais pontos, depois quem tem o saldo de gols positivo, e depois por ordem alfabetica.
