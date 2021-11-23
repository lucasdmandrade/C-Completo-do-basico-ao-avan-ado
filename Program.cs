using System;
using System.Collections.Generic;

using CSharp_zero_ao_avancado.Fundamentos;
using CSharp_zero_ao_avancado.EstruturaControle;
using CSharp_zero_ao_avancado.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Contantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimetricos - Fundamentos", OperadoresAritimetricos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},

                {"If - Estrutura de Controle", If.Executar},

                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"GEt e Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct- Classes e Metodos", ExemploStruct.Executar},
                {"Struct Vs Classes- Classes e Metodos", StructVsClasses.Executar},
                {"Parametros pro Referencia- Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}