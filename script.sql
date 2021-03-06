USE [master]
GO
/****** Object:  Database [Conservatorio]    Script Date: 1/25/2017 10:52:37 AM ******/
CREATE DATABASE [Conservatorio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Conservatorio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Conservatorio.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Conservatorio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Conservatorio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Conservatorio] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Conservatorio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Conservatorio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Conservatorio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Conservatorio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Conservatorio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Conservatorio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Conservatorio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Conservatorio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Conservatorio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Conservatorio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Conservatorio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Conservatorio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Conservatorio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Conservatorio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Conservatorio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Conservatorio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Conservatorio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Conservatorio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Conservatorio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Conservatorio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Conservatorio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Conservatorio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Conservatorio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Conservatorio] SET RECOVERY FULL 
GO
ALTER DATABASE [Conservatorio] SET  MULTI_USER 
GO
ALTER DATABASE [Conservatorio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Conservatorio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Conservatorio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Conservatorio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Conservatorio] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Conservatorio', N'ON'
GO
USE [Conservatorio]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clase](
	[IdClase] [int] IDENTITY(1,1) NOT NULL,
	[IdProfesor] [int] NULL,
	[Dia] [varchar](15) NOT NULL,
	[Hora] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Clase] PRIMARY KEY CLUSTERED 
(
	[IdClase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clase_Estudiante]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase_Estudiante](
	[IdClase_Estudiante] [int] NOT NULL,
	[IdClase] [int] NOT NULL,
	[IdEstudiante] [int] NOT NULL,
	[Nota] [float] NULL,
 CONSTRAINT [PK_Clase_Estudiante] PRIMARY KEY CLUSTERED 
(
	[IdClase_Estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Curso]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curso](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[NombreCurso] [varchar](100) NOT NULL,
	[IdCursoRequisito] [int] NOT NULL,
	[IdInstrumento] [int] NOT NULL,
	[Nivel] [int] NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Encargado]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Encargado](
	[IdEncargado] [int] NOT NULL,
	[Parentesco] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Encargado] PRIMARY KEY CLUSTERED 
(
	[IdEncargado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiante](
	[IdEstudiante] [int] NOT NULL,
	[IdEncargado] [int] NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante_Instrumento]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante_Instrumento](
	[IdEstudiante] [int] NOT NULL,
	[IdInstrumento] [int] NOT NULL,
 CONSTRAINT [PK_Estudiante_Instrumento] PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC,
	[IdInstrumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Instrumento]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Instrumento](
	[IdInstrumento] [int] IDENTITY(1,1) NOT NULL,
	[NombreInstrumento] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Instrumento] PRIMARY KEY CLUSTERED 
(
	[IdInstrumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pago_Matricula]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pago_Matricula](
	[IdMatricula] [int] IDENTITY(1,1) NOT NULL,
	[Periodo] [varchar](10) NOT NULL,
	[Año] [int] NOT NULL,
	[Monto] [decimal](7, 2) NOT NULL,
	[FechaPago] [date] NOT NULL,
	[IdEstudiante] [int] NOT NULL,
	[Comentario] [varchar](200) NULL,
	[TipoPago] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Pago_Matricula] PRIMARY KEY CLUSTERED 
(
	[IdMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pago_Mensualidad]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pago_Mensualidad](
	[IdMensualidad] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [decimal](7, 2) NOT NULL,
	[FechaPago] [date] NOT NULL,
	[Mes] [date] NOT NULL,
	[IdEstudiante] [int] NOT NULL,
	[Comentario] [varchar](200) NULL,
	[TipoPago] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Pago_Mensualidad] PRIMARY KEY CLUSTERED 
