USE [master]
GO
/****** Object:  Database [FitnessMe_15118078]    Script Date: 6/5/2021 08:09:31 ******/
CREATE DATABASE [FitnessMe_15118078]
GO
ALTER DATABASE [FitnessMe_15118078] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FitnessMe_15118078].[15118078].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FitnessMe_15118078] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET ARITHABORT OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FitnessMe_15118078] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FitnessMe_15118078] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FitnessMe_15118078] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FitnessMe_15118078] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET RECOVERY FULL 
GO
ALTER DATABASE [FitnessMe_15118078] SET  MULTI_USER 
GO
ALTER DATABASE [FitnessMe_15118078] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FitnessMe_15118078] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FitnessMe_15118078] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FitnessMe_15118078] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FitnessMe_15118078] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FitnessMe_15118078] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FitnessMe_15118078', N'ON'
GO
ALTER DATABASE [FitnessMe_15118078] SET QUERY_STORE = OFF
GO
USE [FitnessMe_15118078]
GO
IF (SCHEMA_ID('15118078') IS NOT NULL)
BEGIN
    DROP SCHEMA [15118078];
END
GO
CREATE SCHEMA [15118078]
GO
/****** Object:  Table [15118078].[__EFMigrationsHistory]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetRoleClaims]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetRoles]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetUserClaims]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetUserLogins]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetUserRoles]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetUsers]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[AspNetUserTokens]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[Food]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[Food](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Calories] [float] NOT NULL,
	[CreatedAt_15118078] [datetime2](7) NULL,
	[UpdatedAt_15118078] [datetime2](7) NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[log_15118078]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[log_15118078](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[tableName] [varchar](50) NOT NULL,
	[action] [varchar](50) NULL,
	[changeDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [15118078].[Meal]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[Meal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FoodId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[Portion] [float] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[CreatedAt_15118078] [datetime2](7) NULL,
	[UpdatedAt_15118078] [datetime2](7) NULL,
 CONSTRAINT [PK_Meal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[Nutrition]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[Nutrition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FoodId] [int] NOT NULL,
	[Protein] [nvarchar](max) NOT NULL,
	[Carbohydrates] [nvarchar](max) NOT NULL,
	[Fats] [nvarchar](max) NOT NULL,
	[CreatedAt_15118078] [datetime2](7) NULL,
	[UpdatedAt_15118078] [datetime2](7) NULL,
 CONSTRAINT [PK_Nutrition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [15118078].[Weight]    Script Date: 6/5/2021 08:09:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [15118078].[Weight](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[Mass] [float] NOT NULL,
	[Day] [datetime2](7) NOT NULL,
	[CreatedAt_15118078] [datetime2](7) NULL,
	[UpdatedAt_15118078] [datetime2](7) NULL,
 CONSTRAINT [PK_Weight] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TRIGGER insert_food
   ON  [15118078].Food 
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Food'
           ,'Insert')

END
GO
CREATE TRIGGER update_food
   ON  [15118078].Food 
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Food'
           ,'Update')

END
GO
CREATE TRIGGER insert_meal
   ON  [15118078].Meal
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Meal'
           ,'Insert')

END
GO
CREATE TRIGGER update_meal
   ON  [15118078].Meal 
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Meal'
           ,'Update')

END
GO
CREATE TRIGGER insert_weight
   ON  [15118078].Weight
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Weight'
           ,'Insert')

END
GO
CREATE TRIGGER update_weight
   ON  [15118078].Weight 
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Weight'
           ,'Update')

END
GO
CREATE TRIGGER insert_nutrition
   ON  [15118078].Nutrition
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Nutrition'
           ,'Insert')

END
GO
CREATE TRIGGER update_nutrition
   ON  [15118078].Nutrition 
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [15118078].[log_15118078]
           ([tableName]
           ,[action])
     VALUES
           ('Nutrition'
           ,'Update')

END
GO

INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210518101033_createUserTables', N'5.0.6')
INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210518101101_createFoodTable', N'5.0.6')
INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210518131402_createNutritionTable', N'5.0.6')
INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210518133928_addCaloriesColumn', N'5.0.6')
INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210527021852_createWeightTable', N'5.0.6')
INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210530061301_createMealTable', N'5.0.6')
INSERT [15118078].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210603032627_addCreatedAtColumns', N'5.0.6')
GO
INSERT [15118078].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Administrator', N'ADMINISTRATOR', NULL)
INSERT [15118078].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'User', N'USER', NULL)
INSERT [15118078].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'Client', N'CLIENT', NULL)
GO
INSERT [15118078].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1c35b34e-5999-41fe-b478-7367a176af19', N'1')
INSERT [15118078].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ba38174c-5e2a-47ee-b877-3eb27fd0ea93', N'2')
INSERT [15118078].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5bccdb70-c440-47b3-b594-6cbe259ddff3', N'3')
GO
INSERT [15118078].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1c35b34e-5999-41fe-b478-7367a176af19', N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 0, N'AQAAAAEAACcQAAAAEK5w3kd1hF2WuGZrmPC5ShErTtUOy4yhiPXxvJV8qpTo6cLHd16PY9umOPxQVHMdJg==', N'5UFNEFLJUJUWODAS5KL7BFOFCJKJSMYP', N'1bbc1c69-e423-43d5-ab47-a10f3b3520ff', NULL, 0, 0, NULL, 1, 0)
INSERT [15118078].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5bccdb70-c440-47b3-b594-6cbe259ddff3', N'dkostowww@gmail.com', N'DKOSTOWWW@GMAIL.COM', N'dkostowww@gmail.com', N'DKOSTOWWW@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPd4PmBXh1rQS6tUju3QpVfv7fwZJ/PpujSCvdTw9MVdQoR8tfE5V660qyYKEo+pFQ==', N'I4YH2WZAMLD3JKQMU5UHN757TCAFTA6U', N'b569a010-c217-465e-ad12-fd4c15b84e88', NULL, 0, 0, NULL, 1, 0)
INSERT [15118078].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ba38174c-5e2a-47ee-b877-3eb27fd0ea93', N'user@gmail.com', N'USER@GMAIL.COM', N'user@gmail.com', N'USER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEB9U6E9nMgltiXLba3piBIfiCa8MdvSVe5F/5d3Q/lWQvoq1BQrcWC0xt8TcmX+KrA==', N'6P2B57HCTOYIRD7D5AVPYWGVQOQ6ONVM', N'85770bcf-e0ff-4cd2-b9a3-9009fc80a3f5', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [15118078].[Food] ON 

INSERT [15118078].[Food] ([Id], [Name], [Calories], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (3, N'Banana', 100, CAST(N'2021-06-03T03:30:07.9934169' AS DateTime2), CAST(N'2021-06-03T03:31:17.1707224' AS DateTime2))
INSERT [15118078].[Food] ([Id], [Name], [Calories], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (4, N'Pork Shoulder Steak', 194, CAST(N'2021-06-03T03:31:51.2886095' AS DateTime2), CAST(N'2021-06-03T03:31:51.2886100' AS DateTime2))
INSERT [15118078].[Food] ([Id], [Name], [Calories], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (5, N'Chicken Breasts', 115, CAST(N'2021-06-03T03:32:07.8637794' AS DateTime2), CAST(N'2021-06-05T04:30:35.9261283' AS DateTime2))
INSERT [15118078].[Food] ([Id], [Name], [Calories], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (6, N'Apple', 60, CAST(N'2021-06-05T04:33:50.9257961' AS DateTime2), CAST(N'2021-06-05T04:39:38.6422372' AS DateTime2))
INSERT [15118078].[Food] ([Id], [Name], [Calories], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (7, N'Orange', 48, CAST(N'2021-06-05T04:39:04.2978873' AS DateTime2), CAST(N'2021-06-05T04:39:09.5816036' AS DateTime2))
SET IDENTITY_INSERT [15118078].[Food] OFF
GO
SET IDENTITY_INSERT [15118078].[log_15118078] ON 

INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (1, N'Food', N'Update', CAST(N'2021-06-05T07:30:36.050' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (2, N'Food', N'Insert', CAST(N'2021-06-05T07:33:51.087' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (3, N'Food', N'Update', CAST(N'2021-06-05T07:34:03.687' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (4, N'Weight', N'Insert', CAST(N'2021-06-05T07:38:44.020' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (5, N'Weight', N'Update', CAST(N'2021-06-05T07:38:49.943' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (6, N'Food', N'Insert', CAST(N'2021-06-05T07:39:04.307' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (7, N'Nutrition', N'Insert', CAST(N'2021-06-05T07:39:04.333' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (8, N'Food', N'Update', CAST(N'2021-06-05T07:39:09.590' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (9, N'Nutrition', N'Update', CAST(N'2021-06-05T07:39:09.590' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (10, N'Nutrition', N'Update', CAST(N'2021-06-05T07:39:09.597' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (11, N'Food', N'Update', CAST(N'2021-06-05T07:39:38.643' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (12, N'Nutrition', N'Update', CAST(N'2021-06-05T07:39:38.647' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (13, N'Nutrition', N'Update', CAST(N'2021-06-05T07:39:38.650' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (14, N'Meal', N'Insert', CAST(N'2021-06-05T07:40:41.333' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (15, N'Meal', N'Update', CAST(N'2021-06-05T07:42:25.963' AS DateTime))
INSERT [15118078].[log_15118078] ([Id], [tableName], [action], [changeDate]) VALUES (16, N'Meal', N'Update', CAST(N'2021-06-05T07:42:36.277' AS DateTime))
SET IDENTITY_INSERT [15118078].[log_15118078] OFF
GO
SET IDENTITY_INSERT [15118078].[Meal] ON 

INSERT [15118078].[Meal] ([Id], [FoodId], [UserId], [Portion], [Type], [Date], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (7, 3, N'5bccdb70-c440-47b3-b594-6cbe259ddff3', 0.5, N'Breakfast', CAST(N'2021-06-03T06:35:00.0000000' AS DateTime2), CAST(N'2021-06-03T03:35:55.3955498' AS DateTime2), CAST(N'2021-06-03T03:36:47.9201062' AS DateTime2))
INSERT [15118078].[Meal] ([Id], [FoodId], [UserId], [Portion], [Type], [Date], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (8, 7, N'1c35b34e-5999-41fe-b478-7367a176af19', 0.8, N'Breakfast', CAST(N'2021-06-05T07:40:00.0000000' AS DateTime2), CAST(N'2021-06-05T04:40:41.3126363' AS DateTime2), CAST(N'2021-06-05T04:42:36.2702394' AS DateTime2))
SET IDENTITY_INSERT [15118078].[Meal] OFF
GO
SET IDENTITY_INSERT [15118078].[Nutrition] ON 

INSERT [15118078].[Nutrition] ([Id], [FoodId], [Protein], [Carbohydrates], [Fats], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (3, 3, N'1', N'24', N'0', CAST(N'2021-06-03T03:30:08.1132826' AS DateTime2), CAST(N'2021-06-03T03:31:17.1762346' AS DateTime2))
INSERT [15118078].[Nutrition] ([Id], [FoodId], [Protein], [Carbohydrates], [Fats], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (4, 4, N'25', N'1', N'10', CAST(N'2021-06-03T03:31:51.2952057' AS DateTime2), CAST(N'2021-06-03T03:31:51.2952061' AS DateTime2))
INSERT [15118078].[Nutrition] ([Id], [FoodId], [Protein], [Carbohydrates], [Fats], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (5, 5, N'21', N'1', N'3', CAST(N'2021-06-03T03:32:07.8669557' AS DateTime2), CAST(N'2021-06-05T04:30:36.0707476' AS DateTime2))
INSERT [15118078].[Nutrition] ([Id], [FoodId], [Protein], [Carbohydrates], [Fats], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (6, 6, N'1', N'14', N'0', CAST(N'2021-06-05T04:33:51.1144764' AS DateTime2), CAST(N'2021-06-05T04:39:38.6503709' AS DateTime2))
INSERT [15118078].[Nutrition] ([Id], [FoodId], [Protein], [Carbohydrates], [Fats], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (7, 7, N'0', N'12', N'0', CAST(N'2021-06-05T04:39:04.3116905' AS DateTime2), CAST(N'2021-06-05T04:39:09.5953500' AS DateTime2))
SET IDENTITY_INSERT [15118078].[Nutrition] OFF
GO
SET IDENTITY_INSERT [15118078].[Weight] ON 

INSERT [15118078].[Weight] ([Id], [UserId], [Mass], [Day], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (7, N'5bccdb70-c440-47b3-b594-6cbe259ddff3', 108.4, CAST(N'2021-06-03T06:35:00.0000000' AS DateTime2), CAST(N'2021-06-03T03:35:34.9886461' AS DateTime2), CAST(N'2021-06-03T03:35:34.9887798' AS DateTime2))
INSERT [15118078].[Weight] ([Id], [UserId], [Mass], [Day], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (8, N'5bccdb70-c440-47b3-b594-6cbe259ddff3', 107.2, CAST(N'2021-06-02T06:35:00.0000000' AS DateTime2), CAST(N'2021-06-03T03:35:42.6232651' AS DateTime2), CAST(N'2021-06-03T03:35:42.6232654' AS DateTime2))
INSERT [15118078].[Weight] ([Id], [UserId], [Mass], [Day], [CreatedAt_15118078], [UpdatedAt_15118078]) VALUES (9, N'1c35b34e-5999-41fe-b478-7367a176af19', 108.5, CAST(N'2021-06-05T07:38:00.0000000' AS DateTime2), CAST(N'2021-06-05T04:38:43.8534951' AS DateTime2), CAST(N'2021-06-05T04:38:49.9345826' AS DateTime2))
SET IDENTITY_INSERT [15118078].[Weight] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [15118078].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 6/5/2021 08:09:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [15118078].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [15118078].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [15118078].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [15118078].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [15118078].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 6/5/2021 08:09:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [15118078].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Meal_FoodId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_Meal_FoodId] ON [15118078].[Meal]
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Meal_UserId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_Meal_UserId] ON [15118078].[Meal]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Nutrition_FoodId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_Nutrition_FoodId] ON [15118078].[Nutrition]
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Weight_UserId]    Script Date: 6/5/2021 08:09:31 ******/
CREATE NONCLUSTERED INDEX [IX_Weight_UserId] ON [15118078].[Weight]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [15118078].[Food] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Calories]
GO
ALTER TABLE [15118078].[log_15118078] ADD  DEFAULT (NULL) FOR [action]
GO
ALTER TABLE [15118078].[log_15118078] ADD  DEFAULT (getdate()) FOR [changeDate]
GO
ALTER TABLE [15118078].[Nutrition] ADD  DEFAULT (N'') FOR [Protein]
GO
ALTER TABLE [15118078].[Nutrition] ADD  DEFAULT (N'') FOR [Carbohydrates]
GO
ALTER TABLE [15118078].[Nutrition] ADD  DEFAULT (N'') FOR [Fats]
GO
ALTER TABLE [15118078].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [15118078].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [15118078].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [15118078].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [15118078].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [15118078].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [15118078].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [15118078].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [15118078].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [15118078].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [15118078].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [15118078].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [15118078].[Meal]  WITH CHECK ADD  CONSTRAINT [FK_Meal_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [15118078].[AspNetUsers] ([Id])
GO
ALTER TABLE [15118078].[Meal] CHECK CONSTRAINT [FK_Meal_AspNetUsers_UserId]
GO
ALTER TABLE [15118078].[Meal]  WITH CHECK ADD  CONSTRAINT [FK_Meal_Food_FoodId] FOREIGN KEY([FoodId])
REFERENCES [15118078].[Food] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[Meal] CHECK CONSTRAINT [FK_Meal_Food_FoodId]
GO
ALTER TABLE [15118078].[Nutrition]  WITH CHECK ADD  CONSTRAINT [FK_Nutrition_Food_FoodId] FOREIGN KEY([FoodId])
REFERENCES [15118078].[Food] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [15118078].[Nutrition] CHECK CONSTRAINT [FK_Nutrition_Food_FoodId]
GO
ALTER TABLE [15118078].[Weight]  WITH CHECK ADD  CONSTRAINT [FK_Weight_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [15118078].[AspNetUsers] ([Id])
GO
ALTER TABLE [15118078].[Weight] CHECK CONSTRAINT [FK_Weight_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [FitnessMe_15118078] SET  READ_WRITE 
GO
