USE [dadoscp]
GO
/****** Object:  Table [dbo].[Turma]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turma](
	[id] [int] NOT NULL,
	[professor_id] [int] NOT NULL,
	[grupamento] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[nome] [nvarchar](50) NOT NULL,
	[abreviacao] [nchar](1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[id_funcionario] [int] NOT NULL,
	[id_turma] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instrucao]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instrucao](
	[nome] [nvarchar](50) NULL,
	[id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[id] [int] NOT NULL,
	[nome] [nvarchar](50) NULL,
	[sexo] [nchar](1) NULL,
	[data_ingresso] [date] NULL,
	[data_nascimento] [date] NULL,
	[RG] [nchar](9) NULL,
	[CPF] [nchar](11) NULL,
	[titulo] [nchar](12) NULL,
	[carteira_de_trabalho] [nvarchar](50) NULL,
	[endereco] [nvarchar](100) NULL,
	[telefone] [nvarchar](11) NULL,
	[instrucao] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Auxiliar]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auxiliar](
	[id_funcionario] [int] NOT NULL,
	[id_turma] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 09/12/2017 17:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[ID] [int] NOT NULL,
	[mid] [int] NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[ano_letivo] [nvarchar](50) NULL,
	[CFC] [nvarchar](50) NULL,
	[BF] [nvarchar](50) NULL,
	[designacao] [nvarchar](50) NULL,
	[NIS] [nvarchar](50) NULL,
	[sexo] [nchar](1) NULL,
	[data_de_nascimento] [date] NULL,
	[nacionalidade] [nvarchar](50) NULL,
	[uf] [nchar](2) NULL,
	[religiao] [nvarchar](50) NULL,
	[frequentou_EI] [bit] NULL,
	[pai] [nvarchar](50) NULL,
	[pai_RG] [nchar](9) NULL,
	[pai_falecido] [bit] NULL,
	[pai_instrucao] [int] NULL,
	[pai_mora_com_aluno] [bit] NULL,
	[pai_profissao] [nvarchar](50) NULL,
	[mae] [nvarchar](50) NULL,
	[mae_NIS] [nvarchar](50) NULL,
	[mae_RG] [nchar](9) NULL,
	[mae_falecida] [bit] NULL,
	[mae_instrucao] [int] NULL,
	[mae_mora_com_aluno] [bit] NULL,
	[mae_profissao] [nvarchar](50) NULL,
	[responsavel] [nvarchar](50) NULL,
	[responsavel_tipo] [nvarchar](50) NULL,
	[responsavel_endereco] [nvarchar](100) NULL,
	[responsavel_CEP] [nchar](8) NULL,
	[responsavel_telefone] [nchar](11) NULL,
	[contato_1] [nvarchar](50) NULL,
	[telefone_contato_1] [nchar](11) NULL,
	[contato_2] [nvarchar](50) NULL,
	[telefone_contato_2] [nchar](11) NULL,
	[problemas_de_saude] [nvarchar](50) NULL,
	[educacao_especial] [nvarchar](50) NULL,
	[atendimento_especial] [nvarchar](50) NULL,
	[frequentou_outra_instituicao] [nvarchar](50) NULL,
	[meio_de_transporte] [nvarchar](50) NULL,
	[tempo_de_deslocamento] [nvarchar](50) NULL,
	[data_de_preenchimento] [date] NULL,
	[responsavel_pelo_preenchimento] [nvarchar](50) NULL,
	[turma_id] [int] NULL
) ON [PRIMARY]
GO
