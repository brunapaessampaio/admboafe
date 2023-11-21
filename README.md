
## INTRODUÇÃO

Esta documentação visa facilitar o entendimento e a utilização dos itens contidos na API AdmBoaFe.App. Para melhor compreensão, foi detalhado neste documento, os métodos e seus tipos de parâmetros e retornos, com descrição e caminho de acesso. Visando facilitar a instalação da aplicação localmente, foi feito um vídeo explicativo e seu link está disponibilizado abaixo.

Nosso github: https://github.com/brunapaessampaio

Link do vídeo explicativo: https://github.com/brunapaessampaio/admboafe/blob/master/AdmBoaFe/Diagramas/Video_AdmBoaFe_BrunaSampaio.mp4

## SOBRE A ADM BOA FÉ

Administradora Boa Fé se apresenta como uma empresa especializada na administração de condomínios e na gestão de aluguéis de imóveis. Comprometidos com a excelência e a
eficiência na prestação de serviços, gostaríamos de destacar alguns dos princípios fundamentais que norteiam as suas operações.
## Documentação da API

### BLOCOS

#### * Retorna todos os blocos de apartamentos (Retorno: Lista de Blocos)

```http
  GET /Bloco
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere um bloco (Sem Retorno)

```http
  POST /api/Bloco
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Bloco`      | `int` | Id do bloco |
| `nome_bloco`      | `string` | Nome do bloco |
| `id_condominio`      | `int` | Id do Condomínio |

#### * Atualiza um bloco cadastrado (Sem Retorno)

```http
  PUT /api/Bloco
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Bloco`      | `int` | Id do bloco |
| `nome_bloco`      | `string` | Nome do bloco |
| `id_condominio`      | `int` | Id do Condomínio |

#### * Retorna um bloco pelo id (Retorno: bloco)

```http
  GET /api/Bloco/get-bloco-id/{id_Bloco}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do bloco |

#### * Deleta um bloco pelo id (Sem Retorno)

```http
  DELETE /api/Bloco/{id_Bloco}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do bloco |

#### ===============================================

### CONDOMINIO

#### * Retorna todos os condominios (Retorno: Lista de Condomínios)

```http
  GET /Condominio
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere um condominio (Sem Retorno)

```http
  POST /api/Condominio
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Condominio`      | `int` | Id do bloco |
| `Nome_Condominio`      | `string` | Nome do bloco |
| `Logradouro`      | `string` | Logradouro do Condomínio |
| `Numero`      | `int` | Número do Condomínio |
| `Complemento`      | `string` | Complemento do Condomínio |
| `Bairro`      | `string` | Bairro do Condomínio |
| `Cidade`      | `string` | Cidade do Condomínio |
| `CEP`      | `string` | CEP do Condomínio |
| `UF`      | `string` | UF do Condomínio |


#### * Atualiza um condominio cadastrado (Sem Retorno)

```http
  PUT /api/Condominio
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Condominio`      | `int` | Id do bloco |
| `Nome_Condominio`      | `string` | Nome do bloco |
| `Logradouro`      | `string` | Logradouro do Condomínio |
| `Numero`      | `int` | Número do Condomínio |
| `Complemento`      | `string` | Complemento do Condomínio |
| `Bairro`      | `string` | Bairro do Condomínio |
| `Cidade`      | `string` | Cidade do Condomínio |
| `CEP`      | `string` | CEP do Condomínio |
| `UF`      | `string` | UF do Condomínio |

#### * Retorna um condomínio pelo id (Retorno: condominio)

```http
  GET /api/Condominio/get-condominio-id/{id_Condominio}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do Condomínio |

#### * Deleta um condominio pelo id (Sem Retorno)

```http
  DELETE /api/Condominio/{id_Condominio}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do Condomínio |

#### ===============================================

### LOCATÁRIO

#### * Retorna todas os locatários (Retorno: Lista de Locatários)

```http
  GET /Locatario
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere um locatário (Sem Retorno)

```http
  POST /api/Locatario
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Locatario`      | `int` | Id do Locatario |
| `nome`      | `string` | Nome completo |
| `data_nasc`      | `date` | Data de nasciment |
| `cpf`      | `string` | CPF|
| `rg`      | `string` | registro civil |
| `telefone`      | `string` | Telefone |
| `email`      | `string` |Email |


#### * Atualiza um locatário cadastrado (Sem Retorno)

```http
  PUT /api/Locatario
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Locatario`      | `int` | Id do Locatario |
| `nome`      | `string` | Nome completo |
| `data_nasc`      | `date` | Data de nasciment |
| `cpf`      | `string` | CPF|
| `rg`      | `string` | registro civil |
| `telefone`      | `string` | Telefone |
| `email`      | `string` |Email |

#### * Retorna um locatário pelo id (Retorno: locatario)

```http
  GET /api/Locatario/get-locatario-id/{id_Locatario}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do Locatario |

#### * Deleta um locatário pelo id (Sem Retorno)

```http
  DELETE /api/Locatario/{id_Locatario}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do Locatario |

#### ===============================================

### LOCAÇÃO

#### * Retorna todas as locações (Retorno: Lista de Locações)

```http
  GET /Locacao
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere uma locação (Sem Retorno)

```http
  POST /api/Locacao
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Locacao`      | `int` | Id da Locação |
| `id_Unidade_Condominal`      | `int` | Ida da Unidade Condominial |
| `id_Locatario`      | `int` | Id do Locatário |
| `Valor_Aluguel`      | `decimal` | Valor do Aluguel |
| `Taxa_Condominio`      | `decimal` | Taxa do Condomínio |
| `Taxa_IPTU`      | `decimal` | Taxa do IPTU |
| `Data_Inicio_Locacao`      | `date` |Data Inicio |
| `Data_Fim_Locacao`      | `date` | Data Fim |