(
	[IdMensualidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Cedula] [int] NULL,
	[Estado] [bit] NOT NULL,
	[Email] [varchar](50) NULL,
	[Direccion] [varchar](150) NULL,
	[Ocupacion] [varchar](50) NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono1] [int] NOT NULL,
	[Telefono2] [int] NULL,
	[Telefono3] [int] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesor](
	[IdProfesor] [int] NOT NULL,
	[GradoAcademico] [varchar](100) NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[IdProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesor_Instrumento]    Script Date: 1/25/2017 10:52:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor_Instrumento](
	[IdProfesor] [int] NOT NULL,
	[IdInstrumento] [int] NOT NULL,
 CONSTRAINT [PK_Profesor_Instrumento] PRIMARY KEY CLUSTERED 
(
	[IdProfesor] ASC,
	[IdInstrumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Clase]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Profesor] FOREIGN KEY([IdProfesor])
REFERENCES [dbo].[Profesor] ([IdProfesor])
GO
ALTER TABLE [dbo].[Clase] CHECK CONSTRAINT [FK_Clase_Profesor]
GO
ALTER TABLE [dbo].[Clase_Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Estudiante_Clase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[Clase] ([IdClase])
GO
ALTER TABLE [dbo].[Clase_Estudiante] CHECK CONSTRAINT [FK_Clase_Estudiante_Clase]
GO
ALTER TABLE [dbo].[Clase_Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Estudiante_Estudiante] FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiante] ([IdEstudiante])
GO
ALTER TABLE [dbo].[Clase_Estudiante] CHECK CONSTRAINT [FK_Clase_Estudiante_Estudiante]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Curso] FOREIGN KEY([IdCursoRequisito])
REFERENCES [dbo].[Curso] ([IdCurso])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Curso]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Instrumento] FOREIGN KEY([IdInstrumento])
REFERENCES [dbo].[Instrumento] ([IdInstrumento])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Instrumento]
GO
ALTER TABLE [dbo].[Encargado]  WITH CHECK ADD  CONSTRAINT [FK_Encargado_Persona] FOREIGN KEY([IdEncargado])
REFERENCES [dbo].[Persona] ([IdPersona])
GO
ALTER TABLE [dbo].[Encargado] CHECK CONSTRAINT [FK_Encargado_Persona]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_Persona] FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Persona] ([IdPersona])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_Estudiante_Persona]
GO
ALTER TABLE [dbo].[Estudiante_Instrumento]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_Instrumento_Instrumento] FOREIGN KEY([IdInstrumento])
REFERENCES [dbo].[Instrumento] ([IdInstrumento])
GO
ALTER TABLE [dbo].[Estudiante_Instrumento] CHECK CONSTRAINT [FK_Estudiante_Instrumento_Instrumento]
GO
ALTER TABLE [dbo].[Pago_Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Matricula_Estudiante] FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiante] ([IdEstudiante])
GO
ALTER TABLE [dbo].[Pago_Matricula] CHECK CONSTRAINT [FK_Pago_Matricula_Estudiante]
GO
ALTER TABLE [dbo].[Pago_Mensualidad]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Mensualidad_Estudiante] FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiante] ([IdEstudiante])
GO
ALTER TABLE [dbo].[Pago_Mensualidad] CHECK CONSTRAINT [FK_Pago_Mensualidad_Estudiante]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Persona] FOREIGN KEY([IdProfesor])
REFERENCES [dbo].[Persona] ([IdPersona])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_Profesor_Persona]
GO
ALTER TABLE [dbo].[Profesor_Instrumento]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Instrumento_Instrumento] FOREIGN KEY([IdInstrumento])
REFERENCES [dbo].[Instrumento] ([IdInstrumento])
GO
ALTER TABLE [dbo].[Profesor_Instrumento] CHECK CONSTRAINT [FK_Profesor_Instrumento_Instrumento]
GO
ALTER TABLE [dbo].[Profesor_Instrumento]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Instrumento_Profesor] FOREIGN KEY([IdProfesor])
REFERENCES [dbo].[Profesor] ([IdProfesor])
GO
ALTER TABLE [dbo].[Profesor_Instrumento] CHECK CONSTRAINT [FK_Profesor_Instrumento_Profesor]
GO
USE [master]
GO
ALTER DATABASE [Conservatorio] SET  READ_WRITE 
GO
