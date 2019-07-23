CREATE TABLE [dbo].[Lojas] (
    [IdLoja]        INT            IDENTITY (1, 1) NOT NULL,
    [CNPJ]          NUMERIC NOT NULL,
    [Nome_Completo] TEXT NOT NULL,
    CONSTRAINT [PK_Lojas] PRIMARY KEY CLUSTERED ([IdLoja] ASC)
);

