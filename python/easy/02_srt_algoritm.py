# SRT

class Processo:
    def __init__(self, id, chegada, duracao, restante, inicio, fim,):
        self.id = id
        self.chegada = chegada
        self.duracao = duracao
        self.restante = restante
        self.inicio = inicio
        self.fim = fim

processos = [
    Processo(0, 1, 5, 3, 0, 0),
    Processo(1, 3, 2, 2, 0, 0),
    Processo(2, 4, 8, 4, 0, 0),
    Processo(3, 2, 13, 2, 0, 0)
]

fila = []

for p in processos:
    ""

# continuar...