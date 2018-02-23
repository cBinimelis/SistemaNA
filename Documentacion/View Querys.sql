create view vUsuarios as
SELECT u.IdUsuario, u.Nombre, u.Apellido,u.Correo,u.Password, e.IdEstadoUsuario,e.Descripcion as 'DescEstado', t.IdTipoUsuario,t.Descripcion as 'DescTipo'
FROM Usuarios u
INNER JOIN TipoUsuario t ON t.IdTipoUsuario = u.IdTipoUsuario
INNER JOIN EstadoUsuario e ON e.IdEstadoUsuario = u.IdEstadoUsuario
WHERE u.IdEstadoUsuario != 3

SELECT * FROM vUsuarios;

CREATE VIEW vProductos AS
SELECT p.IdProducto, p.CodBarra, p.Descripcion,p.Precio, CONVERT(date, p.FechaCreacion, 103) AS 'Fecha Creacion' , t.Descripcion AS 'Tipo', e.Descripcion AS 'Estado', u.Nombre +' '+ LEFT(u.Apellido, 1) AS 'Usuario'
FROM Productos p
INNER JOIN TipoProducto t ON t.IdTipoProducto = p.IdTipoProducto
INNER JOIN EstadoProducto e ON e.IdEstadoProducto = p.IdEstadoProducto
INNER JOIN Usuarios u ON u.IdUsuario = p.IdUsuario

SELECT * FROM vProductos