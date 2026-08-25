````markdown
# AutoCheck - Sistema de Inspeção Veicular

## 📋 Sobre o Projeto

AutoCheck é uma aplicação console desenvolvida em **.NET** que gerencia o processo de inspeção e vistoria de veículos. O sistema permite registrar informações de diferentes tipos de veículos, avaliar componentes críticos e gerar relatórios detalhados com recomendações de aprovação ou reprovação.

## 🎯 Funcionalidades Principais

- **Cadastro de Veículos**: Suporte para múltiplos tipos (Carros, Motos, Caminhões) com atributos específicos
- **Vistoria Interativa**: Avaliação passo a passo dos componentes obrigatórios
- **Sistema de Pontuação**: Cálculo automático de notas e percentual de aprovação
- **Relatórios Detalhados**: Geração de relatórios com status de aprovação e recomendações corporativas
- **Histórico de Inspeções**: Rastreamento em memória de todas as vistorias realizadas
- **Validação de Dados**: Entrada validada para garantir integridade dos dados

## 🏗️ Arquitetura

### Estrutura de Pastas

```
src/AutoCheck.ConsoleApp/
├── Models/
│   ├── Veiculo.cs          # Classe base abstrata
│   ├── Carro.cs            # Implementação para carros
│   ├── Moto.cs             # Implementação para motos
│   ├── Caminhao.cs         # Implementação para caminhões
│   └── ItemVistoria.cs     # Modelo de item inspecionado
├── Services/
│   └── MotorVistoria.cs    # Serviço de processamento e relatório de vistorias
└── Program.cs              # Ponto de entrada da aplicação
```

### Modelos Principais

#### Veiculo (Classe Base Abstrata)

Propriedades:
- `Marca`: string
- `Modelo`: string
- `Ano`: int
- `Quilometragem`: int
- `VistoriaRealizada`: List<ItemVistoria>
- `Vistoria`: MotorVistoria

Métodos:
- `AdicionarItemVistoriado(string nome, string status)`: Adiciona um item à vistoria
- `ObterChecklistObrigatorio()`: Retorna lista virtual de itens obrigatórios de inspeção
- `IniciarVistoria()`: Inicializa o processo de vistoria com cálculos automáticos

#### Carro

Estende `Veiculo` com propriedade específica:
- `QuantidadeDePortas`: int

Override:
- `ObterChecklistObrigatorio()`: Retorna checklist específico para carros

#### Moto

Estende `Veiculo` com propriedade específica:
- `Cilindradas`: int (CC)

Override:
- `ObterChecklistObrigatorio()`: Retorna checklist específico para motos

#### Caminhao

Estende `Veiculo` com propriedades específicas:
- `QuantidadeDeEixos`: int
- `CapacidadeCargaToneladas`: double

Override:
- `ObterChecklistObrigatorio()`: Retorna checklist específico para caminhões

#### ItemVistoria

Representa um item individual verificado durante a inspeção.

Propriedades:
- `Nome`: string
- `Status`: string (validado: "bom", "regular" ou "ruim")

Validação: O status é validado no construtor e só aceita os valores predefinidos.

#### MotorVistoria

Serviço responsável pelo processamento, cálculo de notas e geração de relatórios.

Propriedades:
- `NotaMaxima`: int (calculada automaticamente)
- `NotaObtida`: int (calculada com base nos status dos itens)
- `Percentual`: double (porcentagem de aprovação)
- `StatusAprovacao`: string (resultado final da vistoria)
- `AcaoCorporativa`: string (recomendação corporativa)
- Dados do veículo para relatório (Marca, Modelo, Ano, Quilometragem, etc.)

Métodos:
- `RelatorioDeVistoria()`: Imprime relatório detalhado com todos os dados

## ✅ Sistema de Avaliação

### Checklist Padrão (Todos os Veículos)

- Nível de Óleo do Motor
- Bateria e Sistema Elétrico
- Documentação Regularizada
- Sistema de Freios
- Luzes de Sinalização e Iluminação
- Estado de Conservação dos Pneus

Cada item pode ser avaliado como: **"bom"** (10 pts), **"regular"** (5 pts) ou **"ruim"** (0 pts)

### Critérios de Aprovação

| Percentual | Status | Ação Corporativa |
|-----------|--------|------------------|
| ≥ 90% | Aprovado com Excelência | Liberado para compra/revenda imediata |
| 60% - 89% | Aprovado com Apontamentos | Exige desconto na compra para reparos |
| < 60% | Reprovado na Vistoria | Veículo recusado pela concessionária |

## 🚀 Como Começar

### Pré-requisitos

- .NET 6.0 ou superior
- Visual Studio Code ou Visual Studio

### Instalação

1. Clone o repositório:
```bash
git clone <repository-url>
cd autocheck-dotnet
```

2. Restaure as dependências:
```bash
dotnet restore
```

3. Execute a aplicação:
```bash
dotnet run --project src/AutoCheck.ConsoleApp
```

## 📝 Menu Principal

O programa oferece as seguintes opções:

1. **Realizar Nova Vistoria**: Cadastra um novo veículo e realiza sua inspeção
2. **Exibir Relatório das Vistorias**: Mostra todos os relatórios das vistorias já realizadas
3. **Sair**: Encerra a aplicação

## 🔄 Padrões de Projeto

- **Herança**: Uso de classe abstrata `Veiculo` para reutilização de código
- **Polimorfismo**: Métodos virtuais `ObterChecklistObrigatorio()` customizáveis por tipo de veículo
- **Composição**: Lista de `ItemVistoria` para rastreamento detalhado de inspeções
- **Encapsulamento**: Validação de dados e propriedades privadas onde necessário

## 👤 Autores

- Sara Denardin