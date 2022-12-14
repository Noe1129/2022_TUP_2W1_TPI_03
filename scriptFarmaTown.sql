USE [master]
GO
/****** Object:  Database [farmatown3]    Script Date: 07/10/2022 20:01:24 ******/
CREATE DATABASE [farmatown3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'farmatown3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\farmatown3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'farmatown3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\farmatown3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [farmatown3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [farmatown3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [farmatown3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [farmatown3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [farmatown3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [farmatown3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [farmatown3] SET ARITHABORT OFF 
GO
ALTER DATABASE [farmatown3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [farmatown3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [farmatown3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [farmatown3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [farmatown3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [farmatown3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [farmatown3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [farmatown3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [farmatown3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [farmatown3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [farmatown3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [farmatown3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [farmatown3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [farmatown3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [farmatown3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [farmatown3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [farmatown3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [farmatown3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [farmatown3] SET  MULTI_USER 
GO
ALTER DATABASE [farmatown3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [farmatown3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [farmatown3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [farmatown3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [farmatown3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [farmatown3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [farmatown3] SET QUERY_STORE = OFF
GO
USE [farmatown3]
GO
/****** Object:  Table [dbo].[articulos]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[articulos](
	[idArticulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[stock] [int] NULL,
	[precioUnitario] [decimal](10, 2) NULL,
	[idTipoArticulo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[dni] [bigint] NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[telefono] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalleLotes]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleLotes](
	[idDetalleLote] [int] IDENTITY(1,1) NOT NULL,
	[idLote] [int] NULL,
	[idArticulo] [int] NULL,
	[fechaVencimientoLote] [date] NULL,
	[cantidadComprada] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetalleLote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detallesFactura]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallesFactura](
	[idDetalle] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NULL,
	[idArticulo] [int] NULL,
	[descuento] [int] NULL,
	[montoDescontado] [decimal](10, 2) NULL,
	[subtotal] [decimal](10, 2) NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturas](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[total] [decimal](10, 2) NULL,
	[tieneObraSocial] [bit] NULL,
	[dniCliente] [bigint] NULL,
	[idUsuario] [int] NULL,
	[tipoPago] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lotes]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lotes](
	[idLote] [int] IDENTITY(1,1) NOT NULL,
	[fechaCompra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarjetas]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarjetas](
	[nro_tarjeta] [bigint] NOT NULL,
	[cod_seguridad] [int] NULL,
	[fecha_venc] [date] NULL,
	[dni] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoArticulos]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoArticulos](
	[idTipoArticulo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoPago]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoPago](
	[tipoPago] [bit] NOT NULL,
	[descripcion] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[tipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoUsuarios]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoUsuarios](
	[idTipoUsuario] [int] NOT NULL,
	[descripcion] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](15) NULL,
	[pwd] [varchar](15) NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[idTipoUsuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([idTipoArticulo])
REFERENCES [dbo].[tipoArticulos] ([idTipoArticulo])
GO
ALTER TABLE [dbo].[detalleLotes]  WITH CHECK ADD FOREIGN KEY([idArticulo])
REFERENCES [dbo].[articulos] ([idArticulo])
GO
ALTER TABLE [dbo].[detalleLotes]  WITH CHECK ADD FOREIGN KEY([idLote])
REFERENCES [dbo].[lotes] ([idLote])
GO
ALTER TABLE [dbo].[detallesFactura]  WITH CHECK ADD FOREIGN KEY([idArticulo])
REFERENCES [dbo].[articulos] ([idArticulo])
GO
ALTER TABLE [dbo].[detallesFactura]  WITH CHECK ADD FOREIGN KEY([idFactura])
REFERENCES [dbo].[facturas] ([idFactura])
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([dniCliente])
REFERENCES [dbo].[clientes] ([dni])
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([tipoPago])
REFERENCES [dbo].[tipoPago] ([tipoPago])
GO
ALTER TABLE [dbo].[tarjetas]  WITH CHECK ADD FOREIGN KEY([dni])
REFERENCES [dbo].[clientes] ([dni])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([idTipoUsuario])
REFERENCES [dbo].[tipoUsuarios] ([idTipoUsuario])
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ARTICULOS_COMBO_BOX]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS_COMBO_BOX]
AS
BEGIN
	
	SELECT idArticulo, nombre, a.idTipoArticulo,descripcion,precioUnitario 
	from articulos a join tipoArticulos tp on a.idTipoArticulo=tp.idTipoArticulo;
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ARTICULOS_GRILLA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS_GRILLA]
AS
BEGIN
	
	SELECT idArticulo, nombre, tp.idTipoArticulo, descripcion, a.precioUnitario,stock
	from articulos a join tipoArticulos tp on a.idTipoArticulo=tp.idTipoArticulo;
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ARTICULOS_POR_NOMBRE]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS_POR_NOMBRE]
@nombre nvarchar(20)
AS
BEGIN
	
	SELECT idArticulo, nombre, descripcion, a.precioUnitario,stock
	from articulos a join tipoArticulos tp on a.idArticulo=tp.idTipoArticulo
	where nombre like '%'+@nombre+'%'
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES]
AS
BEGIN
	
	select nombre,apellido,dni,telefono from clientes
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES_CON_TARJETA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES_CON_TARJETA]
AS
BEGIN	
select nombre,apellido,c.dni,telefono, nro_tarjeta,cod_seguridad, fecha_venc from clientes c LEFT JOIN tarjetas t ON c.dni = t.dni
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES_POR_DNI]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES_POR_DNI]
@DNI bigint
AS
BEGIN
	
	select nombre,apellido,dni,telefono from clientes
	where dni = @DNI
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_DETALLES_POR_ID_FACTURA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_CONSULTAR_DETALLES_POR_ID_FACTURA]
@idFactura int
as
begin
select idDetalle, a.nombre, cantidad,df.precio,montoDescontado,subtotal 
from detallesFactura df 
join articulos a on df.idArticulo=a.idArticulo
where idFactura=@idFactura 
end

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_FACTURA_POR_FECHA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CONSULTAR_FACTURA_POR_FECHA]
@fechaDesde datetime,
@fechaHasta datetime
as
begin
SELECT idFactura, c.apellido + ' ' +c.nombre 'Cliente', fecha, total 
from facturas f join clientes c on f.dniCliente=c.dni
where f.fecha between @fechaDesde and @fechaHasta
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_FACTURAS]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_FACTURAS]
AS
BEGIN
	SELECT idFactura, c.apellido + ' ' +c.nombre 'Nombre', fecha, total, p.descripcion
	from facturas f join clientes c on f.dniCliente=c.dni join tipoPago p on p.tipoPago=f.tipoPago
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_STOCK]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_CONSULTAR_STOCK]
@idArticulo int,
@stock int OUTPUT
as
begin
set @stock = (select stock from articulos where idArticulo=@idArticulo)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPO_ARTICULOS_COMBO_BOX]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CONSULTAR_TIPO_ARTICULOS_COMBO_BOX]
as
begin
	select * from tipoArticulos
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPOS_USUARIO_COMBO_BOX]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_CONSULTAR_TIPOS_USUARIO_COMBO_BOX]
AS
BEGIN
	select * from  tipoUsuarios 
END	 
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_USUARIOS_GRILLA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CONSULTAR_USUARIOS_GRILLA]
as
begin
select idUsuario,nombre,apellido,tu.descripcion 
from usuarios u join tipoUsuarios tu on u.idTipoUsuario=tu.idTipoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_USUARIO]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CREAR_USUARIO]
@nombreReal nvarchar(20),
@apellido nvarchar(20),
@username nvarchar(20),
@password nvarchar(20),
@tipoUsuario int
as
begin
insert into usuarios(usuario,pwd,nombre,apellido,idTipoUsuario)
values(@username,@password,@nombreReal,@apellido,@tipoUsuario)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_ARTICULO]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ELIMINAR_ARTICULO]
@idArticulo int
as
delete from articulos
where idArticulo = @idArticulo;
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_DETALLE]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ELIMINAR_DETALLE]
@idDetalle int
as
begin
delete from detallesFactura 
where idDetalle=@idDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_DETALLES]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ELIMINAR_DETALLES]
@idDetalle int
as
begin
delete from detallesFactura
where idDetalle=@idDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_FACTURA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure[dbo].[SP_ELIMINAR_FACTURA]
@idFactura int
as
begin
delete from detallesFactura
where idFactura=@idFactura

delete from facturas
where idFactura=@idFactura
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_USUARIO]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ELIMINAR_USUARIO]
@idUsuario int
as
begin
delete from usuarios
where idUsuario=@idUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_ARTICULO]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_INSERTAR_ARTICULO]
@nombreArticulo varchar(20),
@stock int,
@precio decimal(10,2),
@tipoArticulo int
as
begin
insert into articulos(nombre,stock,precioUnitario,idTipoArticulo)
values (@nombreArticulo,@stock,@precio,@tipoArticulo)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CLIENTE]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_INSERTAR_CLIENTE]
@DNI bigint,
@nom_cliente nvarchar(20),
@ape_cliente nvarchar(20),
@telefono bigint
as
begin
insert into CLIENTES(DNI,nombre,apellido,telefono)
values (@DNI,@nom_cliente,@ape_cliente,@telefono)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE_FACTURA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_INSERTAR_DETALLE_FACTURA] 
	@idFactura int,
	@idArticulo int,
	@cantidad int,
	@descuento int,
	@montoDescontado decimal(10,2),
	@subtotal decimal(10,2),
	@precio decimal(10,2)
AS
BEGIN
	INSERT INTO detallesFactura(idFactura, idArticulo, cantidad, descuento, montoDescontado, subtotal,precio)
    VALUES (@idFactura, @idArticulo, @cantidad, @descuento, @montoDescontado, @subtotal,@precio);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_MAESTRO_FACTURA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO_FACTURA] 
	@total money,
	@tieneObraSocial bit,
	@dniCliente bigint,
	@idUsuario int,
	@tipoPago bit,
    @idFactura int output
	
AS
BEGIN
	INSERT INTO FACTURAS(fecha, total, tieneObraSocial, dniCliente,idUsuario, tipoPago)
    VALUES (GETDATE(), @total, @tieneObraSocial, @dniCliente, @idUsuario, @tipoPago);	
    set @idFactura = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_TARJETA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_INSERTAR_TARJETA]
@nro_tarjeta bigint,
@cod_seguridad int,
@fecha_venc date,
@dni bigint
as
begin
insert into TARJETAS(nro_tarjeta,cod_seguridad,fecha_venc,dni)
values (@nro_tarjeta,@cod_seguridad,@fecha_venc,@dni)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_ARTICULO]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_MODIFICAR_ARTICULO]
@idArticulo int,
@nombre varchar(20),
@stock int,
@precio decimal(10,2),
@idTipoArticulo int
as
begin
update articulos 
set nombre=@nombre, stock=@stock, precioUnitario=@precio, idTipoArticulo=@idTipoArticulo
WHERE idArticulo = @idArticulo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_CLIENTE]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_MODIFICAR_CLIENTE]
@DNI bigint,
@nombreCliente varchar(20),
@apellidoCliente varchar(20),
@telefono bigint
as
begin
update clientes 
set nombre=@nombreCliente, apellido=@apellidoCliente, telefono=@telefono
WHERE dni = @DNI
end
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_DATOS_USUARIO]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_OBTENER_DATOS_USUARIO]
@usuario nvarchar(20),
@contraseña nvarchar(20), 
@idUsuario int OUTPUT,
@nombre varchar(20) OUTPUT,
@apellido varchar(20) OUTPUT,
@tipoUsuario int OUTPUT
as
begin
Select usuario, pwd from usuarios 
where usuario=@usuario and pwd=@contraseña
set @idUsuario = (select max(idUsuario) from usuarios where usuario=@usuario and pwd=@contraseña)
set @nombre = (select nombre from usuarios where usuario=@usuario and pwd=@contraseña)
set @apellido = (select apellido from usuarios where usuario=@usuario and pwd=@contraseña)
set @tipoUsuario = (select idTipoUsuario from usuarios where usuario=@usuario and pwd=@contraseña)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMA_FACTURA]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_PROXIMA_FACTURA]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(idFactura)+1  FROM FACTURAS);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VERIFICAR_LOGIN]    Script Date: 07/10/2022 20:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_VERIFICAR_LOGIN]
@usuario nvarchar(20),
@contraseña nvarchar(20)
as
begin
Select usuario, pwd from usuarios 
where usuario=@usuario and pwd=@contraseña
end

GO
USE [master]
GO
ALTER DATABASE [farmatown3] SET  READ_WRITE 
GO

--DESCONTAR STOCK LUEGO DE UNA VENTA
CREATE TRIGGER dbo.TRIG_DESCONTAR_STOCK ON dbo.detallesFactura
AFTER INSERT
AS
Update articulos set stock = stock-D.cantidad 
from articulos A inner join
INSERTED as D on D.idArticulo=A.idArticulo

go

--SUMAR STOCK DE LA FACTURA DESPUES DE UNA DEVOLUCION
CREATE TRIGGER dbo.TRIG_SUMAR_STOCK ON [detallesFactura]
   for Delete
   as
   Update A set a.stock=a.stock + df.cantidad
   from articulos as A inner join
   DELETED as df on df.idArticulo=A.idArticulo

go

--RESTAR AL TOTAL DE LA FACTURA DESPUES DE UNA DEVOLUCION
CREATE TRIGGER dbo.TRIG_ACTUALIZAR_TOTAL_FACTURA ON [detallesFactura]
	for Delete
	as
	Update F set F.total = F.total - df.subtotal
	from facturas F inner join
	deleted df on df.idFactura=f.idFactura
