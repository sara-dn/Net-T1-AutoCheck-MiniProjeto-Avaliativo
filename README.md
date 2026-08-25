````markdown
# AutoCheck - Sistema de Inspeção Veicular

## 📋 Sobre o Projeto

AutoCheck é uma aplicação console desenvolvida em **.NET** que gerencia o processo de inspeção e vistoria de veículos. O sistema permite registrar informações de diferentes tipos de veículos e acompanhar o status de inspeção de seus componentes críticos.

## 🎯 Funcionalidades

- **Cadastro de Veículos**: Suporte para múltiplos tipos (Carros, Motos, Caminhões)
- **Gerenciamento de Vistoria**: Registro detalhado de itens inspecionados
- **Checklist Obrigatório**: Padrão de verificação para todos os veículos
- **Histórico de Inspeções**: Rastreamento completo de vistorias realizadas

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
│   └── MotorVistoria.cs    # Serviço de processamento de vistorias
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
- `ObterChecklistObrigatorio()`: Retorna lista de itens obrigatórios de inspeção
- `IniciarVistoria()`: Inicializa o processo de vistoria

#### ItemVistoria

Representa um item individual verificado durante a inspeção.

#### MotorVistoria

Serviço responsável pelo processamento e gerenciamento das vistorias.

## ✅ Checklist Obrigatório

O sistema verifica automaticamente os seguintes itens:

- Nível de Óleo do Motor
- Bateria e Sistema Elétrico
- Documentação Regularizada
- Sistema de Freios
- Luzes de Sinalização e Iluminação
- Estado de Conservação dos Pneus

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

## 💡 Exemplo de Uso

```csharp
// Criar um novo veículo
var carro = new Carro("Toyota", "Corolla", 2023, 15000);

// Iniciar vistoria
carro.IniciarVistoria();

// Adicionar itens inspecionados
carro.AdicionarItemVistoriado("Nível de Óleo do Motor", "OK");
carro.AdicionarItemVistoriado("Bateria e Sistema Elétrico", "OK");
```

## 📝 Desenvolvimento

### Commits Recentes

- **8acf4d6**: Criação da estrutura base com classes de modelos e serviços

## 🔄 Padrões de Projeto

- **Herança**: Uso de classe abstrata `Veiculo` para reutilização de código
- **Polimorfismo**: Métodos virtuais para customização por tipo de veículo
- **Composição**: Lista de `ItemVistoria` para rastreamento detalhado

## 📦 Dependências

- Microsoft.VisualBasic (para funcionalidades auxiliares)

## 📄 Licença

Este projeto é de uso interno.

## 👤 Autores

- Sara Denardin

---

**Última atualização**: 24 de agosto de 2026
````