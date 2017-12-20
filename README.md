##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Command 

> Command é um dos 11 padrões comportamentais dentre os 23 padrões de projeto de software do GOF. Na programação orientada a objeto, o command é um padrão no qual um objeto é usado para encapsular toda informação necessária para executar uma ação ou acionar um evento em um momento posterior.

## Objetivo 

> O Padrão Command tem como definição encapsular uma solicitação como um objeto, o que lhe permite parametrizar outros objetos com diferentes solicitações, enfileirar ou registrar solicitações e implementar recursos de cancelamento de operações. Isso inclui informações como o nome do método, o objeto que o método pertence e os valores dos parâmetros do método.

![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/a/a7/Estrutura-command.png)

## Problema 

> Algumas vezes é necessário emitir solicitações para objetos nada sabendo sobre a operação que está sendo solicitada ou sobre o receptor da mesma.
Utilizar quando:
* Parametrizar objetos por uma ação a ser executada. Você pode expressar tal parametrização numa linguagem procedural através de uma função callback, ou seja, uma função que é registrada em algum lugar para ser chamada em um momento mais adiante. Os Commands são uma substituição orientada a objetos para callbacks;
* Especificar, enfileirar e executar solicitações em tempos diferentes. Um objeto Command pode ter um tempo de vida independente da solicitação original. Se o receptor de uma solicitação pode ser representado de uma maneira independente do espaço de endereçamento, então você pode transferir um objeto Command para a solicitação para um processo diferente e lá atender a solicitação;
* Suportar desfazer operações. A operação Execute, de Command, pode armazenar estados para reverter seus efeitos no próprio comando. A interface do Command deve ter acrescentada uma operação Unexecute, que o reverte.efeitos de uma chamada anterior de Execute. Os comandos executados são armazenados em uma lista histórica. O nível ilimitado de desfazer e refazer operações é obtido percorrendo esta lista para trás e para frente, chamando operações Unexecute e Execute, respectivamente.

## Aplicabilidade 

> A chave deste padrão é uma classe abstrata Command, a qual declara uma interface para execução de operações. Na sua forma mais simples, esta interface inclui uma operação abstrata Execute. As subclasses concretas de Command especificam um par receptor-ação através do armazenamento do receptor como uma variável de instância e pela implementação de Execute para invocar a solicitação. O receptor tem o conhecimento necessário para poder executar a solicitação, porém externamente os objetos não sabem quais ações estão sendo executadas no receptor, eles apenas visualizam o método execute() que irá executar as suas solicitações. Desta forma, todos os clientes de objetos command tratam cada objeto como uma "caixa preta", simplesmente invocando o método execute()sempre que o cliente exige "serviço" do objeto.

> Usar objetos de Command faz com que seja mais fácil construir componentes gerais que precisam delegar, sequenciar ou executar chamadas de métodos em um momento de sua escolha, sem a necessidade de conhecer a classe do método ou os parâmetros do método. Usar um objeto invoker permite contabilizar sobre as execuções de comando a serem realizadas convenientemente, bem como a implementação de diferentes modos para comando, que são geridos pelo objeto invoker, sem a necessidade do cliente estar ciente da existência da contabilidade ou modos.

---

### Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using
```shell
$ git clone https://github.com/BrunoLopes/Xperiments.DesignPatterns.Command
```

### Setup

> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  