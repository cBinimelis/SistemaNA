create view vUsuarios as
select u.IdUsuario, u.Nombre, u.Apellido,u.Correo,u.Password, e.IdEstadoUsuario,e.Descripcion as 'DescEstado', t.IdTipoUsuario,t.Descripcion as 'DescTipo'
FROM Usuarios u
INNER JOIN TipoUsuario t ON t.IdTipoUsuario = u.IdTipoUsuario
INNER JOIN EstadoUsuario e ON e.IdEstadoUsuario = u.IdEstadoUsuario
WHERE u.IdEstadoUsuario != 3

select * from vUsuarios