#### * Atualiza uma locação cadastrada (Sem Retorno)

```http
  PUT /api/Locacao
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Locacao`      | `int` | Id da Locação |
| `id_Unidade_Condominal`      | `int` | Ida da Unidade Condominial |
| `id_Locatario`      | `int` | Id do Locatário |
| `Valor_Aluguel`      | `decimal` | Valor do Aluguel |
| `Taxa_Condominio`      | `decimal` | Taxa do Condomínio |
| `Taxa_IPTU`      | `decimal` | Taxa do IPTU |
| `Data_Inicio_Locacao`      | `date` |Data Inicio |
| `Data_Fim_Locacao`      | `date` | Data Fim |

#### * Retorna uma locação pelo id (Retorno: locacao)

```http
  GET /api/Locacao/get-locacao-id/{id_Locacao}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id da Locação |

#### * Deleta uma locação pelo id (Sem Retorno)

```http
  DELETE /api/Locacao/{id_Locacao}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id da Locação |

#### ===============================================

### PROPRIETÁRIO

#### * Retorna todas os proprietários (Retorno: Lista de proprietários)

```http
  GET /Proprietario
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere um proprietário (Sem Retorno)

```http
  POST /api/Proprietario
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Proprietario`      | `int` | Id do Proprietario |
| `nome`      | `string` | Nome completo |
| `data_nasc`      | `date` | Data de nasciment |
| `cpf`      | `string` | CPF|
| `rg`      | `string` | registro civil |
| `telefone`      | `string` | Telefone |
| `email`      | `string` |Email |


#### * Atualiza um locatário cadastrado (Sem Retorno)

```http
  PUT /api/Proprietario
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Proprietario`      | `int` | Id do Proprietario |
| `nome`      | `string` | Nome completo |
| `data_nasc`      | `date` | Data de nasciment |
| `cpf`      | `string` | CPF|
| `rg`      | `string` | registro civil |
| `telefone`      | `string` | Telefone |
| `email`      | `string` |Email |


#### * Retorna um Proprietario pelo id (Retorno: Proprietario)

```http
  GET /api/Proprietario/get-proprietario-id/{id_Proprietario}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do Proprietario |

#### * Deleta um proprietário pelo id (Sem Retorno)

```http
  DELETE /api/Proprietario/{id_Proprietario}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id do Proprietario |

#### ===============================================

### UNIDADE CONDOMINIAL

#### * Retorna todas as unidades condominiais (Retorno: Lista de unidades condominiais)

```http
  GET /UnidadeCondominial
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere uma unidade condominial (Sem Retorno)

```http
  POST /api/UnidadeCondominial
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Unidade`      | `int` | Id da unidade Condominial |
| `id_bloco`      | `int` | Id do bloco onde está localizada a unidade |
| `andar`      | `int` | Andar do apartamento |
| `num_apartamento`      | `int` | Número do apartamento |
| `descricao`      | `string` | Descrição do apartamento |


#### * Atualiza uma unidade condominial cadastrada (Sem Retorno)

```http
  PUT /api/UnidadeCondominial
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Unidade`      | `int` | Id da unidade Condominial |
| `id_bloco`      | `int` | Id do bloco onde está localizada a unidade |
| `andar`      | `int` | Andar do apartamento |
| `num_apartamento`      | `int` | Número do apartamento |
| `descricao`      | `string` | Descrição do apartamento |


#### * Retorna uma unidade condominial pelo id (Retorno: Manutencao)

```http
  GET /api/UnidadeCondominial/get-unidade-id/{id_Manutencao}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id da unidade Condominial |

#### * Deleta uma unidade condominial pelo id (Sem Retorno)

```http
  DELETE /api/UnidadeCondominial/{id_Unidade}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id da unidade Condominial |

#### ===============================================

### MANUTENÇÃO

#### * Retorna todas as manutenções (Retorno: Lista de manutenções)

```http
  GET /Manutencao
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `sem parâmetros` |  |   |


#### * Insere uma manutenção (Sem Retorno)

```http
  POST /api/Manutencao
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Manutencao`      | `int` | Id da manutenção |
| `id_Unidade_Condominal`      | `int` | Id da unidade Condominial |
| `descricao`      | `string` | Descrição do apartamento |
| `taxa_manutencao`      | `decimal` | Taxa de manutenção |
| `data_manutencao`      | `date` | Data da manutenção |
| `executada`      | `bool` | Se a manutenção foi executada |


#### * Atualiza uma manutenção cadastrada (Sem Retorno)

```http
  PUT /api/Manutencao
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id_Manutencao`      | `int` | Id da manutenção |
| `id_Unidade_Condominal`      | `int` | Id da unidade Condominial |
| `descricao`      | `string` | Descrição do apartamento |
| `taxa_manutencao`      | `decimal` | Taxa de manutenção |
| `data_manutencao`      | `date` | Data da manutenção |
| `executada`      | `bool` | Se a manutenção foi executada |


#### * Retorna uma manutenção pelo id (Retorno: Manutencao)

```http
  GET /api/Manutencao/get-manutencao-id/{id_Manutencao}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id da Manutencao |

#### * Deleta uma manutenção pelo id (Sem Retorno)

```http
  DELETE /api/Manutencao/{id_Manutencao}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `idChave`      | `int` | Id da Manutencao |

#### ===============================================
