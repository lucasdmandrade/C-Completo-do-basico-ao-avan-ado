using System;
using System.Collections.Generic;

using CSharp_zero_ao_avancado.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Contantes - Fundamentos", VariaveisEConstantes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}