USE [master]
GO
/****** Object:  Database [WRT_v01]    Script Date: 2019-04-29 14:25:07 ******/
CREATE DATABASE [WRT_v01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WRT_v01', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WRT_v01.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WRT_v01_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WRT_v01_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WRT_v01] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WRT_v01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WRT_v01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WRT_v01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WRT_v01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WRT_v01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WRT_v01] SET ARITHABORT OFF 
GO
ALTER DATABASE [WRT_v01] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WRT_v01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WRT_v01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WRT_v01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WRT_v01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WRT_v01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WRT_v01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WRT_v01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WRT_v01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WRT_v01] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WRT_v01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WRT_v01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WRT_v01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WRT_v01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WRT_v01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WRT_v01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WRT_v01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WRT_v01] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WRT_v01] SET  MULTI_USER 
GO
ALTER DATABASE [WRT_v01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WRT_v01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WRT_v01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WRT_v01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WRT_v01] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WRT_v01] SET QUERY_STORE = OFF
GO
USE [WRT_v01]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [WRT_v01]
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Driver]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Driver] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Employer]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Employer] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_GPer]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_GPer] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Passenger]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Passenger] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Per]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Per] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Route]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Route] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Schedule]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Schedule] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Station]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Station] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_SubStation]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_SubStation] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [WRT_v01]
GO
/****** Object:  Sequence [dbo].[Seq_Ticket]    Script Date: 2019-04-29 14:25:08 ******/
CREATE SEQUENCE [dbo].[Seq_Ticket] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
/****** Object:  Table [dbo].[wrt_i_bus]    Script Date: 2019-04-29 14:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_bus](
	[id_bus] [nchar](15) NOT NULL,
	[type] [nchar](15) NULL,
	[note] [nvarchar](50) NULL,
	[flag] [char](1) NULL,
 CONSTRAINT [PK_wrt_i_bus_id_bus] PRIMARY KEY CLUSTERED 
(
	[id_bus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_driver]    Script Date: 2019-04-29 14:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_driver](
	[id_driver] [nchar](7) NOT NULL,
	[name] [nvarchar](50) NULL,
	[birth] [date] NULL,
	[phone] [varchar](15) NULL,
	[add] [nvarchar](50) NULL,
	[flag] [char](1) NULL,
	[note] [nvarchar](50) NULL,
 CONSTRAINT [PK_wrt_i_driver_id_driver] PRIMARY KEY CLUSTERED 
(
	[id_driver] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_employer]    Script Date: 2019-04-29 14:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_employer](
	[id_employer] [nchar](7) NOT NULL,
	[id_group_per] [nchar](7) NULL,
	[name] [nvarchar](50) NULL,
	[phone] [nchar](15) NULL,
	[e_mail] [nchar](50) NULL,
	[add] [nvarchar](50) NULL,
	[pass] [nchar](50) NULL,
	[flag] [char](1) NULL,
 CONSTRAINT [PK_wrt_i_employer_id_employer] PRIMARY KEY CLUSTERED 
(
	[id_employer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_group_per]    Script Date: 2019-04-29 14:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_group_per](
	[id_group_per] [nchar](7) NOT NULL,
	[id_per] [nchar](7) NULL,
	[name] [nchar](7) NULL,
 CONSTRAINT [PK_wrt_i_group_per_id_group_per] PRIMARY KEY CLUSTERED 
(
	[id_group_per] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_passenger]    Script Date: 2019-04-29 14:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_passenger](
	[id_passenger] [nchar](7) NOT NULL,
	[name] [nvarchar](50) NULL,
	[phone] [nchar](15) NULL,
	[e_mail] [nchar](50) NULL,
	[pass] [nchar](50) NULL,
	[flag] [char](1) NULL,
 CONSTRAINT [PK_wrt_i_passenger_id_passenger] PRIMARY KEY CLUSTERED 
(
	[id_passenger] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_per]    Script Date: 2019-04-29 14:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_per](
	[id_per] [nchar](7) NOT NULL,
	[name] [nchar](7) NULL,
	[content_per] [nchar](2) NULL,
 CONSTRAINT [PK_wrt_i_per_id_per] PRIMARY KEY CLUSTERED 
(
	[id_per] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_route]    Script Date: 2019-04-29 14:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_route](
	[id_route] [nchar](7) NOT NULL,
	[id_origin] [nchar](7) NOT NULL,
	[id_destinate] [nchar](7) NOT NULL,
	[estimate_time] [time](7) NULL,
	[note] [nvarchar](50) NULL,
	[flag] [char](1) NULL,
 CONSTRAINT [PK_wrt_i_route_id_route] PRIMARY KEY CLUSTERED 
(
	[id_route] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_station]    Script Date: 2019-04-29 14:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_station](
	[id_station] [nchar](7) NOT NULL,
	[name] [nvarchar](50) NULL,
	[flag] [char](1) NULL,
 CONSTRAINT [PK_wrt_i_station_id_station] PRIMARY KEY CLUSTERED 
(
	[id_station] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_substation]    Script Date: 2019-04-29 14:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_substation](
	[id_substation] [nchar](7) NOT NULL,
	[add] [nvarchar](50) NULL,
	[phone] [nchar](15) NULL,
	[flag] [char](1) NULL,
	[id_station] [nchar](7) NULL,
 CONSTRAINT [PK_wrt_i_sub_id_substation] PRIMARY KEY CLUSTERED 
(
	[id_substation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_suggestion]    Script Date: 2019-04-29 14:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_suggestion](
	[id_passenger] [nchar](7) NOT NULL,
	[date_time] [datetime] NULL,
	[content] [nvarchar](200) NULL,
 CONSTRAINT [PK_wrt_i_suggestion_id_passenger] PRIMARY KEY CLUSTERED 
(
	[id_passenger] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_i_ticket]    Script Date: 2019-04-29 14:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_i_ticket](
	[id_ticket] [nchar](7) NOT NULL,
	[id_schedule] [nchar](7) NOT NULL,
	[id_passenger] [nchar](7) NOT NULL,
	[number_seat] [nchar](5) NULL,
	[flag] [char](1) NULL,
 CONSTRAINT [PK_wrt_i_ticket_id_ticket] PRIMARY KEY CLUSTERED 
(
	[id_ticket] ASC,
	[id_schedule] ASC,
	[id_passenger] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_t_schedule]    Script Date: 2019-04-29 14:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_t_schedule](
	[id_schedule] [nchar](7) NOT NULL,
	[id_route] [nchar](7) NOT NULL,
	[id_driver] [nchar](7) NOT NULL,
	[departure] [datetime] NULL,
	[price] [float] NULL,
	[note] [nvarchar](50) NULL,
	[flag] [char](1) NULL,
	[id_bus] [nchar](15) NULL,
 CONSTRAINT [PK_wrt_t_schedule_id_schedule] PRIMARY KEY CLUSTERED 
(
	[id_schedule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_temp]    Script Date: 2019-04-29 14:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_temp](
	[date_temp] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wrt_temp_hour]    Script Date: 2019-04-29 14:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wrt_temp_hour](
	[hour_temp] [time](7) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[wrt_i_employer] ([id_employer], [id_group_per], [name], [phone], [e_mail], [add], [pass], [flag]) VALUES (N'EM00002', NULL, N'Nguyễn Hoàng Luân', N'0334140780     ', N'luannh@gmail.com                                  ', N'Hồ Chí Minh', N'nttdv123                                          ', N'0')
INSERT [dbo].[wrt_i_employer] ([id_employer], [id_group_per], [name], [phone], [e_mail], [add], [pass], [flag]) VALUES (N'EM00004', NULL, N'Nguyễn Hoàng Thái', N'0155217700     ', N'thainh@gmail.com                                  ', N'Hồ Chí Minh', N'nttdv123                                          ', N'0')
INSERT [dbo].[wrt_i_employer] ([id_employer], [id_group_per], [name], [phone], [e_mail], [add], [pass], [flag]) VALUES (N'EM00005', NULL, N'Trần Văn Hòa', N'0335217894     ', N'hoatv@gmail.com                                   ', N'Hồ Chí Minh', N'nttdv123                                          ', N'0')
INSERT [dbo].[wrt_temp] ([date_temp]) VALUES (CAST(N'2019-04-29T10:24:13.067' AS DateTime))
INSERT [dbo].[wrt_temp_hour] ([hour_temp]) VALUES (CAST(N'05:00:00' AS Time))
ALTER TABLE [dbo].[wrt_i_driver] ADD  CONSTRAINT [seq_wrt_i_driver]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Driver],'DR0000#')) FOR [id_driver]
GO
ALTER TABLE [dbo].[wrt_i_employer] ADD  CONSTRAINT [seq_wrt_i_employer]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Employer],'EM0000#')) FOR [id_employer]
GO
ALTER TABLE [dbo].[wrt_i_group_per] ADD  CONSTRAINT [seq_wrt_i_group_per]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_GPer],'GRP000#')) FOR [id_group_per]
GO
ALTER TABLE [dbo].[wrt_i_passenger] ADD  CONSTRAINT [seq_wrt_i_passenger]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Passenger],'PA0000#')) FOR [id_passenger]
GO
ALTER TABLE [dbo].[wrt_i_per] ADD  CONSTRAINT [seq_wrt_i_per]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Per],'PER000#')) FOR [id_per]
GO
ALTER TABLE [dbo].[wrt_i_route] ADD  CONSTRAINT [seq_wrt_i_route]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Route],'RO0000#')) FOR [id_route]
GO
ALTER TABLE [dbo].[wrt_i_station] ADD  CONSTRAINT [seq_wrt_i_station]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Station],'ST0000#')) FOR [id_station]
GO
ALTER TABLE [dbo].[wrt_i_substation] ADD  CONSTRAINT [seq_wrt_i_substation]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_SubStation],'SS000#')) FOR [id_substation]
GO
ALTER TABLE [dbo].[wrt_i_ticket] ADD  CONSTRAINT [seq_wrt_i_ticket]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Ticket],'TI0000#')) FOR [id_ticket]
GO
ALTER TABLE [dbo].[wrt_t_schedule] ADD  CONSTRAINT [seq_wrt_t_schedule]  DEFAULT (format(NEXT VALUE FOR [dbo].[Seq_Schedule],'SC0000#')) FOR [id_schedule]
GO
ALTER TABLE [dbo].[wrt_i_employer]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_employer_wrt_i_group_per] FOREIGN KEY([id_group_per])
REFERENCES [dbo].[wrt_i_group_per] ([id_group_per])
GO
ALTER TABLE [dbo].[wrt_i_employer] CHECK CONSTRAINT [FK_wrt_i_employer_wrt_i_group_per]
GO
ALTER TABLE [dbo].[wrt_i_group_per]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_group_per_wrt_i_per] FOREIGN KEY([id_per])
REFERENCES [dbo].[wrt_i_per] ([id_per])
GO
ALTER TABLE [dbo].[wrt_i_group_per] CHECK CONSTRAINT [FK_wrt_i_group_per_wrt_i_per]
GO
ALTER TABLE [dbo].[wrt_i_route]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_route_wrt_i_station] FOREIGN KEY([id_origin])
REFERENCES [dbo].[wrt_i_station] ([id_station])
GO
ALTER TABLE [dbo].[wrt_i_route] CHECK CONSTRAINT [FK_wrt_i_route_wrt_i_station]
GO
ALTER TABLE [dbo].[wrt_i_route]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_route_wrt_i_station1] FOREIGN KEY([id_destinate])
REFERENCES [dbo].[wrt_i_station] ([id_station])
GO
ALTER TABLE [dbo].[wrt_i_route] CHECK CONSTRAINT [FK_wrt_i_route_wrt_i_station1]
GO
ALTER TABLE [dbo].[wrt_i_substation]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_substation_wrt_i_station] FOREIGN KEY([id_station])
REFERENCES [dbo].[wrt_i_station] ([id_station])
GO
ALTER TABLE [dbo].[wrt_i_substation] CHECK CONSTRAINT [FK_wrt_i_substation_wrt_i_station]
GO
ALTER TABLE [dbo].[wrt_i_suggestion]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_suggestion_wrt_i_passenger] FOREIGN KEY([id_passenger])
REFERENCES [dbo].[wrt_i_passenger] ([id_passenger])
GO
ALTER TABLE [dbo].[wrt_i_suggestion] CHECK CONSTRAINT [FK_wrt_i_suggestion_wrt_i_passenger]
GO
ALTER TABLE [dbo].[wrt_i_ticket]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_ticket_wrt_i_passenger] FOREIGN KEY([id_passenger])
REFERENCES [dbo].[wrt_i_passenger] ([id_passenger])
GO
ALTER TABLE [dbo].[wrt_i_ticket] CHECK CONSTRAINT [FK_wrt_i_ticket_wrt_i_passenger]
GO
ALTER TABLE [dbo].[wrt_i_ticket]  WITH CHECK ADD  CONSTRAINT [FK_wrt_i_ticket_wrt_t_schedule] FOREIGN KEY([id_schedule])
REFERENCES [dbo].[wrt_t_schedule] ([id_schedule])
GO
ALTER TABLE [dbo].[wrt_i_ticket] CHECK CONSTRAINT [FK_wrt_i_ticket_wrt_t_schedule]
GO
ALTER TABLE [dbo].[wrt_t_schedule]  WITH CHECK ADD  CONSTRAINT [FK_wrt_t_schedule_wrt_i_bus] FOREIGN KEY([id_bus])
REFERENCES [dbo].[wrt_i_bus] ([id_bus])
GO
ALTER TABLE [dbo].[wrt_t_schedule] CHECK CONSTRAINT [FK_wrt_t_schedule_wrt_i_bus]
GO
ALTER TABLE [dbo].[wrt_t_schedule]  WITH CHECK ADD  CONSTRAINT [FK_wrt_t_schedule_wrt_i_driver] FOREIGN KEY([id_driver])
REFERENCES [dbo].[wrt_i_driver] ([id_driver])
GO
ALTER TABLE [dbo].[wrt_t_schedule] CHECK CONSTRAINT [FK_wrt_t_schedule_wrt_i_driver]
GO
ALTER TABLE [dbo].[wrt_t_schedule]  WITH CHECK ADD  CONSTRAINT [FK_wrt_t_schedule_wrt_i_route] FOREIGN KEY([id_route])
REFERENCES [dbo].[wrt_i_route] ([id_route])
GO
ALTER TABLE [dbo].[wrt_t_schedule] CHECK CONSTRAINT [FK_wrt_t_schedule_wrt_i_route]
GO
USE [master]
GO
ALTER DATABASE [WRT_v01] SET  READ_WRITE 
GO
