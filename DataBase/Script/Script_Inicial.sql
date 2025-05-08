-- Banco de dados
CREATE DATABASE SpotifyAPI;
GO

USE SpotifyAPI;
GO

-- Tabelas
CREATE TABLE Medias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200) NOT NULL,
    Descricao NVARCHAR(500) NOT NULL,
    UrlImagem NVARCHAR(500) NOT NULL,
    UrlMidia NVARCHAR(500) NOT NULL,
    Visualizacoes INT NOT NULL,
    Categoria NVARCHAR(100) NOT NULL,
    DataPublicacao DATETIME NOT NULL
);
GO

-- Inserção de dados exemplo
INSERT INTO Medias (Titulo, Descricao, UrlImagem, UrlMidia, Visualizacoes, Categoria, DataPublicacao)
VALUES
('Sítio do Picapau Amarelo', 'Música de Gilberto Gil',
 'https://i.scdn.co/image/ab67616d0000b2730565c0abdb993284de55413e',
 'https://open.spotify.com/intl-pt/track/4oEyFcdRTvFNozGEgtxRlx',
 2500, 'Infantil', GETDATE()),

('Palco', 'Clássico de Gilberto Gil',
 'https://i.scdn.co/image/ab67616d0000b27361d5a4c2d8ec382a8721e7a6',
 'https://open.spotify.com/track/3PQLYVskjUeRmRifE606dX',
 5400, 'MPB', GETDATE()),

('Tempo Rei', 'Outra canção famosa do Gil',
 'https://i.scdn.co/image/ab67616d0000b273c34d313c8310488e94cf124b',
 'https://open.spotify.com/track/0bYvAm3cULXQuUuIBgLQUg',
 3150, 'MPB', GETDATE());
GO
