# 🚗 AutoCheck - Sistema de Vistoria Veicular

> Mini projeto avaliativo em C# / .NET focado na aplicação de conceitos fundamentais de Programação Orientada a Objetos (POO) e regras de negócio para análise de veículos.

---

## 📌 Sobre o Projeto

O **AutoCheck** é uma aplicação console desenvolvida para automatizar e padronizar o processo de vistoria técnica em veículos. O sistema avalia um checklist de itens de segurança e conservação, calcula a nota geral, gera um percentual de aprovação e define automaticamente a **Ação Corporativa** ideal para o veículo (liberação, desconto ou recusa).

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET 8.0)
* **Paradigma:** Programação Orientada a Objetos (POO)
* **Ferramenta:** Console Application (Terminal)

---

## ⚙️ Regras de Negócio e Pontuação

Cada item avaliado no checklist recebe uma classificação e pontuação correspondente:

| Classificação do Item | Pontuação Recebida |
| :--- | :--- |
| **Bom** | +10 pontos |
| **Regular** | +5 pontos |
| **Ruim** | 0 pontos |

### 📊 Classificação Final e Ações Corporativas

O resultado final é determinado pelo **Percentual de Aprovação** calculado a partir da soma dos pontos obtidos sobre a nota máxima possível:

* 🟢 **Aprovado com Excelência (>= 90%):** Liberado para compra/revenda imediata.
* 🟡 **Aprovado com Apontamentos (60% a 89%):** Exige desconto na compra para reparos da oficina.
* 🔴 **Reprovado na Vistoria (< 60%):** Veículo recusado pela concessionária.

---

## 🧩 Arquitetura do Sistema

O projeto foi construído aplicando os pilares da POO:

AutoCheck.ConsoleApp/
├── Models/
│   ├── Veiculo.cs          # Classe base para veículos
│   ├── Carro.cs            # Derivada de Veiculo
│   └── ItemVistoria.cs     # Representa cada item do checklist (Nome, Status)
├── Services/
│   └── MotorVistoria.cs    # Processa os cálculos de notas, percentuais e status
└── Program.cs              # Interface com usuário via console e fluxo principal

---

## 🚀 Como Executar o Projeto

### Pré-requisitos
* .NET SDK 8.0 instalado na sua máquina.
* IDE de sua preferência (VS Code, Visual Studio ou Rider).

### Passos para execução

1. Clona o repositório:
   git clone https://github.com/sara-dn/Net-T1-AutoCheck-MiniProjeto-Avaliativo.git

2. Acesse o diretório do projeto:
   cd Net-T1-AutoCheck-MiniProjeto-Avaliativo/src/AutoCheck.ConsoleApp

3. Execute a aplicação:
   dotnet run

---

✨ Desenvolvido por Sara Denardin durante a jornada de aprendizado em C# e .NET.
