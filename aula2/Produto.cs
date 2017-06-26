﻿using System;
using System.Globalization;

namespace curso {
    class Produto {

        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public double valorTotalEmEstoque() {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade) {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade) {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

        public override string ToString() {
            return nome
            + ", R$"
            + preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + quantidadeEmEstoque
            + " unidades, Total: R$"
            + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
