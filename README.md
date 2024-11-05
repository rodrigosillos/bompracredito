# BomPraCredito

Projeto de microserviços para o sistema de crédito **BomPraCredito**, criado para gerenciar operações financeiras de forma eficiente e escalável.

## Índice

- [Descrição](#descrição)
- [Funcionalidades](#funcionalidades)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Configuração do Ambiente](#configuração-do-ambiente)
- [Executando o Projeto](#executando-o-projeto)
- [Contribuição](#contribuição)
- [Licença](#licença)

## Descrição

O sistema **BomPraCredito** é um projeto de arquitetura baseada em microserviços, desenvolvido para realizar e gerenciar operações de crédito, incluindo abertura de contas, controle de transações, e empréstimos. Cada serviço é modular, permitindo a escalabilidade e a facilidade de manutenção.

## Funcionalidades

- Gerenciamento de contas de clientes
- Processamento de transações financeiras
- Gerenciamento e concessão de empréstimos
- Integração com serviços de mensageria e bancos de dados distribuídos

## Tecnologias Utilizadas

- **Linguagem**: .NET 8.0
- **Orquestração**: Kubernetes com K3s e Rancher
- **Mensageria**: RabbitMQ, AWS SQS
- **Banco de Dados**: MongoDB
- **Observabilidade**: Ferramentas para monitoramento e logging (futuro)
- **Infraestrutura como Código**: Terraform e AWS CloudFormation (planejado)
- **Containerização**: Docker
- **Outros**: Service Mesh com Istio, CI/CD na AWS e Azure

## Estrutura do Projeto

Abaixo estão os principais serviços do sistema **BomPraCredito**:

- **AccountService**: Gerencia a criação e atualização de contas de clientes.
- **CustomerService**: Controla os dados dos clientes e suas informações de contato.
- **LoanService**: Gerencia as solicitações e aprovações de empréstimos.
- **TransactionService**: Lida com as transações financeiras entre contas.

## Configuração do Ambiente

### Pré-requisitos

Certifique-se de que você tem as seguintes ferramentas instaladas:

- [.NET 8.0](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [WSL 2 (para Windows)](https://docs.microsoft.com/windows/wsl/)
- [k3s](https://k3
