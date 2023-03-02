CREATE DATABASE hotelsurperu
GO

USE hotelsurperu
GO

-- TABLAS:

CREATE TABLE empresas
(
	idempresa		INT IDENTITY(1,1) PRIMARY KEY,
	razonsocial		NVARCHAR(100)		NOT NULL,
	ruc				CHAR(11)			NOT NULL,
	direccion		NVARCHAR(150)		NOT NULL,
	telefono		CHAR(9)				NULL,
	email			NVARCHAR(100)		NULL,
	fecharegistro	DATETIME			NOT NULL DEFAULT GETDATE(),
	fechaupdate		DATETIME			NULL,
	fechabaja		DATETIME			NULL,
	estado			BIT					NOT NULL DEFAULT 1,
	CONSTRAINT uk_razonsocial_emp UNIQUE (razonsocial),
	CONSTRAINT uk_ruc_emp UNIQUE (ruc),
	CONSTRAINT ck_ruc_emp CHECK (ruc LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT ck_telefono_emp CHECK (telefono LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

-- PROCEDIMIENTOS ALMACENADOS

CREATE PROCEDURE spu_empresas_registrar
	@razonsocial		NVARCHAR(100),
	@ruc				CHAR(11),
	@direccion			NVARCHAR(150),
	@telefono			CHAR(9),
	@email				NVARCHAR(100)
AS BEGIN
	
	-- Posibles campos vacíos
	IF @telefono = '' SET @telefono = NULL 
	IF @email = '' SET @email = NULL 

	INSERT INTO empresas (razonsocial, ruc, direccion, telefono, email) VALUES
		(@razonsocial, @ruc, @direccion, @telefono, @email)
END
GO

-- Registros de prueba
EXEC spu_empresas_registrar 'Importaciones del Sur', '20454748586', 'Jiron San Miguel 123 Ica Ica Ica', '',''
EXEC spu_empresas_registrar 'Taxi el Veloz SAC', '20457452581', 'Av. Paraiso 789 Pisco Pisco Ica', '956789441',''
EXEC spu_empresas_registrar 'ISTP Ingenieros', '20254748451', 'Urb. Lima Mz H lote 5 Chincha Alta Chincha Ica', '987123005','istpingenieros@gmail.com'
GO

CREATE PROCEDURE spu_empresas_listar
	@estado			BIT
AS BEGIN
	SELECT	idempresa,
			razonsocial,
			ruc,
			direccion,
			telefono,
			email
	FROM empresas
	WHERE estado = @estado
	ORDER BY idempresa DESC
END
GO

-- Solo listaremos las activas
EXEC spu_empresas_listar 1
GO

-- Procedimiento que permite la actualización
CREATE PROCEDURE spu_empresas_actualizar
	@idempresa			INT,
	@razonsocial		NVARCHAR(100),
	@ruc				CHAR(11),
	@direccion			NVARCHAR(150),
	@telefono			CHAR(9),
	@email				NVARCHAR(100)
AS BEGIN
	UPDATE empresas SET
		razonsocial = @razonsocial,
		ruc = @ruc,
		direccion = @direccion,
		telefono = @telefono,
		email = @email,
		fechaupdate = GETDATE()
	WHERE idempresa = @idempresa
END 
GO

-- Como se veía originalmente el registro:
-- Importaciones del Sur, 20454748586, Jiron San Miguel 123 Ica Ica Ica, '',''
EXEC spu_empresas_actualizar 1, 'Importaciones del Sur EIRL', '20454748586', 'Jiron San Miguel #123 - Piso 2, Ica Ica Ica', '989225413','elsur@hotmail.com'
GO

-- Verificando la actualización
EXEC spu_empresas_listar 1
GO

-- Procedimiento para la eliminación lógica
CREATE PROCEDURE spu_empresas_eliminar
	@idempresa		INT
AS BEGIN
	UPDATE empresas SET
		estado = 0,
		fechabaja = GETDATE()
	WHERE idempresa = 1
END
GO

-- Eliminar segundo registro
EXEC spu_empresas_eliminar 2
GO

-- Verificar lista de eliminados
EXEC spu_empresas_listar 0
GO

-- Dejar todo como estaba...
UPDATE empresas SET fechabaja = NULL, estado = 1
GO