CREATE TABLE [dbo].[TBFornecedor] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (300) NULL,
    [Telefone] VARCHAR (50)  NULL,
    [Email]    VARCHAR (100) NULL,
    [Cidade]   VARCHAR (150) NULL,
    [Estado]   VARCHAR (100) NULL,
    CONSTRAINT [PK_TBFornecedor] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[TBFuncionario] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (300) NOT NULL,
    [Login] VARCHAR (100) NOT NULL,
    [Senha] VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_TBFuncionario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[TBMedicamento] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL,
    [Nome]                 VARCHAR (300) NULL,
    [Descricao]            VARCHAR (MAX) NULL,
    [Lote]                 VARCHAR (300) NULL,
    [Validade]             DATE          NULL,
    [QuantidadeDisponivel] INT           NULL,
    [Fornecedor_Id]         INT           NULL,
    CONSTRAINT [PK_TBMedicamento] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBMedicamento_TBFornecedor] FOREIGN KEY ([Fornecedor_Id]) REFERENCES [dbo].[TBFornecedor] ([Id])
);

CREATE TABLE [dbo].[TBPaciente] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (300) NOT NULL,
    [CartaoSUS] VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_TBPaciente] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[TBRequisicao] (
    [Id]                    INT      IDENTITY (1, 1) NOT NULL,
    [Funcionario_Id]        INT      NOT NULL,
    [Paciente_Id]           INT      NOT NULL,
    [Medicamento_Id]        INT      NOT NULL,
    [QuantidadeMedicamento] INT      NOT NULL,
    [Data]                  DATETIME NOT NULL,
    CONSTRAINT [PK_TBRequisicao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBRequisicao_TBFuncionario] FOREIGN KEY ([Funcionario_Id]) REFERENCES [dbo].[TBFuncionario] ([Id]),
    CONSTRAINT [FK_TBRequisicao_TBMedicamento] FOREIGN KEY ([Medicamento_Id]) REFERENCES [dbo].[TBMedicamento] ([Id]),
    CONSTRAINT [FK_TBRequisicao_TBPaciente] FOREIGN KEY ([Paciente_Id]) REFERENCES [dbo].[TBPaciente] ([Id])
);