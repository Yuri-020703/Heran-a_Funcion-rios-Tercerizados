# 📋 Cadastro de Funcionários e Terceirizados em C# 

Projeto simples de console em C# que simula o cadastro de **funcionários** e **terceirizados**, aplicando conceitos fundamentais de **Programação Orientada a Objetos (POO)** como **herança**, **polimorfismo** e **métodos sobrescritos (`override`)**.

## 🚀 Objetivo

Demonstrar, de forma prática, o uso de herança e polimorfismo em C#, diferenciando o comportamento de funcionários comuns e terceirizados, especialmente no cálculo do salário.

## 🧠 Conceitos aplicados

- 🧱 **Herança**: Classe base `Funcionario` e classe derivada `Terceirizado`.
- 🔁 **Polimorfismo**: Uso de métodos sobrescritos para personalizar o comportamento de subclasses.
- ⚙️ **Override**: Método `CalcularPagamento()` é redefinido na classe `Terceirizado`.
- 📥 **Entrada de dados via console**.
- 🖨️ **Saída formatada com informações dos salários**.

## 📦 Estrutura do Projeto

```bash
/ProjetoFuncionarios/
│
├── Program.cs                # Classe principal (entrada do programa)
├── Funcionario.cs            # Classe base com propriedades e método virtual
└── Terceirizado.cs           # Subclasse com propriedades extras e override
