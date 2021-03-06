USE [master]
GO
/****** Object:  Database [vpc]    Script Date: 28/03/2019 16:37:14 ******/
CREATE DATABASE [vpc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'vpc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\vpc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'vpc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\vpc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [vpc] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [vpc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [vpc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [vpc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [vpc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [vpc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [vpc] SET ARITHABORT OFF 
GO
ALTER DATABASE [vpc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [vpc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [vpc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [vpc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [vpc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [vpc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [vpc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [vpc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [vpc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [vpc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [vpc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [vpc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [vpc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [vpc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [vpc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [vpc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [vpc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [vpc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [vpc] SET  MULTI_USER 
GO
ALTER DATABASE [vpc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [vpc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [vpc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [vpc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [vpc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [vpc] SET QUERY_STORE = OFF
GO
USE [vpc]
GO
/****** Object:  Table [dbo].[Commande]    Script Date: 28/03/2019 16:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commande](
	[IdCommande] [int] IDENTITY(1,1) NOT NULL,
	[IdProduit] [int] NOT NULL,
	[Quantite] [int] NOT NULL,
	[PrixTTC] [float] NOT NULL,
	[DateCommande] [datetime] NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdFacture] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[NomClient] [varchar](max) NOT NULL,
	[PrenomClient] [varchar](max) NOT NULL,
	[DateDeNaissance] [datetime] NULL,
	[Sexe] [tinyint] NULL,
	[Telephone] [varchar](10) NULL,
	[Email] [varchar](max) NOT NULL,
	[Password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produit]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produit](
	[IdProduit] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Prix] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProduit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VueSelectionCommandeClient]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VueSelectionCommandeClient]
As select p.[Description],c.Quantite,c.DateCommande,c.PrixTTC,cl.NomClient,cl.PrenomClient
	from Commande as c,Produit as p,Client as cl
	where c.IdClient=cl.IdClient and c.IdProduit=p.IdProduit;
GO
/****** Object:  Table [dbo].[Adresse]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresse](
	[IdAdresse] [int] IDENTITY(1,1) NOT NULL,
	[Rue] [varchar](max) NOT NULL,
	[CodePostal] [char](5) NOT NULL,
	[Ville] [varchar](max) NOT NULL,
	[Pays] [varchar](max) NOT NULL,
	[Region] [varchar](50) NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdTypeAdresse] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAdresse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facture]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facture](
	[IdFacture] [int] IDENTITY(1,1) NOT NULL,
	[NumFacture] [varchar](50) NOT NULL,
	[PrixTotal] [float] NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdPaiement] [int] NOT NULL,
	[IdAdresse] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFacture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fournisseur]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fournisseur](
	[IdFournisseur] [int] IDENTITY(1,1) NOT NULL,
	[NomFournisseur] [varchar](max) NOT NULL,
	[PrenomFournisseur] [varchar](max) NOT NULL,
	[EmailFournisseur] [varchar](max) NOT NULL,
	[Rcs] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFournisseur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livraison]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livraison](
	[IdLivraison] [int] IDENTITY(1,1) NOT NULL,
	[DateLivraison] [datetime] NOT NULL,
	[StatueLivraison] [tinyint] NOT NULL,
	[IdLivreur] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLivraison] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livreur]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livreur](
	[IdLivreur] [int] IDENTITY(1,1) NOT NULL,
	[NomLivreur] [varchar](50) NOT NULL,
	[DateLivraison] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLivreur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paiement]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paiement](
	[IdPaiement] [int] IDENTITY(1,1) NOT NULL,
	[TypePaiement] [varchar](50) NOT NULL,
	[StatuePaiement] [varchar](50) NOT NULL,
	[Banque] [varchar](50) NOT NULL,
	[DatePaiement] [datetime2](7) NOT NULL,
	[Montant] [float] NOT NULL,
	[IdClient] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPaiement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreparationCommande]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreparationCommande](
	[IdPreparationCommande] [int] IDENTITY(1,1) NOT NULL,
	[Statut] [varchar](50) NOT NULL,
	[DatePrevue] [datetime] NOT NULL,
	[IdStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPreparationCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProduitFournisseur]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProduitFournisseur](
	[IdProduitFournisseur] [int] IDENTITY(1,1) NOT NULL,
	[IdProduit] [int] NOT NULL,
	[IdFournisseur] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProduitFournisseur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[IdStock] [int] IDENTITY(1,1) NOT NULL,
	[quantite] [int] NOT NULL,
	[delaisLivraison] [date] NOT NULL,
	[Idproduit] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdStock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAdresse]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAdresse](
	[IdTypeAdresse] [int] IDENTITY(1,1) NOT NULL,
	[IntituleType] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTypeAdresse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT ((0)) FOR [quantite]
GO
ALTER TABLE [dbo].[Adresse]  WITH CHECK ADD FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Adresse]  WITH CHECK ADD FOREIGN KEY([IdTypeAdresse])
REFERENCES [dbo].[TypeAdresse] ([IdTypeAdresse])
GO
ALTER TABLE [dbo].[Commande]  WITH CHECK ADD FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Commande]  WITH CHECK ADD FOREIGN KEY([IdFacture])
REFERENCES [dbo].[Facture] ([IdFacture])
GO
ALTER TABLE [dbo].[Commande]  WITH CHECK ADD FOREIGN KEY([IdProduit])
REFERENCES [dbo].[Produit] ([IdProduit])
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([IdAdresse])
REFERENCES [dbo].[Adresse] ([IdAdresse])
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([IdPaiement])
REFERENCES [dbo].[Paiement] ([IdPaiement])
GO
ALTER TABLE [dbo].[Livraison]  WITH CHECK ADD FOREIGN KEY([IdLivreur])
REFERENCES [dbo].[Livreur] ([IdLivreur])
GO
ALTER TABLE [dbo].[Paiement]  WITH CHECK ADD FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[PreparationCommande]  WITH CHECK ADD FOREIGN KEY([IdStock])
REFERENCES [dbo].[Stock] ([IdStock])
GO
ALTER TABLE [dbo].[ProduitFournisseur]  WITH CHECK ADD FOREIGN KEY([IdFournisseur])
REFERENCES [dbo].[Fournisseur] ([IdFournisseur])
GO
ALTER TABLE [dbo].[ProduitFournisseur]  WITH CHECK ADD FOREIGN KEY([IdProduit])
REFERENCES [dbo].[Produit] ([IdProduit])
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([Idproduit])
REFERENCES [dbo].[Produit] ([IdProduit])
GO
/****** Object:  StoredProcedure [dbo].[s]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s]
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[SelectionCommandeClient]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectionCommandeClient]
	@IdClient int = 0
AS
	select p.[Description],c.Quantite,c.DateCommande,c.PrixTTC,cl.NomClient,cl.PrenomClient
	from Commande as c,Produit as p,Client as cl
	where c.IdClient=@IdClient and c.IdClient=cl.IdClient and c.IdProduit=p.IdProduit;
RETURN
GO
/****** Object:  StoredProcedure [dbo].[SelectListeClienAdresse]    Script Date: 28/03/2019 16:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectListeClienAdresse]
	
AS
	SELECT c.NomClient,c.PrenomClient,a.Rue,a.CodePostal,a.Ville FROM dbo.Client AS c, dbo.Adresse AS a WHERE c.IdClient = a.IdClient;
RETURN
GO
USE [master]
GO
ALTER DATABASE [vpc] SET  READ_WRITE 
GO
